using LibraryLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemApp
{
    public partial class ctrlPublisherInfo : UserControl
    {
        public ctrlPublisherInfo()
        {
            InitializeComponent();
        }
        string Url = "";
        public void LoadPublisherInfos(clsPublisher publisher)
        {
            if (publisher!=null)
            {
                lbID.Text = publisher.PublisherID.ToString();
                lbEmail.Text = publisher.Email;
                lbName.Text = publisher.Name;
                lbPhone.Text = publisher.PhoneNumber;
                lbWebsite.Text = publisher.WebsiteURL;
                Url = publisher.WebsiteURL;
                lbCountry.Text = publisher.Country;
                lbCity.Text = publisher.City;
                if (File.Exists(publisher.PhotoPath))
                {
                    pictureBox1.Image = Image.FromFile(publisher.PhotoPath);
                }
            }
        }

        private void ctrlPublisherInfo_Load(object sender, EventArgs e)
        {

        }

        private void OpenBrowser()
        {
            if (string.IsNullOrEmpty(Url))
            {
                MessageBox.Show($"this url {Url} is not valid", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                System.Diagnostics.Process.Start(Url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lbWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenBrowser();
        }
    }
}
