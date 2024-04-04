namespace cs6232_g4.Model
{
    /// <summary>
    /// Object representing the transaction of the storemember renting furniture
    /// </summary>
    /// 
    public class RentalTransaction
    {
        public int TransactionID { get; set; }

        public DateTime TransactionDate { get; set; }

        public int MemberId { get; set; }

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public int LineItemId { get; set; }

        public DateTime DueDate { get; set; }

        public string FurnitureName { get; set; }

        public int LineItemQty { get; set; }

        public decimal LineItemSubTotal { get; set; }

        public decimal TotalAmount { get; set; }

        

       
    }
}
