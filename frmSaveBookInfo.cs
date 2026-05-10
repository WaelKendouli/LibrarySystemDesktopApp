using LibraryLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemApp
{
    public partial class frmSaveBookInfo : Form
    {
        public frmSaveBookInfo()
        {
            InitializeComponent();
            _Mode = enMode.eAdd;
        }
        int _BookID = -1;
        public frmSaveBookInfo(int BookID)
        {
            InitializeComponent();
            _Mode = enMode.eUpdate;
            SwitchTitle();
            _BookID = BookID;
            ctrlAddBookInfo1.LoadBookInfosByID(BookID);
        }
        clsBook CurrentBook = null;
        enum enMode { eAdd = 1 , eUpdate = 2 }
        enMode _Mode = enMode.eAdd;

        private void Save(clsBookSelectedEventsArgs e)
        {
            switch (_Mode)
            {
                case enMode.eAdd:
                    CurrentBook = new clsBook(e.Title, e.ISBN, e.publicationDate, e.Language, e.NumberOfPages, e.Price, e.Edition, e.PhotoURL, e.Bio);
                    break;
                case enMode.eUpdate:
                    SwitchTitle();
                    CurrentBook = new clsBook(_BookID, e.Title, e.ISBN, e.publicationDate, e.Language, e.NumberOfPages, e.Price, e.Edition, e.PhotoURL, e.Bio);
                    if (CurrentBook == null)
                    {
                        throw new Exception("Current book object is null");
                    }
                    CurrentBook.FillNewData(e.Title, e.ISBN, e.publicationDate, e.Language, e.NumberOfPages, e.Price, e.Edition, e.PhotoURL, e.Bio);
                    break;
            }

            if (CurrentBook == null)
            {
                throw new Exception("Current book object creation failed");
            }

            if (CurrentBook.Save())
            {
                clsDisplayMessage.ShowMessage("Saved successfully .", "", MessageBoxIcon.Information);
                if (_Mode == enMode.eAdd)
                {
                    frmLinkBookToCategory frm = new frmLinkBookToCategory(CurrentBook.BookID);
                    frm.ShowDialog();
                }
                _Mode = enMode.eUpdate;
            }
            else
            {
                clsDisplayMessage.ShowMessage("Saving failed .", "", MessageBoxIcon.Information);
            }
        }

        private void SwitchTitle()
        {
            if (_Mode==enMode.eAdd)
            {
                lbTitle.Text = "Add New Book";
            }
            else
            {
                lbTitle.Text = "Update Book";
            }
        }
        private void ctrlAddBookInfo1_OnBookInfosSaved(object sender, clsBookSelectedEventsArgs e)
        {
            SwitchTitle();
            Save(e);
        }

        private void frmSaveBookInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
