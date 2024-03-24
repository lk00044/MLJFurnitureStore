using LineItems.Model;

/// <summary>
/// Transaction Class
/// Group 4
/// Programmer: LKeller
/// Date: 08/03/24
/// </summary>
namespace Transactions.Model
{
    public class Transaction
    {
        public int TransactionID { get; set; } 

        public DateTime DateOfTransaction { get; set; }

        public string MemberID { get; set; }

        public string EmployeeID { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime? DateReturned { get; set; }

        public List<LineItem> Items { get; set; }

        public Transaction()
        {
            MemberID = string.Empty;
            EmployeeID = string.Empty;
            TotalAmount = 0;
            DateReturned = DateTime.MinValue;
            Items = new List<LineItem>();

        }

    }
}
