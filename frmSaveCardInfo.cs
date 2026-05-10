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
    public partial class frmSaveCardInfo : Form
    {
        int _UserID = -1;
        public frmSaveCardInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmSaveCardInfo_Load(object sender, EventArgs e)
        {
            ctrlSaveCardInfo1.LoadCard(clsCard.FindCardByUserID(_UserID));
        }


        private void ctrlSaveCardInfo1_OnCardInfosSaved(object sender, clsCardEventsArgs e)
        {
            if (clsCard.UpdateCardInfos(_UserID, e.ExperiationDate, e.MembershipDate, e.PhotoLocation, e.isActive))
            {
                MessageBox.Show("Updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Updating failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
