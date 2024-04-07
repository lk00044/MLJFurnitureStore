// <summary>
/// Handles the interaction between the view and the Furniture Data Access Layer     
/// Programmer: LKeller
/// Date: 11 Mrach 2024
/// </summary>
/// 
using Employees.DAL;
using Furnitures.Model;

namespace Members.Controller
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
            return this._furnitureDAL.GetAllFuruniture();
        }

        /// <summary>
        /// Gets the furniture categories.
        /// </summary>
        /// <returns>list of furniture categories</returns>
        public List<string> GetFurnitureCategories()
        {
            return this._furnitureDAL.GetFurnitureCategories();
        }

        /// <summary>
        /// Gets the furniture styles.
        /// </summary>
        /// <returns>list of furniture styles</returns>
        public List<string> GetFurnitureStyles()
        {
            return this._furnitureDAL.GetFurnitureStyles();
        }

        /// <summary>
        /// Gets all furniture identifiers.
        /// </summary>
        /// <returns>list of furniture ids</returns>
        public List<int> GetAllFurnitureIDs()
        {
            return this._furnitureDAL.GetAllFurnitureIDs();
        }


        /// <summary>
        /// Gets the furniture by identifier.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        /// <returns>list of furniture</returns>
        public List<Furniture> GetFurnitureById(int furnitureID)
        {
            return this._furnitureDAL.GetFurnitureById(furnitureID);
        }

        /// <summary>
        /// Gets the furniture by category.
        /// </summary>
        /// <param name="Category">The category.</param>
        /// <returns>list of furniture</returns>
        public List<Furniture> GetFurnitureByCategory(string Category)
        {
            return this._furnitureDAL.GetFurnitureByCategory(Category);
        }

        /// <summary>
        /// Gets the furniture by style.
        /// </summary>
        /// <param name="Style">The style.</param>
        /// <returns>list of furniture</returns>
        public List<Furniture> GetFurnitureByStyle(string Style)
        {
            return this._furnitureDAL.GetFurnitureByStyle(Style);
        }


        /// <summary>
        /// update furniture by ID
        /// </summary>
        /// <param>furnitureId</param>
        /// <param>rentedQuantity</param>
        public int UpdateFurniture(int furnitureId, int rentedQuantity)
        {
            return  this._furnitureDAL.UpdateFurniture(furnitureId, rentedQuantity);
        }
    }
}
