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
        /// <returns></returns>
        public List<string> GetFurnitureCategories()
        {
            return this._furnitureDAL.GetFurnitureCategories();
        }

        /// <summary>
        /// Gets the furniture styles.
        /// </summary>
        /// <returns></returns>
        public List<string> GetFurnitureStyles()
        {
            return this._furnitureDAL.GetFurnitureStyles();
        }

        /// <summary>
        /// Gets all furniture identifiers.
        /// </summary>
        /// <returns></returns>
        public List<int> GetAllFurnitureIDs()
        {
            return this._furnitureDAL.GetAllFurnitureIDs();
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

        public List<Furniture> GetFurnitureById(int furnitureID)
        {
            return this._furnitureDAL.GetFurnitureById(furnitureID);
        }

        public List<Furniture> GetFurnitureByCategory(string Category)
        {
            return this._furnitureDAL.GetFurnitureByCategory(Category);
        }

        public List<Furniture> GetFurnitureByStyle(string Style)
        {
            return this._furnitureDAL.GetFurnitureByStyle(Style);
        }

    }
}
