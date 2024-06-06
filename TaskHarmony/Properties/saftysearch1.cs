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
    public partial class saftysearch1 : Form
    {
        public saftysearch1()
        {
            InitializeComponent();
            cbsearch2.Items.Add("Engineer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supervisormainpage supervisorsearch =new Supervisormainpage();
            supervisorsearch.Show();
            this.Hide();

        }

        private void Engineerbutton_Click(object sender, EventArgs e)
        {
            saftycamera1 Saftycamera1 = new saftycamera1();
            Saftycamera1.Show();
            this.Hide();
        }

        private void cbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {
            if(cbsearch2.SelectedIndex == 0)
            {
                saftycamera1 Saftycamera1 = new saftycamera1();
                Saftycamera1.Show();
                this.Hide();
            }
        }
    }
}
