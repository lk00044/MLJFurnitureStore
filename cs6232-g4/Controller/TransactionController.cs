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
        /// Create a rental transaction
        /// </summary>
        /// <return>
        /// created transaction id
        /// </return>
        public int CreateRentalTransaction(RentalTransaction transaction)
        {
            return this._transactionDAL.CreateRentalTransaction(transaction);
        }

        /// <summary>
        /// Create rental line item
        /// </summary>
        /// <param name="lineItem"/>
        public void CreateRentalLineItem(RentalLineItem lineItem)
        {
            this._transactionDAL.CreateRentalLineItem(lineItem);
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

        internal List<ReturnLineItem> GetMemberReturns(int memberID)
        {
            return this._transactionDAL.GetMemberReturns(memberID);
        }
    }
}