/// <summary>
/// Member Data Access Layer
/// Group 4
/// Programmer: LM Laskey
/// Modified: 4/5/24
/// </summary>

using cs6232_g4.DAL;
using Furnitures.Model;
using System.Data.SqlClient;

namespace Furnitures.DAL
{
    public class FurnitureDAL
    {
        /// <summary>
        /// Gets all furniture
        /// </summary>
        /// <returns>furniture list</returns>
        public List<Furniture> GetAllFuruniture()
        {
            List<Furniture> FurnitureList = new List<Furniture>();

            string selectStatement =
                "SELECT furniture_id, name, description, daily_rental_rate, instock_quantity, total_quantity, category_name, style_name FROM Furniture";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.FurnitureId = (int)reader["furniture_id"];
                            furniture.Name = (string)reader["name"];
                            furniture.Description = (string)reader["description"];
                            furniture.DailyRentalRate = (decimal)reader["daily_rental_rate"];
                            furniture.InstockQuantity = (int)reader["instock_quantity"];
                            furniture.TotalQuantity = (int)reader["total_quantity"];
                            furniture.CategoryName = (string)reader["category_name"];
                            furniture.StyleName = (string)reader["style_name"];

                            FurnitureList.Add(furniture);
                        }
                    }
                }
            }
            return FurnitureList;
        }

        /// <summary>
        /// Gets all furniture with specified category
        /// </summary>
        /// <param name="Category"></param>
        /// <returns> member list </returns>
        public List<Furniture> GetFurnitureByCategory(string Category)
        {
            List<Furniture> FurnitureList = new List<Furniture>();

            string selectStatement =
                "SELECT furniture_id, name, description, daily_rental_rate, instock_quantity, total_quantity, category_name, style_name FROM Furniture" +
                "FROM Furniture " +
                "WHERE category_name = @Category"
            ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@Category", Category));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.FurnitureId = (int)reader["furniture_id"];
                            furniture.Name = (string)reader["name"];
                            furniture.Description = (string)reader["description"];
                            furniture.DailyRentalRate = (decimal)reader["daily_rental_rate"];
                            furniture.InstockQuantity = (int)reader["instock_quantity"];
                            furniture.TotalQuantity = (int)reader["total_quantity"];
                            furniture.CategoryName = (string)reader["category_name"];
                            furniture.StyleName = (string)reader["style_name"];

                            FurnitureList.Add(furniture);
                        }
                    }
                }
            }
            return FurnitureList;
        }

        /// <summary>
        /// Gets all furniture with specified furniture ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns> member list </returns>
        public List<Furniture> GetFurnitureByID(string ID)
        {
            List<Furniture> FurnitureList = new List<Furniture>();

            string selectStatement =
                "SELECT furniture_id, name, description, daily_rental_rate, instock_quantity, total_quantity, category_name, style_name FROM Furniture" +
                "FROM Furniture " +
                "WHERE furniture_id = @ID"
            ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@ID", ID));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.FurnitureId = (int)reader["furniture_id"];
                            furniture.Name = (string)reader["name"];
                            furniture.Description = (string)reader["description"];
                            furniture.DailyRentalRate = (decimal)reader["daily_rental_rate"];
                            furniture.InstockQuantity = (int)reader["instock_quantity"];
                            furniture.TotalQuantity = (int)reader["total_quantity"];
                            furniture.CategoryName = (string)reader["category_name"];
                            furniture.StyleName = (string)reader["style_name"];

                            FurnitureList.Add(furniture);
                        }
                    }
                }
            }
            return FurnitureList;
        }

        /// <summary>
        /// Gets all furniture with specified style
        /// </summary>
        /// <param name="Style"></param>
        /// <returns> member list </returns>
        public List<Furniture> GetFurnitureByStyle(string Style)
        {
            List<Furniture> FurnitureList = new List<Furniture>();

            string selectStatement =
                "SELECT furniture_id, name, description, daily_rental_rate, instock_quantity, total_quantity, category_name, style_name FROM Furniture" +
                "FROM Furniture " +
                "WHERE style_name = @Style"
            ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@Style", Style));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.FurnitureId = (int)reader["furniture_id"];
                            furniture.Name = (string)reader["name"];
                            furniture.Description = (string)reader["description"];
                            furniture.DailyRentalRate = (decimal)reader["daily_rental_rate"];
                            furniture.InstockQuantity = (int)reader["instock_quantity"];
                            furniture.TotalQuantity = (int)reader["total_quantity"];
                            furniture.CategoryName = (string)reader["category_name"];
                            furniture.StyleName = (string)reader["style_name"];

                            FurnitureList.Add(furniture);
                        }
                    }
                }
            }
            return FurnitureList;
        }

        /// <summary>
        /// update furniture by ID
        /// </summary>
        /// <param>furnitureId</param>
        /// <param>rentedQuantity</param>
        public void UpdateFurniture(int furnitureId, int rentedQuantity)
        {
            string command = $"UPDATE [dbo].[Furniture] SET instock_quantity=instock_quantity-@rentedQuantity WHERE furniture_id=@furniture_id";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insert_command = new SqlCommand(command, connection))
                {
                    insert_command.Parameters.Add("@furniture_id", System.Data.SqlDbType.Int);
                    insert_command.Parameters.Add("@rentedQuantity", System.Data.SqlDbType.Int);

                    insert_command.Parameters["@furniture_id"].Value = furnitureId;
                    insert_command.Parameters["@rentedQuantity"].Value = rentedQuantity;

                    insert_command.ExecuteNonQuery();

                }
            }
        }
    }
}
