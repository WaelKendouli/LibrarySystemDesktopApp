using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibraryDataAccess
{
    public class clsReservationsDataAccess
    {
        public static int ReserveBook(DateTime ReservationDate, int CopyID, int UserID, DateTime EndReservationDate)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddReservation", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@CopyID", CopyID);
                command.Parameters.AddWithValue("@ReservationDate", ReservationDate);
                command.Parameters.AddWithValue("@ReturnDate", EndReservationDate);

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

        public static bool UpdateReservation(DateTime reservingDate, int copyBookID, int userID, DateTime endDate)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_UpdateReservation", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ReservingDate", reservingDate);
                command.Parameters.AddWithValue("@CopyBookID", copyBookID);
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@EndDate", endDate);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
        }

        public static DataTable GetUserListOfReservations(int UserID)
        {
            DataTable dtUserReservations = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_ShowUserListOfReservations", conx))
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
                                dtUserReservations.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }


                }

            }
            return dtUserReservations;

        }


        public static bool HandleExpiredReservations()
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_CheckExspiredReservations", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.ExecuteNonQuery();
                return command.ExecuteNonQuery() > 0;

            }
        }


        public static bool CancelReservation(int ReservationID)
        {

            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            {
            using (var command = new SqlCommand("SP_DeleteReservation", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ReservationID", ReservationID);

                    connection.Open();

                    int rowsAffected = (int)command.ExecuteScalar();
                    return (rowsAffected == 1);
                }
                
            }
                
        }

    }
}