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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void ctrlFillUserInfo1_OnUserInfosAdded(object sender, UserAddedEventsArgs e)
        {
            if (clsUser.AddNewUser(e.FirstName , e.SecondName , e.ThirdName , e.LastName , e.Username , e.Email , e.Password , e.PIN , e.Phone , e.MembershipID , e.StatusID))
            {
                MessageBox.Show($"{e.Username} added successfully");
                this.Close();
            }
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
