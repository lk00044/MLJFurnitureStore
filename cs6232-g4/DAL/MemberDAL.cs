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

        /// <summary>
        /// Gets all members with the specified id
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>member list</returns>
        public List <Member> GetMemberByID(int ID)
        {
            List <Member> MemberList = new List <Member>();

            string selectStatement =
                "SELECT member_id, date_of_birth, fname,lname, address1, address2, city, state, zip, phone, gender " +
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
                            Member member = new Member();
                            member.MemberID = (int)reader["member_id"];
                            member.DateOfBirth = (DateTime?)reader["date_of_birth"];
                            member.FirstName = reader["fname"].ToString();
                            member.LastName = reader["lname"].ToString();
                            member.Address1 = reader["address1"].ToString();
                            member.Address2 = reader["address2"].ToString();
                            member.City = reader["city"].ToString();
                            member.State = reader["state"].ToString();
                            member.ZipCode = reader["zip"].ToString();
                            member.Phone = reader["phone"].ToString();
                            member.Gender = Convert.ToChar(reader["gender"]);
                            
                            MemberList.Add(member);
                        }
                    }
                }
            }
            return MemberList;
        }

        /// <summary>
        /// Gets all members with the specified phone
        /// </summary>
        /// <param name="Phone"></param>
        /// <returns> member list </returns>
        public List<Member> GetMemberByPhone(string Phone)
        {
            List<Member> MemberList = new List<Member>();

            string selectStatement =
                "SELECT member_id, date_of_birth, fname,lname, address1, address2, city, state, zip, phone, gender " +
                "FROM StoreMember " +
                "WHERE phone = @Phone"
            ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@Phone", Phone));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member();
                            member.MemberID = (int)reader["member_id"];
                            member.DateOfBirth = (DateTime?)reader["date_of_birth"];
                            member.FirstName = reader["fname"].ToString();
                            member.LastName = reader["lname"].ToString();
                            member.Address1 = reader["address1"].ToString();
                            member.Address2 = reader["address2"].ToString();
                            member.City = reader["city"].ToString();
                            member.State = reader["state"].ToString();
                            member.ZipCode = reader["zip"].ToString();
                            member.Phone = reader["phone"].ToString();
                            member.Gender = Convert.ToChar(reader["gender"]);

                            MemberList.Add(member);
                        }
                    }
                }
            }
            return MemberList;
        }


        /// <summary>
        /// Gets all members with the specified first and last names
        /// </summary>
        /// <param name="FName"></param>
        /// <param name="LName"></param>
        /// <returns></returns>
        public List<Member> GetMemberByName(string FName, string LName)
        {
            List<Member> MemberList = new List<Member>();

            string selectStatement =
                "SELECT member_id, date_of_birth, fname, lname, address1, address2, city, state, zip, phone, gender " +
                "FROM StoreMember " +
                "WHERE lname = @LName and fname = @FName"
            ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@LName", LName));
                    selectCommand.Parameters.Add(new SqlParameter("@FName", FName));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member();
                            member.MemberID = (int)reader["member_id"];
                            member.DateOfBirth = (DateTime?)reader["date_of_birth"];
                            member.FirstName = reader["fname"].ToString();
                            member.LastName = reader["lname"].ToString();
                            member.Address1 = reader["address1"].ToString();
                            member.Address2 = reader["address2"].ToString();
                            member.City = reader["city"].ToString();
                            member.State = reader["state"].ToString();
                            member.ZipCode = reader["zip"].ToString();
                            member.Phone = reader["phone"].ToString();
                            member.Gender = Convert.ToChar(reader["gender"]);

                            MemberList.Add(member);
                        }
                    }
                }
            }
            return MemberList;
        }

        /// <summary>
        /// Register a store member
        /// </summary>
        public void RegisterStoreMember(Member storeMember)
        {
            string command = $"INSERT INTO [dbo].[StoreMember] VALUES (@dob, @fname, @lname, @phone, @address1, @address2, @city, @state, @zip, @gender)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insert_command = new SqlCommand(command, connection))
                {
                    insert_command.Parameters.Add("@dob", System.Data.SqlDbType.NVarChar);
                    insert_command.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar);
                    insert_command.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar);
                    insert_command.Parameters.Add("@phone", System.Data.SqlDbType.NChar);
                    insert_command.Parameters.Add("@address1", System.Data.SqlDbType.NVarChar);
                    insert_command.Parameters.Add("@address2", System.Data.SqlDbType.NVarChar);
                    insert_command.Parameters.Add("@city", System.Data.SqlDbType.NVarChar);
                    insert_command.Parameters.Add("@state", System.Data.SqlDbType.NVarChar);
                    insert_command.Parameters.Add("@zip", System.Data.SqlDbType.NVarChar);
                    insert_command.Parameters.Add("@gender", System.Data.SqlDbType.NChar);

                    insert_command.Parameters["@dob"].Value = storeMember.DateOfBirth;
                    insert_command.Parameters["@fname"].Value = storeMember.FirstName;
                    insert_command.Parameters["@lname"].Value = storeMember.LastName;
                    insert_command.Parameters["@phone"].Value = storeMember.Phone;
                    insert_command.Parameters["@address1"].Value = storeMember.Address1;
                    insert_command.Parameters["@address2"].Value = storeMember.Address2;
                    insert_command.Parameters["@city"].Value = storeMember.City;
                    insert_command.Parameters["@state"].Value = storeMember.State;
                    insert_command.Parameters["@zip"].Value = storeMember.ZipCode;
                    insert_command.Parameters["@gender"].Value = storeMember.Gender;

                    insert_command.ExecuteNonQuery();

                }
            }
        }
    }
}
