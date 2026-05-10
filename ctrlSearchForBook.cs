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
    public partial class ctrlSearchForBook : UserControl
    {
        public ctrlSearchForBook()
        {
            InitializeComponent();
        }

        private void ctrlSearchForBook_Load(object sender, EventArgs e)
        {
            cbSearch.SelectedIndex = 0;
        }

        public event EventHandler<BooksSearchingEventArg> OnBookSearched;

        protected virtual void OnSearchFinished(BooksSearchingEventArg e)
        {
            OnBookSearched?.Invoke(this, e);
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
                        ctrlBookInfos1.LoadInfosByBookID(BookID);
                        if (ctrlBookInfos1._BookDTO == null)
                        {
                            MessageBox.Show("not found");
                            return;
                        }
                      OnSearchFinished( new BooksSearchingEventArg(ctrlBookInfos1._BookDTO.BookID));
                    }
                    break;
                case "Title":
                    // add validation here 
                    ctrlBookInfos1.LoadInfosByBookTitle(txtSearchInput.Text.Trim());
                    if (ctrlBookInfos1._BookDTO == null)
                    {
                        MessageBox.Show("not found");
                        return;
                    }
                    OnSearchFinished(new BooksSearchingEventArg(ctrlBookInfos1._BookDTO.BookID));
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
