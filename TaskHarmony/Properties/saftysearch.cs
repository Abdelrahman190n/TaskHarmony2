using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskHarmony.Properties
{
    public partial class saftysearch : Form
    {
        public saftysearch()
        {
            InitializeComponent();
            cbsearch.Items.Add("Engineer");

        }

        private void safty_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workermainpage workermainpage = new Workermainpage();
            workermainpage.Show();
            this.Hide();
        }

        private void Engineerbutton_Click(object sender, EventArgs e)
        {
            saftycamera saftycamera = new saftycamera();
            saftycamera.Show();
            this.Hide();
        }

        private void done_Click(object sender, EventArgs e)
        {
            if (cbsearch.SelectedIndex == 0)
            {
                saftycamera saftycamera = new saftycamera();
                saftycamera.Show();
                this.Hide();
            }
        }

        private void cbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
