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
        private MemberDAL MemberSource;

        public MemberController()
        {
            MemberSource = new MemberDAL();
        }

        public List <Member> GetMemberByID(int ID)
        {
            return this.MemberSource.GetMemberByID(ID);
        }

    } 
}
