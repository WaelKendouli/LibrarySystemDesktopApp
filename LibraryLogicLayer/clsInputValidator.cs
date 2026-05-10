using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace LibraryLogicLayer
{
    public class clsInputValidator 
    {
        
        private static bool CheckTextBoxesInputs(string txt)
        {
            return (string.IsNullOrEmpty(txt));
        }

        public delegate bool delMatch(string word, string pattren);
        public static bool IsPhoneInputNotCorrect(string Phone) => Regex.IsMatch(Phone, @"^0[5-7]\d{8}$") == false;

        public static bool IsPatrrenCorrect(string word, string pattren) => Regex.IsMatch(word, pattren);

        public static bool IsColumnNameContainsID(string ColumnName) => Regex.IsMatch(ColumnName, "\\b\\w*ID\\w*\\b");

        public static bool IsColumnNameContainsDate(string ColumnName) => Regex.IsMatch(ColumnName, "\\b\\w*Date\\w*\\b");

        public static bool IsDateValid(string Date) => Regex.IsMatch(Date, @"^\d{1,2}/\d{1,2}/\d{4}$");

        public static bool IsNameNotValid(string name)
        {
            // Pattern: Only letters, spaces, hyphens, and apostrophes, min 2 chars, max 50 chars
            
            return Regex.IsMatch(name, @"^[a-zA-Z\s\-']{2,20}$") == false;
        }

        private static bool IsPinValid(string pin)
        {
            // Pattern: ^\d{3}$ means exactly 3 digits
            string pattern = @"^\d{3}$";
            return Regex.IsMatch(pin, pattern);
        }

        // Check if PIN is NOT correct
        public static bool IsPinNotCorrect(string pin)
        {
            return !IsPinValid(pin);
        }

        private static bool IsUsernameValid(string username)
        {
 
            string pattern = @"^@[a-zA-Z0-9_]{3,20}$";
            return Regex.IsMatch(username, pattern);
        }

        // Check if username is NOT correct
        public static bool IsUsernameNotCorrect(string username)
        {
            return !IsUsernameValid(username);
        }
        private static bool IsEmailValid(string email) => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        public static bool IsEmailNotValid(string email) => IsEmailValid(email) == false;
        public static bool CheckInputs(delMatch CheckingFunction, string username , string Password , string RegexPattren = @"^@\S+$")
        {
            if (CheckTextBoxesInputs(username) || CheckTextBoxesInputs(Password)|| CheckingFunction(username, RegexPattren) == false)
            {
                return false;
            }

            return true;
        }

        public static bool IsTitle_Not_Valid(string Title) => !Regex.IsMatch(Title, @"^[a-zA-Z0-9\s]+$");
        public static bool IsISBN_Not_Valid(string Input) => !Regex.IsMatch(Input, @"^\d{3}-\d{1}-\d{3}-\d{5}-\d{1}$");
        public static bool IsInputNotIntegerValue(string Input) => !int.TryParse(Input, out int result);
        public static bool IsInputNotDoubleValue(string Input) => !int.TryParse(Input, out int result);

        public static bool IsWeakPassword(string Password)
        {
            return !Regex.IsMatch(Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
        }

        public static bool IsValidGatewayCustomerId(string gatewayCustomerId) =>
        !Regex.IsMatch(gatewayCustomerId, @"^[a-zA-Z0-9_-]{5,50}$");

        public static bool IsValidPaymentMethodToken(string paymentMethodToken) =>
            !Regex.IsMatch(paymentMethodToken, @"^[a-zA-Z0-9_-]{10,100}$");

        public static bool IsValidCardType(string cardType) =>
            !Regex.IsMatch(cardType, @"^(Visa|MasterCard|American Express|Pay Pal|Amex|Apple Pay|Discover|Diners Club|JCB|UnionPay)$", RegexOptions.IgnoreCase);

        public static bool IsValidHolderName(string holderName) =>
            !Regex.IsMatch(holderName, @"^[a-zA-Z\s\-\.']{2,100}$");

        public static bool IsValidBillingPostalCode(string billingPostalCode) =>
            !Regex.IsMatch(billingPostalCode, @"^[a-zA-Z0-9\s-]{3,10}$");

        public static bool IsAmountValid(string Amount)
        {
          return  Regex.IsMatch(Amount, @"^(0|[1-9]\d*)(\.\d{1,2})?$");
        }


    }
}
