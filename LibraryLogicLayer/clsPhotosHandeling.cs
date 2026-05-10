using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryLogicLayer
{
    public class clsPhotosHandeling
    {
        public static string _SelectPhotoCover(PictureBox pb)
        {
            string _PhotoURI = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Configure the file dialog
                openFileDialog.Title = "Select a Photo";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = false;
                openFileDialog.RestoreDirectory = true;



                // Show the dialog and check if user clicked OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load the selected image
                        _PhotoURI = openFileDialog.FileName;
                        pb.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }

            return _PhotoURI;

        }
    }
}