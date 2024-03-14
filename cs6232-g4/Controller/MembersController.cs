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
    public class MembersController
    {
        private MembersDAL _membersDAL;

        public MembersController()
        {
            _membersDAL = new MembersDAL();
        }

        public List<Member> GetMemberByID(int ID)
        {
            return this._membersDAL.GetMemberByID(ID);
        }

        public List<Member> GetMemberByPhone(string Phone)
        {
            return this._membersDAL.GetMemberByPhone(Phone);
        }

        public List<Member> GetMemberByName(string FName, string LName)
        {
            return this._membersDAL.GetMemberByName(FName, LName);
        }

    }
}
