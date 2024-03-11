/// <summary>
/// Member Data Access Layer
/// Group 4
/// Programmer: LKeller
/// Date: 08/11/24
/// </summary>

using cs6232_g4.DAL;
using Members.Model;
using System.Data.SqlClient;

namespace Members.DAL
{
    public class MemberDAL
    {
        public Member GetMemberByID(int ID)
        {
            Member member = new Member();

            string selectStatement =
                "SELECT member_id, fname,lname, addr1, addr2, city, state, zip, phone, date_of_birth " +
                "FROM StoreMember " + 
                "WHERE member_id = @ID"
            ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@ID", ID));
                   
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            member.MemberID = (int)reader["member_id"];
                            member.FirstName = reader["fname"].ToString();
                            member.LastName = reader["lname"].ToString();
                            member.Address1 = reader["addr1"].ToString();
                            member.Address2 = reader["addr2"].ToString();
                            member.City = reader["city"].ToString();
                            member.State = reader["state"].ToString();
                            member.ZipCode = reader["zip"].ToString();
                            member.Phone = reader["Phone"].ToString();
                            member.Gender = (char)reader["gender"];
                            member.DateOfBirth = (DateTime?) reader["date_of_birth"];
                        }
                    }
                }
            }
            return member;
        }


    }
}
