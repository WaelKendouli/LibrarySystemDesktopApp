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
    public partial class frmSavePublisherInfo : Form
    {
        clsPublisher _Publisher = new clsPublisher();
        int _PublisherID = -1;
        public frmSavePublisherInfo()
        {
            InitializeComponent();
        }
        public frmSavePublisherInfo(int PublisherID)
        {
            InitializeComponent();
            _PublisherID = PublisherID;
            _Mode = enMode.eUpdate;
            ctrlPublisherInfosSaved1.FillPublisherInfos(PublisherID);
            HandleTitle();
        }
        enum enMode {eAdd , eUpdate }
        enMode _Mode = enMode.eAdd;

        private void FillInfos(clsOnPublisherSavedEventsArgs e)
        {
            _Publisher.Name = e.Name;
            _Publisher.Country = e.Country;
            _Publisher.WebsiteURL = e.WebsiteURL;
            _Publisher.PhotoPath = e.PhotoPath;
            _Publisher.City = e.City;
            _Publisher.Email = e.Email;
            _Publisher.IsActive = true;
        }
        void HandleTitle()
        {
            switch (_Mode)
            {
                case enMode.eAdd:
                    lbTitle.Text = "Add new publisher";
                    break;
                case enMode.eUpdate:
                    lbTitle.Text = "Update publisher";
                    break;
            }
        }
        private bool Save(clsOnPublisherSavedEventsArgs e)
        {
            
            FillInfos(e);
            return _Publisher.Save();
        }

        private void SaveInfos(clsOnPublisherSavedEventsArgs e)
        {
            if (_Mode == enMode.eAdd)
            {
                if (Save(e))
                {
                    MessageBox.Show("Added successfully", "", MessageBoxButtons.OK);
                    _Mode = enMode.eUpdate;
                    HandleTitle();
                }
                else
                {
                    MessageBox.Show("Adding failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                if (Save(e))
                {
                    MessageBox.Show("updated successfully", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("updating failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ctrlPublisherInfosSaved1_OnPublisherSaved(object sender, clsOnPublisherSavedEventsArgs e)
        {
            SaveInfos(e);
        }

        private void frmSavePublisherInfo_Load(object sender, EventArgs e)
        {
            HandleTitle();
        }
    }
}
