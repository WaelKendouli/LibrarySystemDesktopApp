using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryLogicLayer
{
    public class clsCustomDataGridViewUserControl
    {
      static  List<string> _ListNumericalColumns = new List<string>();
     
        public static void LoadData(DataTable dt,DataGridView dgv, ComboBox cb ,List<string> ListNumericalColumns = null,int width=100)
        {
            
            dgv.DataSource = dt;
            _ListNumericalColumns = ListNumericalColumns;
            string Option = "";
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    dgv.Columns[i].Width = width;
                    dgv.Columns[i].HeaderText = clsStringTransformation.SplitCamelCase(dt.Columns[i].ColumnName);
                    Option = clsStringTransformation.SplitCamelCase(dt.Columns[i].ColumnName);
                    if (cb.Items.Contains(Option) == false)
                    {
                        cb.Items.Add(Option);
                    }
                }
                cb.SelectedIndex = 0;
            }
        }

        public static void HandleTextBoxChangingEvent(TextBox tx , ComboBox cb ,DataTable dtList)
        {


            if (string.IsNullOrEmpty(tx.Text))
            {
                dtList.DefaultView.RowFilter = "";
                return;
            }

            string SelectedItem = cb.SelectedItem.ToString();



            if (clsInputValidator.IsColumnNameContainsID(SelectedItem))
            {
                if (int.TryParse(tx.Text.Trim(), out int result))
                {
                    dtList.DefaultView.RowFilter = string.Format($"[{clsStringTransformation.JoinToCamelCase(cb.SelectedItem.ToString())}] = '{tx.Text.Trim()}'");
                    return;
                }
            }

            if (_ListNumericalColumns != null)
            {
                if (_ListNumericalColumns.Contains(clsStringTransformation.JoinToCamelCase(SelectedItem)) && _ListNumericalColumns.Count > 0)
                {
                    if (int.TryParse(tx.Text.Trim(), out int result))
                    {
                        dtList.DefaultView.RowFilter = string.Format($"[{clsStringTransformation.JoinToCamelCase(cb.SelectedItem.ToString())}] = '{tx.Text.Trim()}'");
                        return;
                    }
                }
            }


            if (clsInputValidator.IsColumnNameContainsDate(SelectedItem))
            {
                if (clsInputValidator.IsDateValid(tx.Text.Trim()) == false)
                {
                    return;
                }
                dtList.DefaultView.RowFilter = string.Format($"[{clsStringTransformation.JoinToCamelCase(cb.SelectedItem.ToString())}] = '{Convert.ToDateTime(tx.Text.Trim())}'");
                return;
            }
            dtList.DefaultView.RowFilter = string.Format($"[{clsStringTransformation.JoinToCamelCase(cb.SelectedItem.ToString())}] LIKE '{tx.Text.Trim()}%'");
        }
    }
}
