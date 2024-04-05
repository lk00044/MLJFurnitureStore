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

        public string Name { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public string StyleName { get; set; }

        public int TotalQuantity { get; set; }

        public int InstockQuantity { get; set; }
        public decimal DailyRentalRate { get; set; }
    }
}
