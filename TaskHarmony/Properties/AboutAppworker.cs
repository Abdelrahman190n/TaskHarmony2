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
    public partial class AboutAppworker : Form
    {
        public AboutAppworker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workermainpage workermainpage = new Workermainpage(); 
            workermainpage.Show();
            this.Hide();
        }
    }
}
