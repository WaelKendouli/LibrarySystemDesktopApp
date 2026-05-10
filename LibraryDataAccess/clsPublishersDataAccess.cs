using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LibraryDataAccess
{
    public class clsPublishersDataAccess
    {
        public static DataTable GetPublishersList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Publishers", conx))
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
        public static bool UpdatePublisher(int id, string name, string websiteUrl, string email, string phoneNumber,
                                          string city, string country,  string photoPath , int IsActive = 1)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_UpdatePublisher", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add all parameters
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Website_URL", websiteUrl);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@Country", country);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@PhotoPath", photoPath ?? (object)DBNull.Value);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public static int AddNewPublisher(string name, string websiteUrl, string email, string phoneNumber,
                                   string city, string country, string photoPath)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddNewPublisher", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add input parameters
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Website_URL", websiteUrl);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@Country", country);
                command.Parameters.AddWithValue("@IsActive", 1);
                command.Parameters.AddWithValue("@PhotoPath", photoPath ?? (object)DBNull.Value);

                // Add output parameter
                var outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                connection.Open();
                command.ExecuteNonQuery();

                // Return the new ID
                return (int)outputIdParam.Value;
            }
        }

        public static clsPublisherDTO FindPublisherByID(int PublisherID)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_FindPublisherByID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PublisherID", PublisherID);

                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var PhotoOrdinal = reader.GetOrdinal("PhotoPath");
                            string PhotoPath = reader.IsDBNull(PhotoOrdinal) ? "" : reader.GetString(PhotoOrdinal);

                            return new clsPublisherDTO(
                                reader.GetInt32(reader.GetOrdinal("ID")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("Website_URL")),
                                reader.GetString(reader.GetOrdinal("Email")),
                                reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                reader.GetString(reader.GetOrdinal("city")),
                                reader.GetString(reader.GetOrdinal("Country")),
                                reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                PhotoPath
                            );
                        }
                    }
                }
            }
            return null;
        }

        public static int AssociatePublisherWithAuthor(int PublisherID , int AuthorID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AssociatePublisherWithAuthor", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add input parameters
                command.Parameters.AddWithValue("@PublisherID", PublisherID);
                command.Parameters.AddWithValue("@AuthorID", AuthorID);
               
                // Add output parameter
                var outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                connection.Open();
                command.ExecuteNonQuery();

                // Return the new ID
                return (int)outputIdParam.Value;
            }
        }


        public static int AssociatePublisherWithBook(int PublisherID,int BookID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_LinkPublisherToABook", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add input parameters
                command.Parameters.AddWithValue("@PublisherID", PublisherID);
                command.Parameters.AddWithValue("@BookID", BookID);

                // Add output parameter
                var outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return 0;
                }
                    
                

                return (int)outputIdParam.Value;
            }
        }

    }
}
