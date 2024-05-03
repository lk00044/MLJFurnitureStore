using cs6232_g4.DAL;
using Furnitures.Model;
using System.Data.SqlClient;

namespace Employees.DAL
{
    public class FurnitureDAL
    {
        /// <summary>
        /// Gets all furniture
        /// </summary>
        /// <returns>furniture list</returns>
        public List<Furniture> GetAllFurniture()
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
        /// update furniture by ID
        /// </summary>
        /// <param>furnitureId</param>
        /// <param>rentedQuantity</param>
        /// <returns># of rows affected</returns>
        public int UpdateFurniture(int furnitureId, int rentedQuantity)
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

                    return insert_command.ExecuteNonQuery();

                }
            }
        }




        /// <summary>
        /// Gets the furniture by identifier.
        /// LKeller
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        /// <returns>list of matching furniture</returns>
        public List<Furniture> GetFurnitureById(int furnitureID)
        {
            List<Furniture> FurnitureList = new List<Furniture>();

            string selectStatement =
                "SELECT furniture_id, name, description, daily_rental_rate, " +
                "instock_quantity, total_quantity, category_name, style_name " +
                "FROM Furniture " +
                "where furniture_id = @furnitureID ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@furnitureID", furnitureID));

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
        /// Gets the furniture by category.
        /// LKeller
        /// </summary>
        /// <param name="Category">The category.</param>
        /// <returns>list of furniture matching the category</returns>
        public List<Furniture> GetFurnitureByCategory(string Category)
        {
            List<Furniture> FurnitureList = new List<Furniture>();

            string selectStatement =
                "SELECT furniture_id, name, description, daily_rental_rate, " +
                "instock_quantity, total_quantity, category_name, style_name " +
                "FROM Furniture " +
                "where category_name = @Category ";

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
        /// Gets the furniture by style.
        /// LKeller
        /// </summary>
        /// <param name="Style">The style.</param>
        /// <returns>list of matching furniture based on style</returns>
        public List<Furniture> GetFurnitureByStyle(string Style)
        {
            List<Furniture> FurnitureList = new List<Furniture>();

            string selectStatement =
                "SELECT furniture_id, name, description, daily_rental_rate, " +
                "instock_quantity, total_quantity, category_name, style_name " +
                "FROM Furniture " +
                "where style_name = @Style ";

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
        /// Gets the furuniture categories.
        /// </summary>
        /// Programmer: Leslie
        /// <returns>list of names </returns>
        public List<string> GetFurnitureCategories()
        {
            List<string> FurnitureNameList = new List<string>();

            string selectStatement =
                "SELECT category_name FROM Category";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = (string)reader["category_name"];

                            FurnitureNameList.Add(name);
                        }
                    }
                }
            }
            return FurnitureNameList;
        }

        /// <summary>
        /// Gets the furuniture styles.
        /// </summary>
        /// Programmer: Leslie 
        /// <returns></returns>
        public List<string> GetFurnitureStyles()
        {
            List<string> FurnitureStyleList = new List<string>();

            string selectStatement =
                "SELECT style_name FROM Style";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = (string)reader["style_name"];

                            FurnitureStyleList.Add(name);
                        }
                    }
                }
            }
            return FurnitureStyleList;
        }

        /// <summary>
        /// Gets all furniture identifiers.
        /// </summary>
        /// <param>none</param>
        /// Programmer: Leslie
        /// <returns>list of furniture id's</returns>
        public List<int> GetAllFurnitureIDs()
        {
            List<int> FurnitureIDList = new List<int>();

            string selectStatement =
                "SELECT distinct furniture_id FROM Furniture";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int FurnitureId = (int)reader["furniture_id"];

                            FurnitureIDList.Add(FurnitureId);
                        }
                    }
                }
            }
            return FurnitureIDList;
        }
    }
}
