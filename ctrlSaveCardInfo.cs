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
    
    public partial class ctrlSaveCardInfo : UserControl
    {
        public ctrlSaveCardInfo()
        {
            InitializeComponent();
        }
        string _PhotoURI = "";
        bool IsActive = false;
        int UserID = -1;
        public event EventHandler<clsCardEventsArgs> OnCardInfosSaved;

        protected virtual void OnCardNewInfosSavedSave(clsCardEventsArgs e)
        {
            OnCardInfosSaved?.Invoke(this, e);
        }
        public void LoadCard(clsCardDTO DTO)
        {
            if (DTO!=null)
            {
                dtpMembershipDate.Text = DTO.MembershipDate.ToString();
                dtpExiperationDate.Text = DTO.ExperiationDate.ToString();
                if (DTO.isActive)
                {
                    chkActive.Checked = true;
                }
                else
                {
                    chkActive.Checked = false;
                }
                if (File.Exists(DTO.PhotoLocation))
                {
                    pbPhoto.Image = Image.FromFile( DTO.PhotoLocation);
                }
                UserID = DTO.UserID;
            }
        }
        private void ctrlSaveCardInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
         _PhotoURI =  clsPhotosHandeling._SelectPhotoCover(pbPhoto);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnCardNewInfosSavedSave(new clsCardEventsArgs(dtpMembershipDate.Value, dtpExiperationDate.Value, UserID, _PhotoURI, IsActive));
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                IsActive = true;
            }
            else
            {
                IsActive = false;
            }
        }
    }
}
