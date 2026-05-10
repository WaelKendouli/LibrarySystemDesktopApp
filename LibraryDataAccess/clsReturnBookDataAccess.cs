using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class clsReturnBookDataAccess
    {
        public static int AddBookReturning(int CopyBookID, int userID, bool isDamaged, bool isLate, int adminID, DateTime userReturningDate)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddBookToReturnings", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookCopyID", CopyBookID);
                command.Parameters.AddWithValue("@UserID", userID);
                if (isDamaged == false)
                {
                    command.Parameters.AddWithValue("@IsDamaged", 0);
                }
                else
                {
                    command.Parameters.AddWithValue("@IsDamaged", 1);
                }
                if (isLate == false)
                {
                    command.Parameters.AddWithValue("@IsLate", 0);
                }
                else
                {
                    command.Parameters.AddWithValue("@IsLate", 1);
                }

                command.Parameters.AddWithValue("@AdminID", adminID);
                command.Parameters.AddWithValue("@UserReturningDate", userReturningDate);

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
        public static DataTable GetReturnedAllCopies()
        {
            DataTable dtAllBooks = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select * from ReturningView", conx))
                {
                 
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dtAllBooks.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }


                }

            }
            return dtAllBooks;
        }

    }
}
