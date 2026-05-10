using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryLogicLayer
{
    public class clsErrorProviderVerfication
    {
        public  delegate bool delValidationFunction(string input);
        public delegate bool delCheckExistence(int ID, string Input);
        public static bool _ValidateByErrorProvider(ErrorProvider ep ,TextBox tx, CancelEventArgs e,
           delValidationFunction ValidationFunction, string ErrorMessage = "")
        {

            if (ValidationFunction(tx.Text.Trim()))
            {
                // Cancel the event and set the error
                e.Cancel = true;
                ep.SetError(tx, ErrorMessage);

                // Optional: Select the textbox with error
                tx.Select(0, tx.Text.Length);
                return false;

            }
            else
            {
                // Clear the error
                ep.SetError(tx, "");
                e.Cancel = false;
                return true;
            }
           
        }
        public static bool _ExistenceValidationByErrorProvider(ErrorProvider ep, TextBox tx, CancelEventArgs e,
          delCheckExistence ExistenceFunction,int ID,string ErrorMessage = "",bool ExistenceCondition = false)
        {

            if (ExistenceFunction(ID,tx.Text.Trim())== ExistenceCondition)
            {
                // Cancel the event and set the error
                e.Cancel = true;
                ep.SetError(tx, ErrorMessage);

                // Optional: Select the textbox with error
                tx.Select(0, tx.Text.Length);
                return true;

            }
            else
            {
                // Clear the error
                ep.SetError(tx, "");
                e.Cancel = false;
                return false;
            }

        }
    }
}
