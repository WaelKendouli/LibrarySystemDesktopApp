
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibraryDataAccess
{
    public class clsMembershipDataAccess
    {
        public static MembershipDTO FindMembershipByID(int ID)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetMembersipInfoByID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);

                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new MembershipDTO(
                                reader.GetInt32(reader.GetOrdinal("MembershipID")),
                                reader.GetString(reader.GetOrdinal("MembershipType")) ,
                                reader.GetInt32(reader.GetOrdinal("MembershipDays"))
                                );
                        }
                    }
                }
            }
            return null;
        }
    }

    
}
