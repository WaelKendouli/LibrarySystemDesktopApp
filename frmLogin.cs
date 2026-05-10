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
using LibraryDataAccess;
using System.Text.RegularExpressions;

namespace LibrarySystemApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private enum LoginMode { eUser, eAdmin }
        private LoginMode _Mode = LoginMode.eUser;

        private bool InputValidate()
        {
            if (clsInputValidator.CheckInputs(clsInputValidator.IsPatrrenCorrect, txtUsername.Text, txtPassword.Text) == false)
            {
                MessageBox.Show("Usernames must contain @ in the beginning and all inputs must NOT contain white spaces .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }

        private void AdminLogin()
        {
            clsAdminDTO DTO = clsAdmin.CheckAuthentication(txtUsername.Text, txtPassword.Text);
            if (DTO == null)
            {
                MessageBox.Show("Username / Password are not correct please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                clsCurrentUser.CurrentAdminInfo = DTO;
                frmAdminsDashboard frm = new frmAdminsDashboard(this);
                this.Hide();
                frm.ShowDialog();
            }
        }


        private void UserLogin()
        {
            
            

           clsUserDTO  DTO = clsUser.IsUserAuthenticated(txtUsername.Text, txtPassword.Text);
            if (DTO != null)
            {
                clsCurrentUser.CurrentUserInfo = new clsUser(DTO.ID, DTO.FirstName, DTO.SecondName,
                    DTO.ThirdName, DTO.LastName, DTO.Username, DTO.Email, DTO.Password, DTO.PIN, DTO.Phone,
                    DTO.MembershipID, DTO.StatusID);
                clsCurrentUser.CurrentUserInfo.CurrentDTO = DTO;
                if (DTO.StatusID != 2) // check if user is not banned
                {
                    frmUserDashboard frm = new frmUserDashboard(this);
                    this.Hide();
                    frm.ShowDialog();
                    if (this.Visible==false)
                    {
                        this.Show();
                    }
                }
            else
            {
                MessageBox.Show($"account with ID {DTO.ID} is Banned cannot continue any further", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
            else
            {
                MessageBox.Show("Username / Password are not correct please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void Login()
        {
            if (InputValidate()==false)
            {
                return;
            }
            switch (_Mode)
            {
                case LoginMode.eUser:
                    UserLogin();
                    break;
                case LoginMode.eAdmin:
                    AdminLogin();
                    break;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void rbUser_CheckedChanged(object sender, EventArgs e)
        {
            _Mode = LoginMode.eUser;
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            _Mode = LoginMode.eAdmin;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frm = new frmSignUp();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            //btnLogin.ForeColor = Color.Black;
            //btnLogin.BackColor = Color.Yellow;
        }
    }
}
