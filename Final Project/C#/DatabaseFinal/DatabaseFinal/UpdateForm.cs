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
    public partial class UpdateForm : Form
    {
        string _type = "";
        List<string> _names;
        List<string> _types;
        DataAccess db = new DataAccess();
        public UpdateForm(string type)
        {
            InitializeComponent();
            _type = type;
            this.Text = $"Update for {type}";
            DisplayProps();
        }
        //Get Properties of SQL Table to display on form
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
            ColumnDescriptorTxt.Text += $"[{str}]";
            TypeDescriptorTxt.Text += $"[{str2}]";
        }
        //Send update query information to SQL database to be updated
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            db.UpdateTable(_type, WhereTxt.Text, UpdateTxt.Text);
            MessageBox.Show("Successfully Updated!");
        }
    }
}
