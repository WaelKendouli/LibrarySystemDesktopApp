using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LibraryDataAccess
{
    public class clsRequestsDataAccess
    {
       
        public static Dictionary<string, int> GetRequestsTypes()
    {
            Dictionary<string, int> DicRequestTypes = new Dictionary<string, int>();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetRequestTypesList", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!DicRequestTypes.ContainsKey(reader.GetString(reader.GetOrdinal("TypeName"))))
                            {
                                DicRequestTypes.Add(reader.GetString(reader.GetOrdinal("TypeName")), reader.GetInt32(reader.GetOrdinal("RequestTypeID")));
                            }
                        }
                    }
                }
            }
            return DicRequestTypes;
        }
        public static DataTable AdminsListToSendRequest()
        {
            DataTable dtListOfAdmins = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM AdminsViewForRequest", conx))
                {
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtListOfAdmins.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            return dtListOfAdmins;
        }
        public static int AddNewRequest(string content, int requestTypeID, int userID, int adminID)
        {
            int newID = 0;
            try
            {
                using (var connection = new SqlConnection(clsConnection.ConnectionString))
                using (var command = new SqlCommand("SP_AddNewRequest", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@content", content);
                    command.Parameters.AddWithValue("@RequstTypeID", requestTypeID);
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@AdminID", adminID);

                    var outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);

                    connection.Open();
                    command.ExecuteNonQuery();

                    if (outputIdParam.Value != DBNull.Value)
                    {
                        newID = (int)outputIdParam.Value;
                    }

                    return newID;
                }
            }
            catch (SqlException ex)
            {
                return -1;
            }
        }

        public static clsRequestDTO GetRequestDTO_ByID(int RequestID)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetRequestByID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RequestID", RequestID);
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Handle potential NULL values for Content, RequestTypeID, UserID, AdminID
                                var ContentOrdinality = reader.GetOrdinal("content");
                                string Content = reader.IsDBNull(ContentOrdinality) ? "" : reader.GetString(ContentOrdinality);

                                var RequestTypeIDOrdinality = reader.GetOrdinal("RequstTypeID");
                                int RequestTypeID = reader.IsDBNull(RequestTypeIDOrdinality) ? 0 : reader.GetInt32(RequestTypeIDOrdinality);

                                var UserIDOrdinality = reader.GetOrdinal("UserID");
                                int UserID = reader.IsDBNull(UserIDOrdinality) ? 0 : reader.GetInt32(UserIDOrdinality);

                                var AdminIDOrdinality = reader.GetOrdinal("AdminID");
                                int AdminID = reader.IsDBNull(AdminIDOrdinality) ? 0 : reader.GetInt32(AdminIDOrdinality);

                                return new clsRequestDTO(
                                    reader.GetInt32(reader.GetOrdinal("RequestID")),
                                    Content,
                                    RequestTypeID,
                                    UserID,
                                    AdminID
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

        public static DataTable GetListOfRequestsForAdmins(int AdminID)
        {
            DataTable dtRequestsForAdmin = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetListOfRequestsForAdmins", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    cmd.Parameters.AddWithValue("@AdminID", AdminID);
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtRequestsForAdmin.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // You might want to log the exception or handle it
                        // For now, returning empty DataTable
                    }
                }
            }
            return dtRequestsForAdmin;
        }
        public static DataTable GetAdminRepliesForUser(int userID, int adminID)
        {
            DataTable dtAdminReplies = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AdminsRepliesForUsers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@AdminID", adminID);

                    connection.Open();

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtAdminReplies.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Consider logging the exception here
                        // dtAdminReplies remains empty
                    }
                }
            }

            return dtAdminReplies;
        }
        public static clsRequestTypeDTO GetRequestTypeDTO_ByID(int RequestTypeID)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetRequestTypeByID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RequesttypeID", RequestTypeID);
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Handle potential NULL values for TypeName
                                var TypeNameOrdinality = reader.GetOrdinal("TypeName");
                                string TypeName = reader.IsDBNull(TypeNameOrdinality) ? "" : reader.GetString(TypeNameOrdinality);

                                return new clsRequestTypeDTO(
                                    reader.GetInt32(reader.GetOrdinal("RequestTypeID")),
                                    TypeName
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

    }
}
