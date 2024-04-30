using cs6232_g4.DAL;
using Furnitures.Model;
using Microsoft.VisualBasic.ApplicationServices;
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
    }
}
