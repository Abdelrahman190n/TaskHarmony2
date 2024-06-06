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
    public partial class chatengineer3 : Form
    {
        public chatengineer3()
        {
            InitializeComponent();
        }

        private void chatengineer3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            workersearch workersearch = new workersearch();
            workersearch.Show();
            this.Hide();
        }
    }
}
