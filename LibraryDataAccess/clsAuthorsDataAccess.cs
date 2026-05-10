using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LibraryDataAccess
{
    public class clsAuthorsDataAccess
    {

        public static DataTable GetAuthorsTable()
        {
            DataTable dtAllAuthors = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAuthorsData", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dtAllAuthors.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            return dtAllAuthors;

        }

        public static clsAuthorDTO GetAuthorDTO_ByID(int AuthorID)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAuthorByID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AuthorID", AuthorID);
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
                                var PhotoOrdinality = reader.GetOrdinal("PhotoLocation");
                                string PhotoPath = reader.IsDBNull(PhotoOrdinality) ? "" : reader.GetString(PhotoOrdinality);
                                return new clsAuthorDTO(
                                    reader.GetInt32(reader.GetOrdinal("AuthorID")),
                                    reader.GetString(reader.GetOrdinal("FirstName")),
                                    SecondName,
                                    ThirdName,
                                    reader.GetString(reader.GetOrdinal("LastName")),
                                    PhotoPath,
                                    reader.GetString(reader.GetOrdinal("Bio"))
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

        public static DataTable GetAuthorWorkByID(int AuthorID)
        {
            DataTable dtAllAuthors = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAuthourWorkByID", conx))
                {
                    cmd.Parameters.AddWithValue("@AuthorID", AuthorID);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dtAllAuthors.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            return dtAllAuthors;

        }

        public static DataTable GetAuthorsWork()
        {
            DataTable dtAllAuthors = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAuthorsWorksList", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dtAllAuthors.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            return dtAllAuthors;

        }


        public static int AddWork(int AuthorID , int BookID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddWorkToAuthor", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AuthorID", AuthorID);
                command.Parameters.AddWithValue("@BookID", BookID);
                

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

        public static bool UpdateAuthor(int AuthorID,string firstName, string secondName, string thirdName, string lastName, string photoLocation, string bio)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_UpdateAuthor", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AuthorID", AuthorID);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@PhotoLocation", photoLocation);
                command.Parameters.AddWithValue("@Bio", bio);
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


                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
        }

        public static int AddAuthor(string firstName, string secondName, string thirdName, string lastName, string photoLocation, string bio)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddNewAuthor", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@PhotoLocation", photoLocation);
                command.Parameters.AddWithValue("@Bio", bio);

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
    }
}
