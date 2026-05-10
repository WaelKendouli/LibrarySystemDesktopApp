using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LibraryDataAccess
{
    public class clsPenaltiesDataAccess
    {
        public static DataTable GetListOfPenaltiesTypes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select * from PenaltyType", conx))
                {

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

        public static DataTable GetListOfPenaltiesForOneUser(int UserID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetPenaltiesForSpecificUser", conx))
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

        public static decimal GetTotalPenaltyAmountForUser(int userId)
        {
            decimal totalAmount = 0;

            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_GetTotalAmountFromPenaltiesForOneUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add input parameter
                command.Parameters.AddWithValue("@UserID", userId);

                // Add output parameter
                var outputParam = new SqlParameter("@Total", SqlDbType.Money)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Get the output value
                    if (outputParam.Value != DBNull.Value)
                    {
                        totalAmount = Convert.ToDecimal(outputParam.Value);
                    }
                }
                catch (SqlException ex)
                {
                    // Log exception here
                }
            }

            return totalAmount;
        }
    }
}
