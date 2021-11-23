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
        List<Theater> _theaters = new List<Theater>();
        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            DisplayInfoBox.DataSource = _theaters;
            DisplayInfoBox.DisplayMember = "FullInfo";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            _theaters = db.GetAllTheaters();
            UpdateBinding();
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
            }
            else
            {
                ConnectionLabel.Text = "Failed to connect";
            }
        }
    }
}
