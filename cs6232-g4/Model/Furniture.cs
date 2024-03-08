/// <summary>
/// Furniture Class
/// Group 4
/// Programmer: LKeller
/// Date: 08/03/24
/// </summary>
namespace Furnitures.Model
{
    public class Furniture
    {
        public int FurnitureId { get; set; }

        public string FurnitureName { get; set; }

        public string FurnitureDescription { get; set; }

        public string Category { get; set; }

        public string Style { get; set; }

        public int TotalQuantity { get; set; }

        public int AvailableQuantity { get; set; }

        public decimal RentalRate { get; set; }

    }
}
