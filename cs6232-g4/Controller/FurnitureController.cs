// <summary>
/// Handles the interaction between the view and the Furniture Data Access Layer     
/// Programmer: LKeller
/// Date: 11 Mrach 2024
/// </summary>
/// 
using Employees.DAL;
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

        internal List<Furniture> GetFurnitureByCategory(string category)
        {
            throw new NotImplementedException();
        }

        internal List<Furniture> GetFurnitureByID(string rental)
        {
            throw new NotImplementedException();
        }

        internal List<Furniture> GetFurnituryByStyle(string style)
        {
            throw new NotImplementedException();
        }
    }
}
