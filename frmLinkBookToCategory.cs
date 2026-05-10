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
    public partial class frmLinkBookToCategory : Form
    {
        int _BookID = -1;
        public frmLinkBookToCategory(int BookID , bool IsLinkedAlready = false)
        {
            InitializeComponent();
            _BookID = BookID;
            BookLinkedAtLeastOneTime = IsLinkedAlready;
        }

        Dictionary<string, int> dicCategories = new Dictionary<string, int>();
        bool BookLinkedAtLeastOneTime = false;
        private void _LoadCategories()
        {
            dicCategories = clsBook.GetCategories();
            foreach (var item in dicCategories)
            {
                cbCategory.Items.Add(item.Key);
            }
            if (cbCategory.Items.Count>0)
            {
                cbCategory.SelectedIndex = 0;
            }
        }
        private void frmLinkBookToCategory_Load(object sender, EventArgs e)
        {
            _LoadCategories();
            cbCategory.DropDownHeight = 100;
            
        }

        private void _AddBookToCategory()
        {
            if (CheckIfBookIsAlreadyLinkedToThisCategory())
            {
                return;
            }
            if (clsBook.AddBookToCategory(_BookID, dicCategories[cbCategory.SelectedItem.ToString()]))
            {
                BookLinkedAtLeastOneTime = true;
                MessageBox.Show($"this book was added to {cbCategory.SelectedItem.ToString()}");
            }
            else
            {
                MessageBox.Show($"adding this book to {cbCategory.SelectedItem.ToString()} failed","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        bool CheckIfBookIsAlreadyLinkedToThisCategory()
        {
            int selectedCategoryID = dicCategories[cbCategory.SelectedItem.ToString()];
            if (clsBook.IsThisBookLinkedAlreadyToThisCategory(_BookID, selectedCategoryID))
            {
                MessageBox.Show($"this book is already in {cbCategory.SelectedText}","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private void btnAddBookToCategory_Click(object sender, EventArgs e)
        {
            _AddBookToCategory();
        }

        private void frmLinkBookToCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (BookLinkedAtLeastOneTime)
            //{
            //    return;
            //}
            //if (clsBook.IsThisBookCategorized(_BookID)==false) // something is wrong here
            //{
            //    MessageBox.Show("you must link this book to at least one category before closing this form","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    e.Cancel = true;
            //    return;
            //}
        }
    }
}
