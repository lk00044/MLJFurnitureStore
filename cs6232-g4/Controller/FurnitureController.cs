﻿// <summary>
/// Handles the interaction between the view and the Furniture Data Access Layer     
/// Programmer: LKeller, Laskey
/// Modified: 1 April 2024
/// </summary>
/// 

using Furniture.DAL;

namespace Furniture.Controller
{
    public class FurnitureController
    {
        private readonly FurnitureDAL _furnitureDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureController"/> class.
        /// </summary>
        public FurnitureController()
        {
            _furnitureDAL = new FurnitureDAL();
        }

        /// <summary>
        /// get all furniture
        /// </summary>
        public List<Model.Furniture> GetAllFurniture()
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

        /// <summary>
        /// Gets the furniture by category.
        /// </summary>
        /// <param name="category">The category.</param>
        /// <returns></returns>
        public List<Model.Furniture> GetFurnitureByCategory(string category)
        {
            return this._furnitureDAL.GetFurnitureByCategory(category);
        }

        /// <summary>
        /// Gets the furniture by identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <returns></returns>
        public List<Model.Furniture> GetFurnitureByID(int ID)
        {
            return this._furnitureDAL.GetFurnitureByID(ID);
        }

        /// <summary>
        /// Gets the furniture by style.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <returns></returns>
        public List<Model.Furniture> GetFurnitureByStyle(string style)
        {
            return this._furnitureDAL.GetFurnitureByStyle(style);
        }

        /// <summary>
        /// Method to search for furniture based on ID, category, and style
        /// Programmer: LM
        /// </summary>
        /// <param name="id"></param>
        /// <param name="category"></param>
        /// <param name="style"></param>
        /// <returns></returns>
        public List<Model.Furniture> SearchFurniture(int id, string category, string style)
        {
            // Initialize a list to store the search results
            List<Model.Furniture> searchResults = new List<Model.Furniture>();

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
