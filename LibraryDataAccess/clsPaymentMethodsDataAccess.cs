using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class clsPaymentMethodsDataAccess
    {

        public static bool IsPaymentMethodAttributeExist(int UserID , string Input , string Arg , string StoredProcuredName)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProcuredName, connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue(Arg, Input);
                    try
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        isFound = reader.HasRows;
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                    return isFound;
                }
            }
        }

        public static int AddNewPaymentMethod(string gatewayCustomerId, string paymentMethodToken,
    string cardType, string holderName, string billingPostalCode, DateTime createdAt)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddNewPaymentMethod", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters with null checks for string parameters
                if (string.IsNullOrEmpty(gatewayCustomerId))
                {
                    command.Parameters.AddWithValue("@gateway_customer_id", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@gateway_customer_id", gatewayCustomerId);
                }

                if (string.IsNullOrEmpty(paymentMethodToken))
                {
                    command.Parameters.AddWithValue("@payment_method_token", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@payment_method_token", paymentMethodToken);
                }

                if (string.IsNullOrEmpty(cardType))
                {
                    command.Parameters.AddWithValue("@card_type", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@card_type", cardType);
                }

                if (string.IsNullOrEmpty(holderName))
                {
                    command.Parameters.AddWithValue("@holder_name", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@holder_name", holderName);
                }

                if (string.IsNullOrEmpty(billingPostalCode))
                {
                    command.Parameters.AddWithValue("@billing_postal_code", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@billing_postal_code", billingPostalCode);
                }

                // Add DateTime parameter (no null check needed as DateTime is non-nullable)
                command.Parameters.AddWithValue("@created_at", createdAt);

                // Add output parameter for the new ID
                var outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                connection.Open();
                command.ExecuteNonQuery();

                // Return the new payment method ID
                return (int)outputIdParam.Value;
            }
        }


    }
}
