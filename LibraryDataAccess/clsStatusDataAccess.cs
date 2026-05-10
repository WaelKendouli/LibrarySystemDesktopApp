using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibraryDataAccess
{
    public class clsStatusDataAccess
    {
        public static StatusDTO FindStatusByID(int ID)
        {
            
                using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetStatusByID", conx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", ID);

                        conx.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                            return new StatusDTO(
                                reader.GetInt32(reader.GetOrdinal("StatusID")),
                                reader.GetString(reader.GetOrdinal("StatusName"))
                                );
                            }
                        }
                    }
                }
                return null;
            }

        }

    }