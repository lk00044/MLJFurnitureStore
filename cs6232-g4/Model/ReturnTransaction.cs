namespace cs6232_g4.Model
{
    /// <summary>
    /// Object representing the transaction of the storemember returning furniture
    /// </summary>
    /// 
    public class ReturnTransaction
    {
        public int LineItemID { get; set; }
       
        public int ReturnTransactionID { get; set; }

        public DateTime TransactionDate { get; set; }

        public int MemberId { get; set; }

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public int FurnitureID { get; set; }
        
        public string FurnitureName { get; set; }
        
        public int Quantity { get; set; }

        public decimal FineOrRefund { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
