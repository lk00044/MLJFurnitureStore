using cs6232_g4.Model;
using Employees.DAL;
using Furnitures.Model;

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
    }
}