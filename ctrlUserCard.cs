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
    public partial class ctrlUserCard : UserControl
    {
        public ctrlUserCard()
        {
            InitializeComponent();
        }



        private void _LoadImage(string PhotoURL)
        {
            if (string.IsNullOrEmpty(PhotoURL))
            {
                MessageBox.Show($"Photo doesn't exist", "loading photo error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbPicture.Image = null;
                return;
            }
            if (! File.Exists(PhotoURL))
            {
                MessageBox.Show($"Couldn't load photo \n {PhotoURL} Couldn't be found", "loading photo error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbPicture.Image = null;
                return;
            }

            try
            {
                pbPicture.Image = Image.FromFile(PhotoURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Couldn't load photo \n {ex.Message}", "Loading photo error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void LoadCardInformations()
        {
            clsUser Current = clsCurrentUser.CurrentUserInfo;
            if (Current == null)
            {
                return;
            }
            clsCardDTO DTO = clsCard.FindCardByUserID(clsCurrentUser.CurrentUserInfo.CurrentDTO.ID);
            if (DTO != null)
            {
                lbCardID.Text = DTO.CardID.ToString();
                lbuserID.Text = DTO.UserID.ToString();
                lbEmail.Text = Current.Email;
                lbEndDate.Text = DTO.ExperiationDate.ToShortDateString();
                lbStartDate.Text = DTO.MembershipDate.ToShortDateString();
                if (DTO.isActive == false)
                {
                    lbActivation.Text = "No Activation";
                }
                else
                {
                    lbActivation.Text = "Activated";
                }
                lbName.Text = $"Welcome {Current.CurrentDTO.FullName}";
                _LoadImage(DTO.PhotoLocation);
            }
        }

        public void LoadCardInformations(clsUser Current)
        {
            if (Current == null)
            {
                return;
            }
            clsCardDTO DTO = clsCard.FindCardByUserID(Current.ID);
            if (DTO != null)
            {
                lbCardID.Text = DTO.CardID.ToString();
                lbuserID.Text = DTO.UserID.ToString();
                lbEmail.Text = Current.Email;
                lbEndDate.Text = DTO.ExperiationDate.ToShortDateString();
                lbStartDate.Text = DTO.MembershipDate.ToShortDateString();
                if (DTO.isActive == false)
                {
                    lbActivation.Text = "No Activation";
                }
                else
                {
                    lbActivation.Text = "Activated";
                }
                lbName.Text = $"Welcome {Current.CurrentDTO.FullName}";
                _LoadImage(DTO.PhotoLocation);
            }
        }

        private void ctrlUserCard_Load(object sender, EventArgs e)
        {

        }

        private void pbPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
