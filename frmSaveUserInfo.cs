using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibraryLogicLayer;

namespace LibrarySystemApp
{
    public partial class frmSaveUserInfo : Form
    {
        public frmSaveUserInfo()
        {
            InitializeComponent();
            _Mode = enMode.eAdd;
        }
        int _UserID = -1;
        clsUser User = null;
        public frmSaveUserInfo(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.eUpdate;
            _UserID = UserID;
            lbTitle.Text = "Update user";
            User = clsUser.FindUserByID(UserID);
            ctrlFillUserInfo1.FillUsersInfo(User);
        }

        

        enum enMode { eAdd = 1 , eUpdate = 2 }

        enMode _Mode = enMode.eAdd;

        private void ctrlFillUserInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmSaveUserInfo_Load(object sender, EventArgs e)
        {

        }

        private void UpdateUserInfo(UserAddedEventsArgs e)
        {
            if (User != null)
            {
                User.FirstName = e.FirstName;
                User.SecondName = e.SecondName;
                User.ThirdName = e.ThirdName;
                User.LastName = e.LastName;
                User.Email = e.Email;
                User.PIN = e.PIN;
                User.MembershipID = e.MembershipID;
                User.StatusID = e.StatusID;
                User.Username = e.Username;
                User.Phone = e.Phone;
                User.Password = e.Password;
            }
        }


        private void SaveInfos(UserAddedEventsArgs e)
        {
            if (_Mode == enMode.eAdd)
            {
                if (clsUser.CheckIfUserExist(e.Username))
                {
                   clsDisplayMessage.ShowMessage($"{e.Username} already exist try an other one .","",MessageBoxIcon.Error);
                    return;
                }

                if (clsUser.AddNewUser(e.FirstName , e.SecondName , e.ThirdName , e.LastName , e.Username ,
                    e.Email , e.Password , e.PIN , e.Phone , e.MembershipID , e.StatusID)== true)
                {
                    clsDisplayMessage.ShowMessage($"{e.Username} added successfully.", "", MessageBoxIcon.Information);
                }
                else
                {
                    clsDisplayMessage.ShowMessage($"adding failed , something went wrong ", "", MessageBoxIcon.Error);
                }
            }
            else
            {
                if (User!=null)
                {
                    UpdateUserInfo(e);
                    if (User.UpdateUserInfo())
                    {
                        clsDisplayMessage.ShowMessage($"{e.Username} updated successfully.", "", MessageBoxIcon.Information);
                    }
                    else
                    {
                        clsDisplayMessage.ShowMessage($"updating failed , something went wrong ", "", MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ctrlFillUserInfo1_OnUserInfosAdded(object sender, UserAddedEventsArgs e)
        {
            SaveInfos(e);
        }
    }
}
