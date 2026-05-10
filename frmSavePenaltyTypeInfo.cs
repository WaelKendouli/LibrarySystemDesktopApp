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
    public partial class frmShowPenaltiesTypes : Form
    {
        public frmShowPenaltiesTypes()
        {
            InitializeComponent();
        }
        DataTable dtAllPenalties;
        private void frmShowPenaltiesTypes_Load(object sender, EventArgs e)
        {
            dtAllPenalties = clsPenalty.GetListOfPenaltiesTypes();
            clsCustomDataGridViewUserControl.LoadData(dtAllPenalties, dgvPenalties, cb, null, 250);
        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {
            clsCustomDataGridViewUserControl.HandleTextBoxChangingEvent(txSearch, cb, dtAllPenalties);
        }
    }
}
