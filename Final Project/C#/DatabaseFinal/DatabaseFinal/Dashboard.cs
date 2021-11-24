using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFinal
{
    public partial class Dashboard : Form
    {
        DataAccess db = new DataAccess();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if(TableComboBox.Text == "")
            {
                MessageBox.Show("Please select a table first!");
            }
            else
            {
                string name = TableComboBox.Text;
                TableComboBox.SelectedIndex = -1;
                SearchForm sf = new SearchForm(name);
                sf.Show();
            }
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = Helper.CnnVal();
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            if(cnn.State.ToString() == "Open")
            {
                ConnectionLabel.ForeColor = Color.LightGreen;
                ConnectionLabel.Text = "Connected";
                ConnectBtn.Enabled = false;
                TableComboBox.Enabled = true;
                SearchBtn.Enabled = true;
                InsertBtn.Enabled = true;
                UpdateBtn.Enabled = true;
                DeleteBtn.Enabled = true;
                CustomBtn.Enabled = true;
            }
            else
            {
                ConnectionLabel.Text = "Failed to connect";
            }
        }

        private void CustomBtn_Click(object sender, EventArgs e)
        {
            CustomQForm cq = new CustomQForm();
            cq.Show();
        }
    }
}
