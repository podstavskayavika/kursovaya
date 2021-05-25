using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsGame.User_Interface
{
    public partial class ManualForm : Form
    {
        public ManualForm()
        {
            InitializeComponent();

            string[] row = new string[] { "" };

            if (Check(row[0]))
                listView1.Items.Add(new ListViewItem(row));
            else
                MessageBox.Show("fdasf");
        }
        private void FillManual()
        {
            string[] row = new string[] { "d", "d" };
        }
        private bool Check(string text)
        {
            if (text.Length > 46)
                return false;
            return true;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
