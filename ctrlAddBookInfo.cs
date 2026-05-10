using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryLogicLayer;
using LibraryDataAccess;
namespace LibrarySystemApp
{
    public partial class ctrlAddBookInfo : UserControl
    {
        public ctrlAddBookInfo()
        {
            InitializeComponent();
        }

        delegate bool delValidationFunction(string Input);

        public event EventHandler<clsBookSelectedEventsArgs> OnBookInfosSaved;

        protected virtual void OnBookSaved(clsBookSelectedEventsArgs e)
        {
            OnBookInfosSaved?.Invoke(this, e);
        }



        private void _SelectPhotoCover()
        {
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
                        pbCover.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                }

            }
        }

        string _PhotoURI = "";
        private bool _IsInputNotValid(TextBox tx, string FailureMessage , delValidationFunction ValidationFunc , CancelEventArgs e)
        {
            if (ValidationFunc(tx.Text))
            {
                e.Cancel = true;
                //  MessageBox.Show(FailureMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epErrorCheck.SetError(tx,FailureMessage);
                tx.Focus();
                return true;
            }
            else
            {
                e.Cancel = false;
                epErrorCheck.SetError(tx, "");
                return false;
            }
        }

        public void LoadBookInfosByID(int ID)
        {
            BookDTO DTO = clsBook.FindBookByID(ID);
            _LoadBookInfos(DTO);
        }

        private void _LoadBookInfos(BookDTO Book)
        {
            if (Book!=null)
            {
                txtTitle.Text = Book.Title;
                txtDescription.Text = Book.Bio;
                txtISBN.Text = Book.ISBN;
                dtpPublicationDate.Value = Book.publicationDate;
                txtNumberOfPages.Text = Book.NumberOfPages.ToString();
                txtPrice.Text = Book.Price.ToString();
                if (File.Exists(Book.PhotoURL))
                {
                    pbCover.Image = Image.FromFile(Book.PhotoURL);
                }
                else
                {
                    MessageBox.Show($"photo doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void ctrlAddBookInfo_Load(object sender, EventArgs e)
        {
            txtLanguage.Text = "English";
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (_IsInputNotValid(txtTitle, "Title shouldn't be empty", string.IsNullOrEmpty, e))
            {
                return;
            }
            _IsInputNotValid(txtTitle, "Title shouldn't contains special characters", clsInputValidator.IsTitle_Not_Valid , e);
        }

        private void pbCover_Click(object sender, EventArgs e)
        {
            _SelectPhotoCover();
        }

        private void txtISBN_Validating(object sender, CancelEventArgs e)
        {
            if (_IsInputNotValid(txtISBN, "ISBN shouldn't be empty", string.IsNullOrEmpty, e))
            {
                return;
            }
            _IsInputNotValid(txtISBN, "ISBN should be in this format 3 digits - 1 digit - 3 digits - 5 digits - 1 digit", clsInputValidator.IsISBN_Not_Valid, e);
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (_IsInputNotValid(txtPrice, "Price shouldn't be empty", string.IsNullOrEmpty, e))
            {
                return;
            }
            _IsInputNotValid(txtPrice, "Price isn't valid", clsInputValidator.IsInputNotDoubleValue, e);
        }

        private void txtNumberOfPages_Validating(object sender, CancelEventArgs e)
        {
            if (_IsInputNotValid(txtNumberOfPages, "Number of pages shouldn't be empty", string.IsNullOrEmpty, e))
            {
                return;
            }
            _IsInputNotValid(txtNumberOfPages, "Number of pages isn't valid", clsInputValidator.IsInputNotIntegerValue, e);
        }

        private void txtEdition_Validating(object sender, CancelEventArgs e)
        {
            if (_IsInputNotValid(txtEdition, "Edition shouldn't be empty", string.IsNullOrEmpty, e))
            {
                return;
            }
            _IsInputNotValid(txtEdition, "Edition isn't valid", clsInputValidator.IsInputNotIntegerValue, e);
        }

        private void btnSetPhoto_Click(object sender, EventArgs e)
        {
            _SelectPhotoCover();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == false)
            {
                return;
            }
            OnBookSaved(new clsBookSelectedEventsArgs(txtTitle.Text, txtISBN.Text, dtpPublicationDate.Value,
               txtLanguage.Text, Convert.ToInt32(txtNumberOfPages.Text), Convert.ToDouble(txtPrice.Text),
                Convert.ToInt32(txtEdition.Text), _PhotoURI, txtDescription.Text));

        }

        private void txtLanguage_Validating(object sender, CancelEventArgs e)
        {
            if (_IsInputNotValid(txtLanguage, "this field shouldn't be empty", string.IsNullOrEmpty, e))
            {
                return;
            }
            _IsInputNotValid(txtLanguage, "this field isn't valid", clsInputValidator.IsNameNotValid, e);
        }
    }
}
