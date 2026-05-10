using LibraryDataAccess;
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
    public partial class frmReturnBookAdm : Form
    {
        int _CopyID = -1;
        int _UserID = -1;

        bool IsDamagedClicked = false;
        bool IsLateClicked = false;
        bool IsDamaged = false;
        bool IsLate = false;
        public frmReturnBookAdm(int CopyBookID , int UserID)
        {
            InitializeComponent();
            _CopyID = CopyBookID;
            _UserID = UserID;
        }
        CopyBookDTO CopyDTO = new CopyBookDTO();
        private void frmReturnBookAdm_Load(object sender, EventArgs e)
        {
            ctrlCopyBookInfo1.FillUserControl(_CopyID);
            
            if (ctrlCopyBookInfo1._CopyDTO!= null)
            {
                CopyDTO = ctrlCopyBookInfo1._CopyDTO;
            }
        }

        private void ReturnThisBook()
        {
            clsReturn Return = new clsReturn(_CopyID, _UserID, IsDamaged, IsLate, clsCurrentUser.CurrentAdminInfo.ID, dtpReturningDate.Value);
            if (Return.AddBookReturning())
            {
                MessageBox.Show("Book Returned successfully","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Book Returning failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnThisBook();
        }

        private void chkDameged_Click(object sender, EventArgs e)
        {

        }

        private void chkLate_Click(object sender, EventArgs e)
        {

        }

        private void chkDameged_CheckedChanged(object sender, EventArgs e)
        {
            if (IsDamagedClicked == true)
            {
                IsDamagedClicked = false;
                IsDamaged = false;
                return;
            }
            IsDamaged = true;
            IsDamagedClicked = true;
        }

        private void chkLate_CheckedChanged(object sender, EventArgs e)
        {
            if (IsLateClicked == true)
            {
                IsLateClicked = false;
                IsLate = false;
                return;
            }
            IsLate = true;
            IsLateClicked = true;
        }
    }
}
