using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFlex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMsj.Text = "";
            txtSql.Focus();
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            lblMsj.Text = "";
            string ConnString = txtConnString.Text;
            if (DataFlexODBC.TestConnection(ConnString))
            {
                MessageBox.Show("Conexión exitosa");
            }
            else
            {
                MessageBox.Show("Falló la conexión");
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            lblMsj.Text = "";
            txtMaxRowCount.Text = "100";

            string ConnString = txtConnString.Text;
            
            if (!DataFlexODBC.TestConnection(ConnString))            
            {
                MessageBox.Show("Falló la conexión");
                return;
            }

            string sql = txtSql.Text;


            DataTable dt = DataFlexODBC.Select(ConnString, sql);
            gvResult.DataSource = dt;
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            lblMsj.Text = "";
            string ConnString = txtConnString.Text;

            if (!DataFlexODBC.TestConnection(ConnString))
            {
                MessageBox.Show("Falló la conexión");
                return;
            }

            string tableName = cbTabla.Text;

            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Debe seleccionar una tabla de la lista");
            }

            int maxRowCount = 100000000;
            txtMaxRowCount.Text = maxRowCount.ToString();

            if (!string.IsNullOrEmpty(txtMaxRowCount.Text))
            {
                try
                {
                    maxRowCount = int.Parse(txtMaxRowCount.Text);
                }
                catch { }
            }

            DataTable dt = DataFlexODBC.Export(ConnString, tableName, maxRowCount, lblMsj);
            
            StringBuilder sb = new StringBuilder();

            string[] columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName).
                                              ToArray();
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).
                                                ToArray();
                sb.AppendLine(string.Join(",", fields));
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Filter = "CSV|*.csv";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.FileName = tableName + ".csv";
            var res = saveFileDialog.ShowDialog();
            if (res == DialogResult.OK)
                File.WriteAllText(saveFileDialog.FileName, sb.ToString());

            gvResult.DataSource = dt;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
