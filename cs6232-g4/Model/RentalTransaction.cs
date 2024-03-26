namespace cs6232_g4.Model
{
    public class RentalTransaction
    {
        public int TransactionID { get; set; }

        public DateTime TransactionDate { get; set; }

        public int MemberId { get; set; }

        public int EmployeeId { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime DueDate { get; set; }
    }
}
