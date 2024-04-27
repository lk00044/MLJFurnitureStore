﻿// <summary>
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
            return this._furnitureDAL.GetAllFuruniture();
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

        public List<Furniture> GetFurnitureByID(string ID)
        {
            return this._furnitureDAL.GetFurnitureByID(ID);
        }

        internal List<Furniture> GetFurnituryByStyle(string style)
        {
            return this._furnitureDAL.GetFurnitureByStyle(style);
        }
    }
}
