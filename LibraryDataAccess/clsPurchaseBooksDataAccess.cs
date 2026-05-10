using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LibraryDataAccess
{
    public class clsPurchaseBooksDataAccess
    {
        public static int PurchaseBook(int BookCopyID, int UserID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_BuyBook", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
                command.Parameters.AddWithValue("@PurchaseDate", DateTime.Now);

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

        public static DataTable GetHistoryOfPurchaseOfSepcificUser(int UserID)
        {
            DataTable dtPurchaseHistory = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetPurchaseHistoryForUsers", conx))
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
                                dtPurchaseHistory.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            return dtPurchaseHistory;
        }

    }
}
