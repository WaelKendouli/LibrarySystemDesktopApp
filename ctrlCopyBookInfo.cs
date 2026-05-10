using LibraryDataAccess;
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
    public partial class ctrlCopyBookInfo : UserControl
    {
        public ctrlCopyBookInfo()
        {
            InitializeComponent();
        }

        public CopyBookDTO _CopyDTO = null;
        public void FillUserControl(int CopyID)
        {
            ctrlBookInfos1.LoadInfosByCopyID(CopyID);
            if (ctrlBookInfos1._CopyDTO!=null)
            {
                lbCopyID.Text = ctrlBookInfos1._CopyDTO.CopyID.ToString();
                lbFormat.Text = ctrlBookInfos1._CopyDTO.FormatName.ToString();
                lbStatus.Text = ctrlBookInfos1._CopyDTO.StatusName;
                _CopyDTO = ctrlBookInfos1._CopyDTO;
            }
        }
        private void ctrlCopyBookInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
