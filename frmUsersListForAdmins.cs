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
    public partial class frmUsersListForAdmins : Form
    {
        public frmUsersListForAdmins()
        {
            InitializeComponent();
        }
        enum enStatus { Active = 1 , Banned = 2 , Suspended = 3 , Premium = 4 , Disactive =5 }
        private void frmUsersListForAdmins_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsUser.GetUsersListForAdmins());
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmSaveUserInfo frm = new frmSaveUserInfo();
            frm.ShowDialog();
            ctrlBookListing1.LoadData(clsUser.GetUsersListForAdmins());

        }

        private void updateUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveUserInfo frm = new frmSaveUserInfo(ctrlBookListing1.GetTheFirstValueOfRow());
            frm.ShowDialog();
            ctrlBookListing1.LoadData(clsUser.GetUsersListForAdmins());
        }

        private void ChangeUserStatus(string message , enStatus NewStatus)
        {
            if (MessageBox.Show("Are you sure to perform this action on this user ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (clsUser.ChangeUserStatus(ctrlBookListing1.GetTheFirstValueOfRow() , (int)NewStatus))
                {
                    clsDisplayMessage.ShowMessage(message, "", MessageBoxIcon.Information);
                    ctrlBookListing1.LoadData(clsUser.GetUsersListForAdmins());
                }
                else
                {
                    clsDisplayMessage.ShowMessage("Operation failed", "", MessageBoxIcon.Error);
                }
            }
        }
        private void banUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserStatus("Banned successfully", enStatus.Banned);
        }

        private void releaseThisUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserStatus("Released successfully", enStatus.Active);
        }

        private void suspendThisUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserStatus("Suspended successfully", enStatus.Suspended);
        }

        private void addToPremiumSubscribtionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserStatus("Added to premium successfully", enStatus.Premium);
        }

        private void disactivateThisUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserStatus("Disactivated successfully", enStatus.Disactive);
        }

        private void manageRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfBorrowingForOnUser frm = new frmListOfBorrowingForOnUser(ctrlBookListing1.GetTheFirstValueOfRow());
            frm.ShowDialog();
        }

        private void showPenaltiesForThisUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfPenaltiesForOneUser frm = new frmListOfPenaltiesForOneUser(ctrlBookListing1.GetTheFirstValueOfRow());
            frm.ShowDialog();
        }
    }
}
