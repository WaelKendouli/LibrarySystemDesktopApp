using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LibraryDataAccess
{
    public class clsCardDataAccess
    {

        public static clsCardDTO FindCardDTOByID(int UserID)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetUserCardByUserID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {

                            if (reader.Read())
                            {
                                var PhotoOrdinality = reader.GetOrdinal("PhotoLocation");
                                string PhotoLocation = reader.IsDBNull(PhotoOrdinality) ? "" : reader.GetString(PhotoOrdinality);
                                bool isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));

                                return new clsCardDTO(
                                    reader.GetInt32(reader.GetOrdinal("CardID")),
                                    reader.GetDateTime(reader.GetOrdinal("MembershipDate")),
                                    reader.GetDateTime(reader.GetOrdinal("ExperiationDate")),
                                    reader.GetInt32(reader.GetOrdinal("UserID")),
                                    PhotoLocation,
                                    isActive
                                    );
                            }
                        }
                        catch (Exception e)
                        {
                            return null;
                        }

                    }

                }
                return null;

            }


        }

        public static DataTable GetCardsList()
        {
            DataTable dtAllCards = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM UsersCardsView", conx))
                {
                    
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dtAllCards.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            return dtAllCards;

        }

        public static bool UpdateCardInfos(int UserID , DateTime ExprDate , DateTime MembershipDate , string PhotoURI , bool IsActive)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_UpdateCardInfos", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@ExpDate", ExprDate);
                command.Parameters.AddWithValue("@MemDate", MembershipDate);
                command.Parameters.AddWithValue("@Photo", PhotoURI);

                if (IsActive == true)
                {
                    command.Parameters.AddWithValue("@IsActive", 1);
                }
                else
                {
                    command.Parameters.AddWithValue("@IsActive", 0);

                }
                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
        }

        public static clsCardDTO FindCardByUserID(int UserID)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetUserCardByUserID", conx))
                {
                    conx.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            if (reader.Read())
                            {
                                var PhotoOrdinality = reader.GetOrdinal("PhotoLocation");
                                string PhotoLocation = reader.IsDBNull(PhotoOrdinality) ? "" : reader.GetString(PhotoOrdinality);
                                bool isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));

                                return new clsCardDTO(
                                    reader.GetInt32(reader.GetOrdinal("CardID")),
                                    reader.GetDateTime(reader.GetOrdinal("MembershipDate")),
                                    reader.GetDateTime(reader.GetOrdinal("ExperiationDate")),
                                    reader.GetInt32(reader.GetOrdinal("UserID")),
                                    PhotoLocation,
                                    isActive
                                    );
                            }
                        }
                        catch (Exception e)
                        {
                            return null;
                        }

                    }

                }
                return null;

            }

        }
    }
}
