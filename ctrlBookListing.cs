using LibraryLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemApp
{
    public partial class ctrlBookListing : UserControl
    {
        public ctrlBookListing()
        {
            InitializeComponent();
        }
        List<string> _ListNumericalColumns = null;
        DataTable dtList;
        private void ctrlBookListing_Load(object sender, EventArgs e)
        {
            cbSearch.Items.Clear();
        }

        public event EventHandler<SelectionChangedEventsArgs> OnRowSelected;

        public void OnRowSelectedFunc(int IDRowValue)
        {
            OnSearchFinished(new SelectionChangedEventsArgs(IDRowValue));
        }

        protected virtual void OnSearchFinished(SelectionChangedEventsArgs e)
        {
            OnRowSelected?.Invoke(this, e);
        }
        public void LoadData(DataTable dt , List<string>ListNumericalColumns = null  ,int Width = 175)
        {
            dtList = dt;
            dgvList.DataSource = dtList;
            _ListNumericalColumns = ListNumericalColumns;
            string Option = "";
            if (dt.Rows.Count>0)
            {
                for (int i = 0; i < dgvList.ColumnCount; i++)
                {
                    dgvList.Columns[i].Width = Width;
                    dgvList.Columns[i].HeaderText = clsStringTransformation.SplitCamelCase(dt.Columns[i].ColumnName);
                    Option = clsStringTransformation.SplitCamelCase(dt.Columns[i].ColumnName);
                    if (cbSearch.Items.Contains(Option)==false)
                    {
                        cbSearch.Items.Add(Option);
                    }
                }
                cbSearch.SelectedIndex = 0;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           


            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                dtList.DefaultView.RowFilter = "";
                return;
            }

            string SelectedItem = cbSearch.SelectedItem.ToString();



            if (clsInputValidator.IsColumnNameContainsID(SelectedItem))
            {
                if (int.TryParse(txtSearch.Text.Trim() ,out int result))
                {
                    dtList.DefaultView.RowFilter = string.Format($"[{ clsStringTransformation.JoinToCamelCase(cbSearch.SelectedItem.ToString())}] = '{txtSearch.Text.Trim()}'");
                    return;
                }
            }

            if (_ListNumericalColumns != null)
            {
             if (_ListNumericalColumns.Contains(clsStringTransformation.JoinToCamelCase(SelectedItem)) && _ListNumericalColumns.Count > 0)
            {
                if (int.TryParse(txtSearch.Text.Trim(), out int result))
                {
                    dtList.DefaultView.RowFilter = string.Format($"[{clsStringTransformation.JoinToCamelCase(cbSearch.SelectedItem.ToString())}] = '{txtSearch.Text.Trim()}'");
                    return;
                }
                }   
            }
            

            if (clsInputValidator.IsColumnNameContainsDate(SelectedItem))
            {
                if (clsInputValidator.IsDateValid(txtSearch.Text.Trim()) == false)
                {
                    return;
                }
                dtList.DefaultView.RowFilter = string.Format($"[{clsStringTransformation.JoinToCamelCase(cbSearch.SelectedItem.ToString())}] = '{Convert.ToDateTime(txtSearch.Text.Trim())}'");
                return;
            }
            dtList.DefaultView.RowFilter = string.Format($"[{clsStringTransformation.JoinToCamelCase(cbSearch.SelectedItem.ToString())}] LIKE '{txtSearch.Text.Trim()}%'");
        }
        private void _TriggerRowChangingEvent()
        {
            try
            {
                // Multiple safety checks
                if (dgvList == null || dgvList.CurrentCell == null || dgvList.CurrentRow == null)
                    return;

                // Check if we're on a valid data row (not header, not new row)
                if (dgvList.CurrentRow.Index < 0 || dgvList.CurrentRow.IsNewRow)
                    return;

                // Check if the cell exists and has value
                var cell = dgvList.CurrentRow.Cells[0];
                if (cell == null || cell.Value == null)
                    return;

                // Column validation
                if (dtList.Columns.Count > 0 &&
                    !clsInputValidator.IsColumnNameContainsID(dtList.Columns[0].ColumnName))
                {
                    return;
                }

                // Parse and raise event
                if (int.TryParse(cell.Value.ToString(), out int result))
                {
                    OnRowSelectedFunc(result);
                }
            }
            catch (Exception ex)
            {
                // Log the exception but don't crash

            }
        }
        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvList_CurrentCellChanged(object sender, EventArgs e)
        {
            _TriggerRowChangingEvent();
        }


        public int GetTheFirstValueOfRow()
        {
            if (int.TryParse(dgvList.CurrentRow.Cells[0].Value.ToString(), out int result))
            {
                return (int)dgvList.CurrentRow.Cells[0].Value;
            }
            throw new Exception("the value isn't integer");
        }

        public int GetCustomValueOfRow(int index)
        {
            if (index > dtList.Columns.Count -1)
            {
                throw new Exception("this index is not valid");
            }

            if (int.TryParse(dgvList.CurrentRow.Cells[index].Value.ToString(), out int result))
            {
                return (int)dgvList.CurrentRow.Cells[index].Value;
            }
            throw new Exception("the value isn't integer");
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            frmConvertDataToFile frm = new frmConvertDataToFile(dtList);
            frm.ShowDialog();
        }
    }
}
