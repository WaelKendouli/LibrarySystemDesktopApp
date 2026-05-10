using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class clsFinesDataAccess
    {
        public static int AddFine(int borrowingID, int userID, double fineAmount)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddNewFine", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BorrowingID", borrowingID);
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@FineAmount", fineAmount);

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
        public static DataTable GetFineListForUser(int userId)
        {
            DataTable dtFineList = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetFineListForUser", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtFineList.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Consider logging the exception or re-throwing
                        // For now, following the same pattern as your existing function
                        // You might want to add error handling here
                    }
                }
            }
            return dtFineList;
        }
    }
}
