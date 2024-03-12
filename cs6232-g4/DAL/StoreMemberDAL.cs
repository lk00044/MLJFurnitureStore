using StoreMembers.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs6232_g4.DAL
{
    /// <summary>
    /// This the DAL class that deals with cs6232_g4 database StoreMember table. 
    /// </summary>
    public class StoreMemberDAL
    {
        /// <summary>
        /// Register a store member
        /// </summary>
        public void RegisterStoreMember(StoreMember storeMember)
        {
            string command = $"INSERT INTO [dbo].[StoreMember] VALUES (@dob, @fname, @lname, @phone, @address1, @address2, @city, @state, @zip, @gender)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insert_command = new SqlCommand (command, connection))
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
