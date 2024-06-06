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
    public partial class saftycamera1 : Form
    {
        public saftycamera1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saftysearch1 saftysearch1 = new saftysearch1();
            saftysearch1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saftyphoto1 saftyphoto1 = new saftyphoto1();    
            saftyphoto1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saftycamera1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
