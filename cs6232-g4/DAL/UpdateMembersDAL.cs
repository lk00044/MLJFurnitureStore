/// <summary>
/// Member Data Access Layer
/// Group 4
/// </summary>

using cs6232_g4.DAL;
using Members.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;

namespace UpdateMembers.DAL
{
    public class UpdateMembersDAL
    {

        private static Member memberToUpdate;

        /// <summary>
        /// sets the member to be edited
        /// </summary>
        /// <returns></returns>
        public void SetMemberToUpdate(Member member)
        {
            memberToUpdate = member;

        }

        /// <summary>
        /// Returns the member to be edited
        /// </summary>
        /// <returns></returns>
        public Member GetMemberToUpdate()
        {
            return memberToUpdate;
        }


        /// <summary>
        /// Gets all members with the specified id
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>member list</returns>
        public List<Member> GetMemberByID(int ID)
        {
            List<Member> MemberList = new List<Member>();

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
        /// Adds a new member to the database
        /// </summary>
        /// <param name="user"></param>
        public void AddMember(User user)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand insertUserCommand = new SqlCommand("INSERT INTO Users (lastName, firstName, dob, gender, streetNumber, city, state, phone, zipcode) " +
                "VALUES (@lastName, @firstName, @dob, @ssn, @gender, @streetNumber, @city, @state, @phone, @zipcode) " +
                "SELECT scope_identity() as lastUserId ", connection, transaction);
                insertUserCommand.Parameters.AddWithValue("@lastName", );
                insertUserCommand.Parameters.AddWithValue("@firstName", user.FirstName);
                insertUserCommand.Parameters.AddWithValue("@dob", user.DOB);
                insertUserCommand.Parameters.AddWithValue("@gender", user.Gender);
                insertUserCommand.Parameters.AddWithValue("@streetNumber", user.StreetNumber);
                insertUserCommand.Parameters.AddWithValue("@addressTwo", user.AddressTwo);
                insertUserCommand.Parameters.AddWithValue("@city", user.City);
                insertUserCommand.Parameters.AddWithValue("@phone", user.Phone);
                insertUserCommand.Parameters.AddWithValue("@zipcode", user.Zipcode);

            }
        }

        /// <summary>
        /// Deletes a member from the database
        /// </summary>
        /// <param name="userId"></param>
        public void DeleteMember(int userId)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand insertUserCommand = new SqlCommand("DELETE FROM Users " +
                                                              "WHERE userId = @userId", connection, transaction);
                insertUserCommand.Parameters.AddWithValue("@userId", userId);

                try
                {
                    SqlCommand insertMemberCommand = new SqlCommand("DELETE FROM Member List " +
                    "WHERE userId = @userId ", connection, transaction);
                    insertMemberCommand.Parameters.AddWithValue("@userId", userId);
                    insertMemberCommand.ExecuteNonQuery();
                    insertUserCommand.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// Updates a user data in the database relating to the member
        /// </summary>
        /// <param name="user"></param>
        public bool UpdateMember(User user, User oldUser)
        {
            string insertStatement =
                "UPDATE Users SET " +
                "lastName = @lastName, " +
                "firstName = @firstName, " +
                "dob = @dob, " +
                "gender = @gender, " +
                "streetNumber = @streetNumber, " +
                "addressTwo = @addressTwo, " +
                "city = @city, " +
                "state = @state, " +
                "phone = @phone, " +
                "zipcode = @zipcode " +
                "WHERE userId = @oldUserId " +
                "AND lastName = @oldLastName " +
                "AND firstName = @oldFirstName " +
                "AND dob = @oldDob " +
                "AND gender = @oldGender " +
                "AND streetNumber = @oldStreetNumber " +
                "AND addressTwo = @oldAddressTwo " +
                "AND city = @oldCity " +
                "AND state = @oldState " +
                "AND phone = @oldPhone " +
                "AND zipcode = @oldZipcode ";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@firstName", user.LastName);
                insertCommand.Parameters.AddWithValue("@streetNumber", user.StreetNumber);
                insertCommand.Parameters.AddWithValue("@addressTwo", user.AddressTwo);
                insertCommand.Parameters.AddWithValue("@city", user.City);
                insertCommand.Parameters.AddWithValue("@state", user.State);
                insertCommand.Parameters.AddWithValue("@phone", user.Phone);
                insertCommand.Parameters.AddWithValue("@zipcode", user.Zipcode);

                insertCommand.Parameters.AddWithValue("@oldUserId", oldUser.UserId);
                insertCommand.Parameters.AddWithValue("@oldLastName", oldUser.LastName);
                insertCommand.Parameters.AddWithValue("@oldFirstName", oldUser.FirstName);
                insertCommand.Parameters.AddWithValue("@oldDob", oldUser.DOB.ToShortDateString());
                insertCommand.Parameters.AddWithValue("@oldGender", oldUser.Gender);
                insertCommand.Parameters.AddWithValue("@oldStreetNumber", oldUser.StreetNumber);
                insertCommand.Parameters.AddWithValue("@addressTwo", oldUser.AddressTwo);
                insertCommand.Parameters.AddWithValue("@oldCity", oldUser.City);
                insertCommand.Parameters.AddWithValue("@oldState", oldUser.State);
                insertCommand.Parameters.AddWithValue("@oldPhone", oldUser.Phone);
                insertCommand.Parameters.AddWithValue("@oldZipcode", oldUser.Zipcode);

                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal void UpdateMember(Member storeMember)
        {
            throw new NotImplementedException();
        }
    }
}
