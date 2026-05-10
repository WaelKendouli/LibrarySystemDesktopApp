using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class clsWalletDataAccess
    {
        public static clsWalletDTO FindWalletByID(int UserID)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_FindUserWalletByUserID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new clsWalletDTO(reader.GetInt32(reader.GetOrdinal("WalletID")),
                                    reader.GetDecimal(reader.GetOrdinal("AmountOfMoney")),
                                    reader.GetInt32(reader.GetOrdinal("UserID"))
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

        public static bool UpdateWallet(int UserID, decimal NewBalance)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_UpdateWallet", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@AmountOfMoney", NewBalance);
                connection.Open();
                return command.ExecuteNonQuery()>0;

            }
        }

        public static bool DepositAmount(int UserID, double NewBalance)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_DepositAmount", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@NewAmount", NewBalance);
                connection.Open();
               return  command.ExecuteNonQuery() > 0;
            }
        }
    }
}
