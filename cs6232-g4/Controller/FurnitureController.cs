// <summary>
/// Handles the interaction between the view and the Furniture Data Access Layer     
/// Programmer: LKeller, Laskey
/// Modified: 1 April 2024
/// </summary>
/// 
using Employees.DAL;
using Furnitures.DAL;
using Furnitures.Model;

namespace Furnitures.Controller
{
    public class FurnitureController
    {
        private readonly FurnitureDAL _furnitureDAL;

        public FurnitureController()
        {
            _furnitureDAL = new FurnitureDAL();
        }

        /// <summary>
        /// get all furniture
        /// </summary>
        public List<Furniture> GetAllFurniture()
        {
            return this._furnitureDAL.GetAllFurniture();
        }

        /// <summary>
        /// get all furniture IDs
        /// </summary>
        public List<int> GetAllFurnitureIDs()
        {
            return this._furnitureDAL.GetAllFurnitureIDs();
        }

        /// <summary>
        /// get all furniture Categories
        /// </summary>
        public List<string> GetAllFurnitureCategories()
        {
            return this._furnitureDAL.GetAllFurnitureCategories();
        }

        /// <summary>
        /// get all furniture Styles
        /// </summary>
        public List<string> GetAllFurnitureStyles()
        {
            return this._furnitureDAL.GetAllFurnitureStyles();
        }

        /// <summary>
        /// update furniture by ID
        /// </summary>
        /// <param>furnitureId</param>
        /// <param>rentedQuantity</param>
        public void UpdateFurniture(int furnitureId, int rentedQuantity)
        {
            this._furnitureDAL.UpdateFurniture(furnitureId, rentedQuantity);
        }

        public List<Furniture> GetFurnitureByCategory(string category)
        {
            return this._furnitureDAL.GetFurnitureByCategory(category);
        }

        public List<Furniture> GetFurnitureByID(int ID)
        {
            return this._furnitureDAL.GetFurnitureByID(ID);
        }

        public List<Furniture> GetFurnitureByStyle(string style)
        {
            return this._furnitureDAL.GetFurnitureByStyle(style);
        }

        /// <summary>
        /// Method to search for furniture based on ID, category, and style
        /// </summary>
        /// <param name="id"></param>
        /// <param name="category"></param>
        /// <param name="style"></param>
        /// <returns></returns>
        public List<Furniture> SearchFurniture(int id, string category, string style)
        {
            // Initialize a list to store the search results
            List<Furniture> searchResults = new List<Furniture>();

            if (id != 0)
            {
                searchResults.AddRange(GetFurnitureByID(id));
            }

            if (!string.IsNullOrEmpty(category))
            {
                searchResults.AddRange(GetFurnitureByCategory(category));
            }

            if (!string.IsNullOrEmpty(style))
            {
                searchResults.AddRange(GetFurnitureByStyle(style));
            }

            return searchResults;
        }
    }
}
