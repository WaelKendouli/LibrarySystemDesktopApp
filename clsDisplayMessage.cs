using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemApp
{
    public static class clsDisplayMessage
    {
        
            public static void ShowMessage(string message, string caption)
            {
                MessageBox.Show(message, caption);
            }

            // Message with OK button and icon
            public static void ShowMessage(string message, string caption, MessageBoxIcon icon)
            {
                MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
            }

            // Message with custom buttons and icon
            public static DialogResult ShowMessage(string message, string caption,
                                                  MessageBoxButtons buttons,
                                                  MessageBoxIcon icon)
            {
                return MessageBox.Show(message, caption, buttons, icon);
            }

            // Message with custom buttons, icon, and default button
            public static DialogResult ShowMessage(string message, string caption,
                                                  MessageBoxButtons buttons,
                                                  MessageBoxIcon icon,
                                                  MessageBoxDefaultButton defaultButton)
            {
                return MessageBox.Show(message, caption, buttons, icon, defaultButton);
            }
        }

    }

