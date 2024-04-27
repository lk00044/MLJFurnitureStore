using cs6232_g4.Model;
using Employees.DAL;

namespace Members.Controller
{
    public class TransactionController
    {
        private readonly TransactionDAL _transactionDAL;

        public TransactionController()
        {
            _transactionDAL = new TransactionDAL();
        }

        /// <summary>
        /// get rental transaction time by ID.
        /// </summary>
        /// <param name="rentalTransactionID">the transaction id.</param>
        /// <returns>rental transaction date</returns>
        public DateTime GetRentalTransactionDateByID(int rentalTransactionID)
        {
            return this._transactionDAL.GetRentalTransactionDateByID(rentalTransactionID);
        }

        /// <summary>
        /// Create a rental transaction
        /// </summary>
        /// <return>
        /// created transaction id
        /// </return>
        public int CreateRentalTransaction(RentalTransaction transaction, List<RentalLineItem> lineItems)
        {
            return this._transactionDAL.CreateRentalTransaction(transaction,lineItems);
        }

        /// <summary>
        /// Gets rental line items per transaction
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>rental line items list</returns>
        public List<RentalLineItem> GetRentalLineItems(int rentalTransactionID)
        {
            return this._transactionDAL.GetRentalLineItems(rentalTransactionID);
        }

        /// <summary>
        /// Gets the member transactions.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>list of rental transactino for the member</returns>
        public List<RentalTransaction> GetMemberTransactions(int memberID)
        {
            return this._transactionDAL.GetMemberTransactions(memberID);
        }

        /// <summary>
        /// Verifies the member transactionavailable.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>bool - true of there is a rental transaction for the member id</returns>
        public bool VerifyMemberTransactionavailable(int memberID)
        {
            return this._transactionDAL.VerifyMemberTransactionavailable(memberID);
        }

        public List<double> CreateReturnTransaction(List<RentalLineItem> rentalLineItems)
        {
            return this._transactionDAL.CreateReturnTransaction(rentalLineItems);
        }

        /// <summary>
        /// Gets the member return transactions.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>list of return transactions for the member</returns>
        public List<ReturnTransaction> GetMemberReturns(int memberID)
        {
            return this._transactionDAL.GetMemberReturns(memberID);
        }
    }
}