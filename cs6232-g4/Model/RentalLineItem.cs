namespace cs6232_g4.Model
{
    public class RentalLineItem
    {
        public int LineItemId { get; set; }
        public string Name { get; set; }
        public int RentalTransactionId { get; set; }
        public int FurnitureId { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
    }
}
