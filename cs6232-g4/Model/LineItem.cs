

namespace LineItems.Model
{
    public class LineItem
    {
        public int TransactionID { get; set; }

        public int LineID { get; set; }

        public string FurnitureID { get; set; }

        public decimal Quantity { get; set; }

        public decimal FineOrAmountOwed { get; set; }

    }
}
