using cs6232_g4.DAL;
using cs6232_g4.Model;
using Members.Model;
using System.Data.SqlClient;
using System.Xml.Linq;

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
        public int CreateRentalTransaction(RentalTransaction transaction)
        {
            string insertCommand = $"INSERT INTO [dbo].[RentalTransaction] VALUES (GETDATE(),@member_id,@employee_id,@total_amount,@due_date)";
            string retrieveCommand = "SELECT SCOPE_IDENTITY();";
            string combinedQuery = $"{insertCommand};{retrieveCommand}";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(combinedQuery, connection))
                {
                    command.Parameters.Add("@member_id", System.Data.SqlDbType.Int);
                    command.Parameters.Add("@employee_id", System.Data.SqlDbType.Int);
                    command.Parameters.Add("@total_amount", System.Data.SqlDbType.Decimal);
                    command.Parameters.Add("@due_date", System.Data.SqlDbType.DateTime);

                    command.Parameters["@member_id"].Value = transaction.MemberId;
                    command.Parameters["@employee_id"].Value = transaction.EmployeeId;
                    command.Parameters["@total_amount"].Value = transaction.TotalAmount;
                    command.Parameters["@due_date"].Value = transaction.DueDate;

                    return int.Parse(command.ExecuteScalar().ToString());
                }

            }


        }

        /// <summary>
        /// Create rental line item
        /// </summary>
        /// <param name="lineItem"/>
        public void CreateRentalLineItem(RentalLineItem lineItem)
        {
            string insert = $"INSERT INTO [dbo].[RentalLineItem] VALUES (@rental_transaction_id,@furniture_id,@quantity,@subtotal);";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insert_command = new SqlCommand(insert, connection))
                {
                    insert_command.Parameters.Add("@rental_transaction_id", System.Data.SqlDbType.Int);
                    insert_command.Parameters.Add("@furniture_id", System.Data.SqlDbType.Int);
                    insert_command.Parameters.Add("@quantity", System.Data.SqlDbType.Int);
                    insert_command.Parameters.Add("@subtotal", System.Data.SqlDbType.Decimal);

                    insert_command.Parameters["@rental_transaction_id"].Value = lineItem.RentalTransactionId;
                    insert_command.Parameters["@furniture_id"].Value = lineItem.FurnitureId;
                    insert_command.Parameters["@quantity"].Value = lineItem.Quantity;
                    insert_command.Parameters["@subtotal"].Value = lineItem.Subtotal;

                    insert_command.ExecuteNonQuery();
                }
            }
        }

    }


}
