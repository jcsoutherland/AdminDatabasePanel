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
    public partial class CustomQForm : Form
    {
        DataAccess db = new DataAccess();
        public CustomQForm()
        {
            InitializeComponent();
        }

    /*ex:select *
     from Theaters.Theater T
     where T.TheaterId between 1 and 20
     order by T.TheaterId desc
    */

        //Sends custom query to SQL database and gets the results
        private void SendQueryBtn_Click(object sender, EventArgs e)
        {
            List<string> list = QueryText.Text.Split('\n').ToList();
            string str = "";
            foreach(string s in list)
            {
                str += $"{s} ";
            }
            List<object> result = db.GetCustomQuery<object>(str);
            ResultListBox.DataSource = result;
            ResultListBox.DisplayMember = "FullInfo";
            ResultListBox.Visible = true;
        }

        //Clears the custom query text.
        private void NewQBtn_Click(object sender, EventArgs e)
        {
            ResultListBox.Visible = false;
            QueryText.Clear();
        }
    }
}
