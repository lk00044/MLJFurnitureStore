using cs6232_g4.DAL;
using StoreMembers.Model;
using System.Net;

namespace cs6232_g4.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the StoreMemberDAL and the view.
    /// </summary>
    public class StoreMemberController
    {
        private readonly StoreMemberDAL _storeMemberDAL;

        /// <summary>
        /// Create a StoreMemberController object.
        /// </summary>
        public StoreMemberController()
        {
            this._storeMemberDAL = new StoreMemberDAL();
        }

        /// <summary>
        /// Register a store member
        /// </summary>
        public void RegisterStoreMember(StoreMember storeMember)
        {
            this._storeMemberDAL.RegisterStoreMember(storeMember);
        }
    }
}
