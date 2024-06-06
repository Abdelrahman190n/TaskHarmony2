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
    public partial class MesageCi : Form
    {
        public MesageCi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Absentci absentci = new Absentci();
            absentci.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supervisormainpage supermainPage = new Supervisormainpage();
            supermainPage.button6.Visible = false;
            supermainPage.button2.Visible = true;
            supermainPage.Show();
            this.Hide();
        }
    }
}
