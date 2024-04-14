namespace cs6232_g4.Model
{
    /// <summary>
    /// Object representing the transaction of the storemember returning furniture
    /// </summary>
    /// 
    public class ReturnLineItem
    {
        public int LineItemID { get; set; }
        public int ReturnTransactionID { get; set; }
        public int Quantity { get; set; }
    }
}
