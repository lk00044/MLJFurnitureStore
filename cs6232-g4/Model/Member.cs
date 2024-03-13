/// <summary>
/// Employees Class
/// Group 4
/// Programmer: LKeller
/// Date: 08/03/24
/// </summary>
namespace Members.Model
{
    public class Member
    {

        public int MemberID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Phone { get; set; }

        public char Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }

}
