using LibraryDataAccess;
using LibraryLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemApp
{
    public partial class ctrlSearchBookCopy : UserControl
    {
        public ctrlSearchBookCopy()
        {
            InitializeComponent();
        }
        public event EventHandler<BooksSearchingEventArg> OnBookFound;

        public void OnSearchFinished(int CopyBookID , int BookID)
        {
            OnSearchFinished(new BooksSearchingEventArg(CopyBookID , BookID));
        }

        protected virtual void OnSearchFinished(BooksSearchingEventArg e)
        {
            OnBookFound?.Invoke(this, e);
        }

        private void ctrlSearchBook_Load(object sender, EventArgs e)
        {
            cbSearch.SelectedIndex = 0;
            cbFormat.SelectedIndex = 0;
        }


        public void CustomSearch(int BookID)
        {
            cbSearch.SelectedIndex = 0;
            cbFormat.SelectedIndex = 0;
            txtSearchInput.Text = BookID.ToString();
            ctrlBookInfos1.LoadInfosByBookID(BookID, cbFormat.SelectedItem.ToString());
            if (ctrlBookInfos1._CopyDTO == null)
            {
                MessageBox.Show("not found");
                return;
            }
            OnSearchFinished(ctrlBookInfos1._CopyDTO.CopyID , ctrlBookInfos1._CopyDTO.BookID);
        }


        private void Search()
        {
            switch (cbSearch.SelectedItem.ToString())
            {
                case "ID":
                    if (int.TryParse(txtSearchInput.Text, out int result) == false)
                    {
                        MessageBox.Show("Invalid input for ID search");
                        return;
                    }
                    else
                    {
                        int BookID = Convert.ToInt32(txtSearchInput.Text);
                        ctrlBookInfos1.LoadInfosByBookID(BookID, cbFormat.SelectedItem.ToString());
                        if (ctrlBookInfos1._CopyDTO == null)
                        {
                            MessageBox.Show("not found");
                            return;
                        }
                        OnSearchFinished(ctrlBookInfos1._CopyDTO.CopyID , ctrlBookInfos1._CopyDTO.BookID);
                    }
                    break;
                case "Title":
                    // add validation here 
                    ctrlBookInfos1.LoadCopyInfosByBookTitle(txtSearchInput.Text.Trim(), cbFormat.SelectedItem.ToString());
                    if (ctrlBookInfos1._CopyDTO == null)
                    {
                        MessageBox.Show("not found");
                        return;
                    }
                    OnSearchFinished(ctrlBookInfos1._CopyDTO.CopyID, ctrlBookInfos1._CopyDTO.BookID);
                    break;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
               
        }

        private void Reset()
        {
            txtSearchInput.Clear();
            ctrlBookInfos1.RestControl();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ctrlBookInfos1_Load(object sender, EventArgs e)
        {

        }
    }
}
