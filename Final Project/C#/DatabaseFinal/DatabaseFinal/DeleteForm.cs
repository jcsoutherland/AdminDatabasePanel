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
    public partial class DeleteForm : Form
    {
        string _type = "";
        DataAccess db = new DataAccess();
        List<string> _names;
        List<string> _types;
        public DeleteForm(string type)
        {
            InitializeComponent();
            _type = type;
            this.Text = $"Delete/Recover for {type}";
            SetTableInfo();
            DisplayProps();
        }

        public void SetTableInfo()
        {
            switch (_type)
            {
                case "Theater":
                    List<Theater> theater = new List<Theater>();
                    theater = db.GetTableContents<Theater>(_type);
                    NotRemovedListBox.DataSource = theater;
                    NotRemovedListBox.DisplayMember = "FullInfo";
                    List<Theater> theater2 = db.GetWhere<Theater>(_type, "IsRemoved", "= 1");
                    RemovedListBox.DataSource = theater2;
                    RemovedListBox.DisplayMember = "FullInfo";
                    break;
                case "Movies":
                    List<Movies> movies = new List<Movies>();
                    movies = db.GetTableContents<Movies>(_type);
                    NotRemovedListBox.DataSource = movies;
                    NotRemovedListBox.DisplayMember = "FullInfo";
                    List<Movies> movies2 = db.GetWhere<Movies>(_type, "IsRemoved", "= 1");
                    RemovedListBox.DataSource = movies2;
                    RemovedListBox.DisplayMember = "FullInfo";
                    break;
                case "Tickets":
                    List<Tickets> tickets = new List<Tickets>();
                    tickets = db.GetTableContents<Tickets>(_type);
                    NotRemovedListBox.DataSource = tickets;
                    NotRemovedListBox.DisplayMember = "FullInfo";
                    List<Tickets> tickets2 = db.GetWhere<Tickets>(_type, "IsRemoved", "= 1");
                    RemovedListBox.DataSource = tickets2;
                    RemovedListBox.DisplayMember = "FullInfo";
                    break;
                case "Staff":
                    List<Staff> staff = new List<Staff>();
                    staff = db.GetTableContents<Staff>(_type);
                    NotRemovedListBox.DataSource = staff;
                    NotRemovedListBox.DisplayMember = "FullInfo";
                    List<Staff> staff2 = db.GetWhere<Staff>(_type, "IsRemoved", "= 1");
                    RemovedListBox.DataSource = staff2;
                    RemovedListBox.DisplayMember = "FullInfo";
                    break;
                case "Showing":
                    List<Showing> showing = new List<Showing>();
                    showing = db.GetTableContents<Showing>(_type);
                    NotRemovedListBox.DataSource = showing;
                    NotRemovedListBox.DisplayMember = "FullInfo";
                    List<Showing> showing2 = db.GetWhere<Showing>(_type, "IsRemoved", "= 1");
                    RemovedListBox.DataSource = showing2;
                    RemovedListBox.DisplayMember = "FullInfo";
                    break;
            }

            //db.GetTableContents<T>(_type);
           // db.GetWhere<T>(_type, "IsRemoved", "IsRemoved = 1");
        }

        public void DisplayProps()
        {
            switch (_type)
            {
                case "Theater":
                    _names = new Theater().GetPropertyNames();
                    _types = new Theater().GetPropTypes();
                    break;
                case "Movies":
                    _names = new Movies().GetPropertyNames();
                    _types = new Movies().GetPropTypes();
                    break;
                case "Tickets":
                    _names = new Tickets().GetPropertyNames();
                    _types = new Tickets().GetPropTypes();
                    break;
                case "Staff":
                    _names = new Staff().GetPropertyNames();
                    _types = new Staff().GetPropTypes();
                    break;
                case "Showing":
                    _names = new Showing().GetPropertyNames();
                    _types = new Showing().GetPropTypes();
                    break;
            }
            string str = "";
            for (int i = 0; i < _names.Count - 1; i++)
            {
                str += $"{_names[i]} | ";
            }
            string str2 = "";
            for (int i = 0; i < _types.Count - 1; i++)
            {
                string s2 = _types[i].Split('.')[1];
                str2 += $"{s2} | ";
            }
            ColumnNamesTxt.Text += $"[{str}]";
            ColumnTypesTxt.Text += $"[{str2}]";
        }

        //Soft deletes a row by setting IsRemoved to 1
        private void DeleteFinalBtn_Click(object sender, EventArgs e)
        {
            db.DeleteRow(_type, DeleteTextBox.Text);
            SetTableInfo();
            MessageBox.Show("Successfully Deleted Rows");
        }

        //Recovers a row by setting IsRemoved to 0
        private void RecoverBtn_Click(object sender, EventArgs e)
        {
            db.RecoverRow(_type, DeleteTextBox.Text);
            SetTableInfo();
            MessageBox.Show("Successfully Recover Rows");
        }

        private void DeleteLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
