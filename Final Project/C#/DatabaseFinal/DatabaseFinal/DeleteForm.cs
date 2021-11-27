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
        public DeleteForm(string type)
        {
            InitializeComponent();
            _type = type;
            this.Text = $"Delete/Recover for {type}";
        }

        //Soft deletes a row by setting IsRemoved to 1
        private void DeleteFinalBtn_Click(object sender, EventArgs e)
        {
            db.DeleteRow(_type, DeleteTextBox.Text);
            MessageBox.Show("Successfully Deleted Rows");
        }

        //Recovers a row by setting IsRemoved to 0
        private void RecoverBtn_Click(object sender, EventArgs e)
        {
            db.RecoverRow(_type, DeleteTextBox.Text);
            MessageBox.Show("Successfully Recover Rows");
        }
    }
}
