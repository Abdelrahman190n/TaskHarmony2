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
    public partial class saftysearch3 : Form
    {
        public saftysearch3()
        {
            InitializeComponent();
            cbsearch4.Items.Add("Worker");
            cbsearch4.Items.Add("Supervisor");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engineermainpage engineermainpage = new Engineermainpage();
            engineermainpage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saftyphoto2 saftyphoto2 = new saftyphoto2();
            saftyphoto2.Show();
            this.Hide();
        }

        private void Engineerbutton_Click(object sender, EventArgs e)
        {
            saftyphoto3 saftyphoto2 = new saftyphoto3();
            saftyphoto2.Show();
            this.Hide();
        }

        private void done_Click(object sender, EventArgs e)
        {
            if (cbsearch4.SelectedIndex == 0)
            {

                saftyphoto2 saftyphoto2 = new saftyphoto2();
                saftyphoto2.Show();
                this.Hide();
            }

            else if (cbsearch4.SelectedIndex == 1)
            {
                saftyphoto3 saftyphoto2 = new saftyphoto3();
                saftyphoto2.Show();
                this.Hide();
            }
        }
    }
}
