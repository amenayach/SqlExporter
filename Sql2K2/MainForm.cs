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
using Sql2K2.ConnectionDialog;
using Sql2K2.ObjectModel;

namespace Sql2K2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            tbConnectionString.Text = SqlConnectionDialog.Connect();

            ValidateConnection();
        }

        private void ValidateConnection()
        {

            if (tbConnectionString.Text.NotEmpty())
            {

                if (tbConnectionString.Text.NotEmpty())
                {
                    cmbTables.Items.Clear();
                    SqlManager.ExecuteQueryNoCon<string>(@"select name from sys.tables order by name", tbConnectionString.Text)
                        .ForEach(m => cmbTables.Items.Add(m));

                    cmbTables.Focus();
                }

            }

        }

        private void tbConnectionString_TextChanged(object sender, EventArgs e)
        {
            ValidateConnection();
        }

        private void cmbTables_Leave(object sender, EventArgs e)
        {
            if (tbConnectionString.Text.NotEmpty() && cmbTables.Text.NotEmpty())
            {
                chColumns.Items.Clear();
                SqlManager.ExecuteQueryNoCon<string>(@"select name from sys.columns where object_name(object_id) = '" + cmbTables.Text + @"' order by name", tbConnectionString.Text)
                    .ForEach(m => chColumns.Items.Add(m));
            }
        }

        private void btnGenerateContent_Click(object sender, EventArgs e)
        {
            if ((chColumns.CheckedItems.Count > 0 && tbOutput.Text.NotEmpty()) || tbCustomeQuery.Text.NotEmpty())
            {
                var data = GetData();

                if (data != null && data.Rows.Count > 0)
                {

                    var template = tbOutput.Text;
                    var stringBuilder = new StringBuilder();

                    foreach (DataRow row in data.Rows)
                    {
                        stringBuilder.Append(
                            string.Format(
                                template.Replace(@"\n", "\n") + "\n",
                                args: data.Columns.Cast<DataColumn>().Select(column => row[column].ToSql()).ToArray()));
                    }

                    var filename = Path.Combine(Application.StartupPath, "content" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt");
                    File.WriteAllText(filename, stringBuilder.ToString());
                    Process.Start(filename);

                }
            }
        }

        private DataTable GetData()
        {

            if (tbCustomeQuery.Text.IsEmpty())
            {

                var checkedCols = GetCheckedColumns();

                var checkedColumns =
                    checkedCols.Select(m => "[" + m.ToString() + "]").Aggregate((m1, m2) => m1 + "," + m2);

                var data = SqlManager.ExecuteQuery(@"select " + checkedColumns + " from " + cmbTables.Text,
                    tbConnectionString.Text);

                return data;

            }
            else
            {

                return SqlManager.ExecuteQuery(tbCustomeQuery.Text, tbConnectionString.Text);

            }

        }

        private List<string> GetCheckedColumns()
        {
            return chColumns.Items.Cast<object>().Where((t, i) => chColumns.GetItemChecked(i)).Select(t => t.ToString()).ToList();
        }

        private void tbCustomeQuery_TextChanged(object sender, EventArgs e)
        {
            chColumns.Enabled = tbCustomeQuery.Text.IsEmpty();
            cmbTables.Enabled = tbCustomeQuery.Text.IsEmpty();
        }
    }
}
