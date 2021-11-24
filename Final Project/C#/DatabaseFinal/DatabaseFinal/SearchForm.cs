using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFinal
{
    public partial class SearchForm : Form
    {
        string _type = "";
        DataAccess db = new DataAccess();
        List<string> _names = new List<string>();

        public SearchForm(string type)
        {
            InitializeComponent();
            this.Text = type + " Search Form";
            _type = type;
            SetTableInfo();
        }
        
        public void SetTableInfo()
        {
            switch (_type)
            {
                case "Theater":          
                    _names = new Theater().GetPropertyNames();
                    PropertyMenu.DataSource = _names;
                    break;
                case "Movies":
                    _names = new Movies().GetPropertyNames();
                    PropertyMenu.DataSource = _names;
                    break;
                case "Tickets":
                    _names = new Tickets().GetPropertyNames();
                    PropertyMenu.DataSource = _names;
                    break;
                case "Staff":
                    _names = new Staff().GetPropertyNames();
                    PropertyMenu.DataSource = _names;
                    break;
                case "Showing":
                    _names = new Showing().GetPropertyNames();
                    PropertyMenu.DataSource = _names;
                    break;
            }
            PropertyMenu.SelectedItem = "FullInfo";
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            string str = PropertyMenu.Text;
            if (str == "FullInfo")
            {
                str = "*";
            }
            string key = KeyTextbox.Text;
            if ((key == "" || key == " ") && str != "*")
            {
                MessageBox.Show("Entered Empty Key!");
            }
            else
            {
                switch (_type)
                {
                    case "Theater":
                        List<Theater> theater = new List<Theater>();
                        theater = db.GetWhere<Theater>(_type, str, key);
                        DisplayInfoBox.DataSource = theater;
                        DisplayInfoBox.DisplayMember = "FullInfo";
                        break;
                    case "Movies":
                        List<Movies> movies = new List<Movies>();
                        movies = db.GetWhere<Movies>(_type, str, key);
                        DisplayInfoBox.DataSource = movies;
                        DisplayInfoBox.DisplayMember = "FullInfo";
                        break;
                    case "Tickets":
                        List<Tickets> tickets = new List<Tickets>();
                        tickets = db.GetWhere<Tickets>(_type, str, key);
                        DisplayInfoBox.DataSource = tickets;
                        DisplayInfoBox.DisplayMember = "FullInfo";
                        break;
                    case "Staff":
                        List<Staff> staff = new List<Staff>();
                        staff = db.GetWhere<Staff>(_type, str, key);
                        DisplayInfoBox.DataSource = staff;
                        DisplayInfoBox.DisplayMember = "FullInfo";
                        break;
                    case "Showing":
                        List<Showing> showing = new List<Showing>();
                        showing = db.GetWhere<Showing>(_type, str, key);
                        DisplayInfoBox.DataSource = showing;
                        DisplayInfoBox.DisplayMember = "FullInfo";
                        break;
                }
            }
        }
    }
}
