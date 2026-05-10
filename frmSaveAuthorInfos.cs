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
    public partial class frmSaveAuthorInfos : Form
    {
        public frmSaveAuthorInfos()
        {
            InitializeComponent();
        }

        public frmSaveAuthorInfos(int AuthorID)
        {
            InitializeComponent();
            _Mode = enMode.eUpdate;
            Author = clsAuthor.GetAuthorByID(AuthorID);
            ctrlFillAuthorsInfo1.FillInfos(Author);
            lbTitle.Text = "Update Author";
        }

        clsAuthor Author = null;
        enum enMode { eAdd, eUpdate }
        enMode _Mode = enMode.eAdd;
        private void _Add(clsAuthorsEventArgs e)
        {
            Author = new clsAuthor(e.FirstName, e.SecondName, e.ThirdName, e.LastName, e.PhotoLocation, e.Bio);
            if (Author.AddNewAuthor())
            {
                MessageBox.Show("Added Successfully", "", MessageBoxButtons.OK);
                _Mode = enMode.eUpdate;
                lbTitle.Text = "Update Auhtor";
            }
            else
            {
                MessageBox.Show("Adding Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _Update(clsAuthorsEventArgs e)
        {
            if (Author!=null&&_Mode==enMode.eUpdate)
            {
                Author.FirstName = e.FirstName;
                Author.SecondName = e.SecondName;
                Author.ThirdName = e.ThirdName;
                Author.LastName = e.LastName;
                Author.PhotoLocation = e.PhotoLocation;
                Author.Bio = e.Bio;
                if (Author.UpdateAuthor())
                {
                    MessageBox.Show("Updated Successfully", "", MessageBoxButtons.OK);
                    
                }
                else
                {
                    MessageBox.Show("Updated Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Save(clsAuthorsEventArgs e)
        {
            switch (_Mode)
            {
                case enMode.eAdd:
                    _Add(e);
                    break;
                case enMode.eUpdate:
                    _Update(e);
                    break;
            }
        }
        private void ctrlFillAuthorsInfo1_OnAuthorInfosSaved(object sender, clsAuthorsEventArgs e)
        {
            Save(e);
        }

        private void frmSaveAuthorInfos_Load(object sender, EventArgs e)
        {
          
        }

    }
}
