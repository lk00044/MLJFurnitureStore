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
        private MembersDAL MemberSource;

        public MembersController()
        {
            MemberSource = new MembersDAL();
        }

        public List<Member> GetMemberByID(int ID)
        {
            return this.MemberSource.GetMemberByID(ID);
        }

        public List<Member> GetMemberByPhone(string Phone)
        {
            return this.MemberSource.GetMemberByPhone(Phone);
        }

        public List<Member> GetMemberByName(string FName, string LName)
        {
            return this.MemberSource.GetMemberByName(FName, LName);
        }

    }
}
