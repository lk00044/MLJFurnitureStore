/// <summary>
/// Member Data Access Layer
/// Group 4
/// Programmer: Leslie
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
        public List<Furniture> GetAllFurniture()
        {
            List<Furniture> FurnitureList = new List<Furniture>();

            string selectStatement =
                "SELECT furniture_id, name, description, daily_rental_rate, instock_quantity, total_quantity, category_name, style_name " +
                "FROM Furniture " 
                ;

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
                "SELECT furniture_id, name, description, daily_rental_rate, instock_quantity, total_quantity, category_name, style_name " +
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
        public List<Furniture> GetFurnitureByID(int ID)
        {
            List<Furniture> FurnitureList = new List<Furniture>();

            string selectStatement =
                "SELECT furniture_id, name, description, daily_rental_rate, instock_quantity, total_quantity, category_name, style_name " +
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
                "SELECT furniture_id, name, description, daily_rental_rate, instock_quantity, total_quantity, category_name, style_name " +
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
        /// Gets all furniture IDs
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Gets all furniture categories
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllFurnitureCategories()
        {
            List<string> FurnitureCategoryList = new List<string>();

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
                            string category = (string)reader["category_name"];

                            FurnitureCategoryList.Add(category);
                        }
                    }
                }
            }
            return FurnitureCategoryList;
        }

        /// <summary>
        /// Gets all furniture Styles
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllFurnitureStyles()
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
                            string style = (string)reader["style_name"];

                            FurnitureStyleList.Add(style);
                        }
                    }
                }
            }
            return FurnitureStyleList;
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
