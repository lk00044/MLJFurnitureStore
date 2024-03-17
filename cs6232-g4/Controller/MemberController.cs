/// <summary>
/// Handles the interaction between the view and the Member Data Access Layer     
/// Programmer: LKeller
/// Date: 11 Mrach 2024
/// </summary>
/// 
using Members.Model;
using Members.DAL;

namespace Members.Controller
{
    public class MemberController
    {
        private readonly MemberDAL _memberDAL;

        public MemberController()
        {
            _memberDAL = new MemberDAL();
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
        public void RegisterStoreMember(Member storeMember)
        {
            this._memberDAL.RegisterStoreMember(storeMember);
        }

        /// <summary>
        /// Update a store member
        /// </summary>
        public void UpdateStoreMember(Member storeMember)
        {
            this._memberDAL.UpdateStoreMember(storeMember);
        }
    }
}
