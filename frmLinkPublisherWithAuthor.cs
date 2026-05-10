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
    public partial class frmLinkPublisher : Form
    {
        int _PublisherID = -1;
        DataTable _dtList;

        public delegate bool DelAssociationFunction(int PublisherID, int SecondPartyID);
        DelAssociationFunction _AssociationFunction;
        public frmLinkPublisher(int PublisherID , DataTable dtList , DelAssociationFunction function)
        {
            InitializeComponent();
            _PublisherID = PublisherID;
            _dtList = dtList;
            _AssociationFunction = function;
        }

        private void AssociateThisPublisher()
        {
            if (_PublisherID==-1||_AssociationFunction==null)
            {
                throw new Exception("Initilazing form is not valid");
            }

            int SecondPartyID;
            string CurrentValue = dgvList.CurrentRow.Cells[0].Value.ToString();
            
            if (int.TryParse(CurrentValue,out int  result))
            {
                SecondPartyID = (int)dgvList.CurrentRow.Cells[0].Value;
            }
            else
            {
                throw new Exception("values are not valid");
            }

            if (_AssociationFunction(_PublisherID , SecondPartyID))
            {
                MessageBox.Show("Associated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Associating failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _InitializeForm()
        {
            if (_dtList == null)
            {
                return;
            }

            clsCustomDataGridViewUserControl.LoadData(_dtList, dgvList, cbSearch, null);
        }
        private void frmLinkPublisherWithAuthor_Load(object sender, EventArgs e)
        {
            _InitializeForm();
            ctrlPublisherInfo1.LoadPublisherInfos(clsPublisher.FindPublisherByID(_PublisherID));
        }

        private void cmsOptions_Opening(object sender, CancelEventArgs e)
        {
        }

        private void associateWithThisPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociateThisPublisher();
        }

        private void tx_TextChanged(object sender, EventArgs e)
        {
            clsCustomDataGridViewUserControl.HandleTextBoxChangingEvent(tx, cbSearch, _dtList);

        }
    }
}
