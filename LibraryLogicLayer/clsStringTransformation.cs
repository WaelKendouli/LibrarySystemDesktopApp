using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public  class clsStringTransformation
    {
        public static string SplitCamelCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            // Insert a space before each capital letter (except the first character)
            string pattern = @"(?<=[a-z])(?=[A-Z])";
            return Regex.Replace(input, pattern, " ");
        }

        public static string JoinToCamelCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            // Remove all whitespace
            return Regex.Replace(input, @"\s+", "");
        }
    }
}
