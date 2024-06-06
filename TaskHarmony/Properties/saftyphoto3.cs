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
    public partial class saftyphoto3 : Form
    {
        public saftyphoto3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saftysearch3 saftysearch3 = new saftysearch3();
            saftysearch3.Show();
            this.Hide();
        }
    }
}
