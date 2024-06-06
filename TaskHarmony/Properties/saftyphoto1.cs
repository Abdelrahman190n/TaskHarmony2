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
    public partial class saftyphoto1 : Form
    {
        public saftyphoto1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saftysearch1 saftysearch1 = new saftysearch1();
            saftysearch1.Show();
            this.Hide();
        }
    }
}
