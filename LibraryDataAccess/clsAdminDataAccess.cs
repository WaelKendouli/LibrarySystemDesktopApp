using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
namespace LibraryDataAccess
{
    public class clsAdminDataAccess
    {
        public static clsAdminDTO CheckAdminAuthentication(string username, string password)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_CheckAdminAuthentication", conx))
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
                                return new clsAdminDTO(reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader.GetString(reader.GetOrdinal("username")),
                                    reader.GetString(reader.GetOrdinal("Password")),
                                    reader.GetString(reader.GetOrdinal("FirstName")),
                                    SecondName,
                                    ThirdName,
                                    reader.GetString(reader.GetOrdinal("LastName")));


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

        public static DataTable GetHistoryOfBorrowingsForAdmins()
        {
            DataTable dtBorrowingHistory = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetListOfBorrowings", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtBorrowingHistory.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            return dtBorrowingHistory;
        }

        public static DataTable GetHistoryOfReservationsForAdmins()
        {
            DataTable dtBorrowingHistory = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetListOfReservations", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtBorrowingHistory.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            return dtBorrowingHistory;
        }

        public static DataTable GetHistoryOfPurchasesForAdmins()
        {
            DataTable dtBorrowingHistory = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetPurchaseHistory", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtBorrowingHistory.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            return dtBorrowingHistory;
        }

        


        public static DataTable GetHistoryOfBorrowingsOfSepcificUser(int UserID)
        {
            DataTable dtBorrowingHistoryForUser = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_BorowwingHistoryForUser", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtBorrowingHistoryForUser.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            return dtBorrowingHistoryForUser;
        }

    }
}
