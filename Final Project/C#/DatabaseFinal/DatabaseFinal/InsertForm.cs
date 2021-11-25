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
    public partial class InsertForm : Form
    {
        DataAccess db = new DataAccess();
        public string _type = "";
        List<string> _names;
        List<string> _types;
        public InsertForm(string type)
        {
            InitializeComponent();
            _type = type;
            this.Text = $"Insert Into {type}";
            DisplayProps();
        }

        private void InsrtButton_Click(object sender, EventArgs e)
        {
            db.InsertIntoTable(_type, ValuesText.Text, ColumnsText.Text);
            MessageBox.Show("Successfully Inserted!");
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
            for(int i = 0; i <_names.Count - 1; i++)
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
    }
}
