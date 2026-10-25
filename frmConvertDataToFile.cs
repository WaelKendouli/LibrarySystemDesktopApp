using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryLogicLayer.Interfaces;
using LibraryLogicLayer.Converters;
using LibraryLogicLayer;
using System.IO;

namespace LibrarySystemApp
{
    public partial class frmConvertDataToFile : Form
    {
        DataTable _dt = new DataTable();
        public frmConvertDataToFile(DataTable dt)
        {
            InitializeComponent();
            this._dt = dt;
        }



        public IF_Convertible SelectedConvertionType()
        {
            switch (comboBox1.Text)
            {
                case "PDF":
                    return new clsPDF_Converter();
                case "XML":
                    return new clsXML_Converter();
                case "JSON":
                    return new clsJSON_Converter();
            }
            return new clsPDF_Converter(); // convert to pdf by default
        }


        string FileName = "Test.pdf";
        string Full_Path = "D:\\OS 2 Courses";
        private string _SelectFolderPath()
        {
            string FolderPath = "";
            using (FolderBrowserDialog diag = new FolderBrowserDialog())
            {
                diag.Description = "Select a folder";
                diag.ShowNewFolderButton = true;

                if (diag.ShowDialog() == DialogResult.OK)
                {
                    FolderPath = diag.SelectedPath;
                }
                return FolderPath;
            }
        }

        private async Task<bool> Convert(IProgress<int> prog)
        {
            prog?.Report(10);
            var result = await clsBackgroundWorker.Converter(SelectedConvertionType(), _dt, Full_Path, "Table");
            prog?.Report(100);
            return result;
        }

        private async void ConvertToFile()
        {
            Progress<int> prog = new Progress<int>(value =>
            {
                pbProgressBar.Value = value;
            }
            );

            try
            {
                var result = await Convert(prog);
                if (result == true)
                {
                    MessageBox.Show("file was created successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("file was creation failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"file was creation failed {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmConvertDataToFile_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            txtPath.Text = this.Full_Path;
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            this.Full_Path = Path.Combine(_SelectFolderPath() , this.FileName);
            txtPath.Text = this.Full_Path;
        }

        private void btnStartConvert_Click(object sender, EventArgs e)
        {
            ConvertToFile();
        }

        private void txtFilename_TextChanged(object sender, EventArgs e)
        {
            FileName = txtFilename.Text;
        }
    }
}
