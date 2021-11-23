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
            string name = TableComboBox.Text;
            //List<Theater> _table = db.GetTableContents<Theater>(name);
            switch (name)
            {
                case "Theater":
                    List<Theater> theater = db.GetTableContents<Theater>(name);
                        DisplayInfoBox.DataSource = theater;
                        DisplayInfoBox.DisplayMember = "FullInfo";
                    break;
                case "Movies":
                    List<Movies> movies = db.GetTableContents<Movies>(name);
                    DisplayInfoBox.DataSource = movies;
                    DisplayInfoBox.DisplayMember = "FullInfo";
                    break;
                case "Tickets":
                    List<Tickets> tickets = db.GetTableContents<Tickets>(name); ;
                    DisplayInfoBox.DataSource = tickets;
                    DisplayInfoBox.DisplayMember = "FullInfo";
                    break;
                case "Staff":
                    List<Staff> staff = db.GetTableContents<Staff>(name);
                    DisplayInfoBox.DataSource = staff;
                    DisplayInfoBox.DisplayMember = "FullInfo";
                    break;
                case "Showing":
                    List<Showing> showing = db.GetTableContents<Showing>(name);
                    DisplayInfoBox.DataSource = showing;
                    DisplayInfoBox.DisplayMember = "FullInfo";
                    break;
            }
            //UpdateBinding();
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
