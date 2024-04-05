// <summary>
/// Handles the interaction between the view and the Furniture Data Access Layer     
/// Programmer: LKeller, Laskey
/// Modified: 1 April 2024
/// </summary>
/// 
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
            return this._furnitureDAL.GetAllFuruniture();
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

        public List<Furniture> GetFurnitureByID(string rental)
        {
            return this._furnitureDAL.GetFurnitureByID(rental);
        }

        internal List<Furniture> GetFurnituryByStyle(string style)
        {
            return this._furnitureDAL.GetFurnitureByStyle(style);
        }
    }
}
