using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Http.Headers;
namespace LibraryDataAccess
{
    public class clsUsersDataAccess
    {
        public static clsUserDTO CheckUserAuthentication(string username, string password)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_CheckUserAuthentication", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    conx.Open();

                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var SecondNameOrdinality = reader.GetOrdinal("SecondName");
                                string SecondName = reader.IsDBNull(SecondNameOrdinality) ? "" : reader.GetString(SecondNameOrdinality);
                                var ThirdNameOrdinality = reader.GetOrdinal("ThirdName");
                                string ThirdName = reader.IsDBNull(ThirdNameOrdinality) ? "" : reader.GetString(ThirdNameOrdinality);
                                return new clsUserDTO(
                                    reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader.GetString(reader.GetOrdinal("FirstName")),
                                    SecondName,
                                    ThirdName,
                                    reader.GetString(reader.GetOrdinal("LastName")),
                                    reader.GetString(reader.GetOrdinal("Username")),
                                    reader.GetString(reader.GetOrdinal("Email")),
                                    reader.GetString(reader.GetOrdinal("Password")),
                                    reader.GetString(reader.GetOrdinal("PIN")),
                                    reader.GetString(reader.GetOrdinal("Phone")),
                                    reader.GetInt32(reader.GetOrdinal("MembershipID")),
                                    reader.GetInt32(reader.GetOrdinal("StatID"))
                                    );
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        return null;
                    }

                }
                return null;
            }

        }

        public static clsUserDTO GetUserDTO_ByID(int UserID)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetUserByID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", UserID);
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var SecondNameOrdinality = reader.GetOrdinal("SecondName");
                                string SecondName = reader.IsDBNull(SecondNameOrdinality) ? "" : reader.GetString(SecondNameOrdinality);
                                var ThirdNameOrdinality = reader.GetOrdinal("ThirdName");
                                string ThirdName = reader.IsDBNull(ThirdNameOrdinality) ? "" : reader.GetString(ThirdNameOrdinality);
                                return new clsUserDTO(
                                    reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader.GetString(reader.GetOrdinal("FirstName")),
                                    SecondName,
                                    ThirdName,
                                    reader.GetString(reader.GetOrdinal("LastName")),
                                    reader.GetString(reader.GetOrdinal("Username")),
                                    reader.GetString(reader.GetOrdinal("Email")),
                                    reader.GetString(reader.GetOrdinal("Password")),
                                    reader.GetString(reader.GetOrdinal("PIN")),
                                    reader.GetString(reader.GetOrdinal("Phone")),
                                    reader.GetInt32(reader.GetOrdinal("MembershipID")),
                                    reader.GetInt32(reader.GetOrdinal("StatID"))
                                    );
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        return null;
                    }

                }
                return null;
            }
        }


        public static DataTable GetUserBorrowingHistory(int UserID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_UserBorrowingHistory", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return dt;
        }

        public static int AddNewUser(string firstName, string secondName, string thirdName, string lastName,
            string username, string email, string password, string PIN, string phone,
            int membershipID, int statusID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddNewUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", firstName);
                if (string.IsNullOrEmpty(secondName))
                {
                    command.Parameters.AddWithValue("@SecondName", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@SecondName", secondName);
                }


                if (string.IsNullOrEmpty(thirdName))
                {
                    command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@ThirdName", thirdName);
                }
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@PIN", PIN);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@MembershipID", membershipID);
                command.Parameters.AddWithValue("@StatID", statusID);


                var outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                connection.Open();
                command.ExecuteNonQuery();

                return (int)outputIdParam.Value;
            }


        }


        public static bool CheckIfUserExist(string Username)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_CheckIfUsernameExist", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", Username);
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                                return reader.HasRows;
                            else
                                return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }

        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllUsersForAdmins", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return dt;
        }

        public static bool ChangeUserStatus(int UserID, int NewStatusID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_ChangeUserStatus", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@NewStatusID", NewStatusID);

                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
        }

       

        public static bool UpdateUser(int ID, string firstName, string secondName, string thirdName, string lastName,
            string username, string email, string password, string PIN, string phone,
            int membershipID, int statusID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_UpdateUserInfo", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@SecondName", secondName);
                command.Parameters.AddWithValue("@ThirdName", thirdName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@PIN", PIN);
                command.Parameters.AddWithValue("@MembershipID", membershipID);
                command.Parameters.AddWithValue("@StatID", statusID);

                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
        }

        public static bool IsOldPasswordCorrect( int UserID,string OldPassword )
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_IsOldPasswordCorrect", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OldPassword", OldPassword);
                    cmd.Parameters.AddWithValue("@ID", UserID);
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                                return reader.HasRows;
                            else
                                return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }

        }

        public static bool ChangePassword(int ID, string NewPassword)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_ChangePassword", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@NewPassword", NewPassword);
                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
        }

       

    

    }
}
