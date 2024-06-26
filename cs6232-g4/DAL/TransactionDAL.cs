﻿using cs6232_g4.DAL;
using cs6232_g4.Model;
using System.Data.SqlClient;

/// <summary>
/// Data access layer to handle interaction between view and database
/// Programmer: Jonathan
///             CreateRentalTransaction(RentalTransaction transaction)
///             CreateRentalLineItem(RentalLineItem lineItem)
///             GetRentalLineItems(int rentalTransactionID)
/// Programmer: Leslie
///             GetMemberTransactions(int memberID)
///             VerifyMemberTransactionavailable(int memberID)
/// Programmer: LM
///             GetMemberReturns(int memberID)
///             GetReturnLineItems(int returnTransactionID)
///            
/// </summary>
/// 
namespace Employees.DAL
{
    public class TransactionDAL
    {
        /// <summary>
        /// Create a rental transaction
        /// </summary>
        /// <return>
        /// created transaction id
        /// </return>
        
        public int CreateRentalTransaction(RentalTransaction rentalTransaction, List<RentalLineItem> lineItems)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;
                try
                {
                    string insertCommand = $"INSERT INTO [dbo].[RentalTransaction] VALUES (GETDATE(),@member_id,@employee_id,@total_amount,@due_date)";
                    string retrieveCommand = "SELECT SCOPE_IDENTITY();";
                    string combinedQuery = $"{insertCommand};{retrieveCommand}";
                    command.CommandText = combinedQuery;

                    //Create rental transaction
                    command.Parameters.Add("@member_id", System.Data.SqlDbType.Int);
                    command.Parameters.Add("@employee_id", System.Data.SqlDbType.Int);
                    command.Parameters.Add("@total_amount", System.Data.SqlDbType.Decimal);
                    command.Parameters.Add("@due_date", System.Data.SqlDbType.DateTime);

                    command.Parameters["@member_id"].Value = rentalTransaction.MemberId;
                    command.Parameters["@employee_id"].Value = rentalTransaction.EmployeeId;
                    command.Parameters["@total_amount"].Value = rentalTransaction.TotalAmount;
                    command.Parameters["@due_date"].Value = rentalTransaction.DueDate;

                    int rentalTxnId = int.Parse(command.ExecuteScalar().ToString());

                    foreach(RentalLineItem lineItem in lineItems)
                    {
                        //Create line items
                        command.CommandText = $"INSERT INTO [dbo].[RentalLineItem] VALUES (@rental_transaction_id,@furniture_id,@quantity,@subtotal);";
                        command.Parameters.Add("@rental_transaction_id", System.Data.SqlDbType.Int);
                        command.Parameters.Add("@furniture_id", System.Data.SqlDbType.Int);
                        command.Parameters.Add("@quantity", System.Data.SqlDbType.Int);
                        command.Parameters.Add("@subtotal", System.Data.SqlDbType.Decimal);

                        command.Parameters["@rental_transaction_id"].Value = rentalTxnId;
                        command.Parameters["@furniture_id"].Value = lineItem.FurnitureId;
                        command.Parameters["@quantity"].Value = lineItem.Quantity;
                        command.Parameters["@subtotal"].Value = lineItem.Subtotal;

                        command.ExecuteNonQuery();

                        //Update rented furniture quantity
                        command.CommandText = $"UPDATE [dbo].[Furniture] SET instock_quantity=instock_quantity-@quantity WHERE furniture_id=@furniture_id";
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();
                    }
                    transaction.Commit();
                    return rentalTxnId;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                    return 0;
                }
            }
        }

        /// <summary>
        /// Gets rental line items per transaction
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>rental line items list</returns>
        public List<RentalLineItem> GetRentalLineItems(int rentalTransactionID)
        {
            List<RentalLineItem> LineItemsList = new List<RentalLineItem>();

            string selectStatement =
                "SELECT line_item_id, name , RentalLineItem.furniture_id, quantity, subtotal " +
                "FROM RentalLineItem " +
                "JOIN Furniture ON Furniture.furniture_id = RentalLineItem.furniture_id " +
                "WHERE rental_transaction_id = @rentalTransactionID"
            ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@rentalTransactionID", rentalTransactionID));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RentalLineItem lineItem = new RentalLineItem();
                            lineItem.LineItemId = (int)reader["line_item_id"];
                            lineItem.Name = reader["name"].ToString();
                            lineItem.FurnitureId = (int)reader["furniture_id"];
                            lineItem.Quantity = (int)reader["quantity"];
                            lineItem.Subtotal = (decimal)reader["subtotal"];
                            lineItem.RentalTransactionId = rentalTransactionID;
                            LineItemsList.Add(lineItem);
                        }
                    }
                }
            }
            return LineItemsList;
        }

        /// <summary>
        /// Gets the member transactions.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>List of rental transactions</returns>
        public List<RentalTransaction> GetMemberTransactions(int memberID)
        {

            List<RentalTransaction> RentalTransactionList = new List<RentalTransaction>();

            string selectStatement =
                "SELECT r.transaction_id, r.transaction_date, r.total_amount, r.due_date, r.member_id, " +
                        "li.line_item_id, li.quantity - ISNULL(ri.quantity,0) as quantity, li.subtotal, f.furniture_id as furniture_id,f.name as furniture_name, " +
                        "concat(e.fname, ' ' , e.lname) as employee_name, e.employee_id " +
                "FROM RentalTransaction r " +
                "JOIN RentalLineItem li " +
                "ON r.transaction_id = li.rental_transaction_id " +
                "LEFT JOIN (SELECT line_item_id, SUM(quantity) as quantity FROM ReturnLineItem GROUP BY line_item_id) ri ON ri.line_item_id = li.line_item_id " +
                "JOIN StoreMember m " +
                "ON r.member_id = m.member_id " +
                "JOIN Furniture f " +
                "On li.furniture_id = f.furniture_id " +
                "JOIN Employee e " +
                "On r.employee_id = e.employee_id " +
                "WHERE r.member_id = @memberID"
            ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@memberID", memberID));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {

                            RentalTransaction transaction = new RentalTransaction();

                            transaction.TransactionID = (int)reader["transaction_id"];
                            transaction.MemberId = (int)reader["member_id"];
                            transaction.EmployeeId = (int)reader["employee_id"];
                            transaction.EmployeeName = reader["employee_name"].ToString();
                            transaction.TransactionDate = (DateTime)reader["transaction_date"];
                            transaction.LineItemId = (int)reader["line_item_id"];
                            transaction.FurnitureID = (int)reader["furniture_id"];
                            transaction.FurnitureName = reader["furniture_name"].ToString();
                            transaction.DueDate = (DateTime)reader["due_date"];
                            transaction.LineItemQty = (int)reader["quantity"];
                            transaction.LineItemSubTotal = (decimal)reader["subtotal"];
                            transaction.TotalAmount = (decimal)reader["total_amount"];

                            RentalTransactionList.Add(transaction);

                        }
                    }
                }
            }
            return RentalTransactionList;

        }

        /// <summary>
        /// Verifies the member transactionavailable.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>bool - true of there is a transaction id</returns>
        public bool VerifyMemberTransactionavailable(int memberID)
        {
            RentalTransaction transaction = new RentalTransaction();

            string selectStatement =
                "SELECT transaction_id " +
                "FROM RentalTransaction " +
                "WHERE member_id = @memberID"
            ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@memberID", memberID));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transaction.TransactionID = (int)reader["transaction_id"];
                        }
                    }
                }
            }
            return transaction.TransactionID != 0;
        }


        /// <summary>
        /// get rental transaction time by ID.
        /// </summary>
        /// <param name="rentalTransactionID">the transaction id.</param>
        /// <returns>rental transaction date</returns>
        public DateTime GetRentalTransactionDateByID(int rentalTransactionID)
        {
            string selectStatement =
                "SELECT transaction_date " +
                "FROM RentalTransaction " +
                "WHERE transaction_id = @rentalTransactionID"
            ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@rentalTransactionID", rentalTransactionID));
                    return (DateTime)selectCommand.ExecuteScalar();
                }
            }
        }

        public List<double> CreateReturnTransaction(List<RentalLineItem> lineItems)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    //Create a return transaction and get its ID
                    command.CommandText =
                        "INSERT INTO [dbo].[ReturnTransaction] VALUES (NULL,GETDATE());" +
                        "SELECT SCOPE_IDENTITY();";
                    int returnTxnId = int.Parse(command.ExecuteScalar().ToString());
                    //Create return line items for those returned rentals
                    double txnTotalChange = 0;
                    foreach (RentalLineItem lineItem in lineItems)
                    {
                        command.CommandText = $"INSERT INTO [dbo].[ReturnLineItem] VALUES (@lineItemId,{returnTxnId},@quantity);";
                        command.Parameters.AddWithValue("@lineItemId", lineItem.LineItemId);
                        command.Parameters.AddWithValue("@quantity", lineItem.Quantity);
                        command.ExecuteNonQuery();
                        // update total amount with refunds
                        command.CommandText = $"SELECT daily_rental_rate FROM [dbo].[Furniture] WHERE furniture_id=@FurnitureId;";
                        command.Parameters.AddWithValue("@FurnitureId", lineItem.FurnitureId);
                        double rentalRate = double.Parse(command.ExecuteScalar().ToString());
                        double fineOrRefund = (DateTime.Now - lineItem.DueDate).Days * rentalRate;
                        txnTotalChange += fineOrRefund;
                        //update returned furniture
                        command.CommandText = $"UPDATE [dbo].[Furniture] SET instock_quantity=instock_quantity+@quantity WHERE furniture_id=@FurnitureId";
                        command.ExecuteNonQuery();
                        // Update rental transaction total with fine or refund
                        command.CommandText = $"UPDATE [dbo].[RentalTransaction] SET total_amount=total_amount+{fineOrRefund} WHERE transaction_id=@RentalTransactionId;";
                        command.Parameters.AddWithValue("@RentalTransactionId", lineItem.RentalTransactionId);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                    // Update return transaction with fine or refund
                    command.CommandText = $"UPDATE [dbo].[ReturnTransaction] SET fine_or_refund={txnTotalChange} WHERE return_transaction_id={returnTxnId}";
                    command.ExecuteNonQuery();
                    // Attempt to commit the transaction.
                    transaction.Commit();
                    return new List<double> { returnTxnId, txnTotalChange };
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                    return new List<double> { 0, 0 };
                }
            }
        }

        /// <summary>
        /// Gets a list of member returns.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>List of rental transactions</returns>
        public List<ReturnTransaction> GetMemberReturns(int memberID)
        {

            List<ReturnTransaction> ReturnsList = new List<ReturnTransaction>();

            string selectStatement =
                "SELECT r.return_transaction_id, r.fine_or_refund, rt.member_id, " +
                "e.employee_id, concat(e.fname, ' ' , e.lname) as employee_name, " +
                "rt.transaction_date, r.return_date, " +
                "rl.line_item_id, " +
                "f.furniture_id, f.name as furniture_name, " +
                "rl.quantity " +
                "FROM ReturnTransaction r " +
                "JOIN ReturnLineItem rl ON r.return_transaction_id = rl.return_transaction_id " +
                "JOIN RentalLineItem rr ON rl.line_item_id = rr.line_item_id " +
                "JOIN RentalTransaction rt ON rr.rental_transaction_id = rt.transaction_id " +
                "LEFT JOIN (SELECT line_item_id, SUM(quantity) as quantity FROM ReturnLineItem GROUP BY line_item_id) ri ON ri.line_item_id = rl.line_item_id " +
                "JOIN Furniture f ON rr.furniture_id = f.furniture_id " +
                "JOIN Employee e ON rt.employee_id = e.employee_id " +
                "WHERE rt.member_id = @memberID " +
                "ORDER BY r.return_transaction_id";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@memberID", memberID));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        ReturnTransaction returnTransaction;

                        while (reader.Read())
                        {
                            returnTransaction = new ReturnTransaction();

                            returnTransaction.ReturnTransactionID = (int)reader["return_transaction_id"];
                            returnTransaction.FineOrRefund = (decimal)reader["fine_or_refund"];
                            returnTransaction.MemberId = (int)reader["member_id"];
                            returnTransaction.EmployeeId = (int)reader["employee_id"];
                            returnTransaction.EmployeeName = reader["employee_name"].ToString();
                            returnTransaction.TransactionDate = (DateTime)reader["transaction_date"];
                            returnTransaction.ReturnDate = (DateTime)reader["return_date"];
                            returnTransaction.LineItemID = (int)reader["line_item_id"];
                            returnTransaction.FurnitureID = (int)reader["furniture_id"];
                            returnTransaction.FurnitureName = reader["furniture_name"].ToString();
                            returnTransaction.Quantity = (int)reader["quantity"];

                            ReturnsList.Add(returnTransaction);
                        }
                    }
                }
            }
            return ReturnsList;

        }

        /// <summary>
        /// Gets return line items for return history
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>return line items list</returns>
        public List<ReturnLineItem> GetReturnLineItems(int returnTransactionID)
        {
            List<ReturnLineItem> ReturnLineItemsList = new List<ReturnLineItem>();
            string selectStatement =
                "SELECT line_item_id, name , ReturnLineItem.furniture_id, quantity " +
                "FROM ReturnLineItem " +
                "JOIN Furniture ON Furniture.furniture_id = ReturnLineItem.furniture_id " +
                "WHERE return_transaction_id = @returnTransactionID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@returnTransactionID", returnTransactionID));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnLineItem returnLineItem = new ReturnLineItem();
                            returnLineItem.LineItemID = (int)reader["line_item_id"];
                            returnLineItem.Quantity = (int)reader["quantity"];
                            returnLineItem.ReturnTransactionID = returnTransactionID;

                            ReturnLineItemsList.Add(returnLineItem);
                        }
                    }
                }
            }
            return ReturnLineItemsList;
        }

    }
}