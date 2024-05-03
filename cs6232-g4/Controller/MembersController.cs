/// <summary>
/// Handles the interaction between the view and the Member Data Access Layer     
/// Programmer: LKeller
/// Date: 11 March 2024
/// </summary>
/// 
using Members.Model;
using Members.DAL;

namespace Members.Controller
{
    /// <summary>
    /// Handle interactin for the Members database
    /// </summary>
    public class MembersController
    {
        private readonly MembersDAL _memberDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="MembersController"/> class.
        /// </summary>
        public MembersController()
        {
            _memberDAL = new MembersDAL();
        }

        /// <summary>
        /// search a store member by ID
        /// </summary>
        public List<Member> GetMemberByID(int ID)
        {
            return this._memberDAL.GetMemberByID(ID);
        }

        /// <summary>
        /// search store member by phone
        /// </summary>
        public List<Member> GetMemberByPhone(string Phone)
        {
            return this._memberDAL.GetMemberByPhone(Phone);
        }

        /// <summary>
        /// search a store member by name
        /// </summary>
        public List<Member> GetMemberByName(string FName, string LName)
        {
            return this._memberDAL.GetMemberByName(FName, LName);
        }

        /// <summary>
        /// Register a store member
        /// </summary>
        public int RegisterStoreMember(Member storeMember)
        {
            return this._memberDAL.RegisterStoreMember(storeMember);
        }

        /// <summary>
        /// Update a store member
        /// </summary>
        public int UpdateStoreMember(Member storeMember)
        {
           return this._memberDAL.UpdateStoreMember(storeMember);
        }
    }
}
