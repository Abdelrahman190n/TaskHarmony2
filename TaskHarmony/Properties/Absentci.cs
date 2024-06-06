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
    public partial class Absentci : Form
    {
        public Absentci()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MesageCi mesageCi = new MesageCi();
            mesageCi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supervisormainpage supervisormainpage = new Supervisormainpage();
            supervisormainpage.Show();
            this.Hide();
        }
    }
}
