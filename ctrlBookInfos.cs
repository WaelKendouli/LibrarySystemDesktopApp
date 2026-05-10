using LibraryDataAccess;
using LibraryLogicLayer;
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

namespace LibrarySystemApp
{
    public partial class ctrlBookInfos : UserControl
    {
        public ctrlBookInfos()
        {
            InitializeComponent();
        }
     public  CopyBookDTO _CopyDTO = null;
        public BookDTO _BookDTO = null;

        
        private void _LoadImage(string PhotoURL)
        {
            if (string.IsNullOrEmpty(PhotoURL))
            {
                MessageBox.Show($"Photo doesn't exist", "loading photo error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbBookCover.Image = null;
                return;
            }
            if (!File.Exists(PhotoURL))
            {
                MessageBox.Show($"Couldn't load photo \n {PhotoURL} Couldn't be found", "loading photo error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbBookCover.Image = null;
                return;
            }

            try
            {
                pbBookCover.Image = Image.FromFile(PhotoURL);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Couldn't load photo \n {ex.Message}", "Loading photo error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void _FillUserControlInfo(CopyBookDTO DTO)
        {
            if (DTO != null)
            {
                lbTitle.Text = DTO.Title;
                lbID.Text = DTO.BookID.ToString();
                lbEdition.Text = DTO.Edition.ToString();
                lbISBN.Text = DTO.ISBN.ToString();
                lbLanguage.Text = DTO.Language;
                lbPages.Text = DTO.NumberOfPages.ToString();
                lbPrice.Text = DTO.Price.ToString();
                lbDate.Text = DTO.publicationDate.ToShortDateString();
                txtBio.Text = DTO.Bio;
                _LoadImage(DTO.PhotoURL);
            }
            else
            {
                RestControl();
            }
        }

        private void _FillUserControlInfo(BookDTO DTO)
        {
            if (DTO != null)
            {
                lbTitle.Text = DTO.Title;
                lbID.Text = DTO.BookID.ToString();
                lbEdition.Text = DTO.Edition.ToString();
                lbISBN.Text = DTO.ISBN.ToString();
                lbLanguage.Text = DTO.Language;
                lbPages.Text = DTO.NumberOfPages.ToString();
                lbPrice.Text = DTO.Price.ToString();
                lbDate.Text = DTO.publicationDate.ToShortDateString();
                txtBio.Text = DTO.Bio;
                _LoadImage(DTO.PhotoURL);
            }
            else
            {
                RestControl();
            }
        }

        public void LoadInfosByCopyID(int CopyID)
        {
            _CopyDTO = clsCopyBook.FindCopyByID(CopyID);
            _FillUserControlInfo(_CopyDTO);
        }

        public void LoadInfosByBookID(int BookID , string Format)
        {
             _CopyDTO = clsCopyBook.FindFirstAvailableCopyByID(BookID, Format);
            _FillUserControlInfo(_CopyDTO);
        }

        public void LoadInfosByBookID(int BookID)
        {
            _BookDTO = clsBook.FindBookByID(BookID);
            _FillUserControlInfo(_BookDTO);
        }

        public void LoadInfosByBookTitle(string Title)
        {
            _BookDTO = clsBook.FindBookInfoByTitle(Title);
            _FillUserControlInfo(_BookDTO);
        }

        public void LoadCopyInfosByBookTitle(string Title , string Format)
        {
             _CopyDTO = clsCopyBook.FindFirstAvailableCopyByTitle(Title, Format);
            _FillUserControlInfo(_CopyDTO);
        }

        public void RestControl()
        {
            pbBookCover.Image = null;
            lbTitle.Text = "[????]";
            lbID.Text = "[????]";
            lbEdition.Text = "[????]";
            lbISBN.Text = "[????]";
            lbLanguage.Text = "[????]";
            lbPages.Text = "[????]";
            lbPrice.Text = "[????]";
            lbDate.Text = "[????]";
            txtBio.Text = "";
        }

        private void ctrlBookInfos_Load(object sender, EventArgs e)
        {
            txtBio.Enabled = true;
        }
    }
}
