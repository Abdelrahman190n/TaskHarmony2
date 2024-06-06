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
    public partial class AbsenceCi : Form
    {
        public AbsenceCi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageAbsence messageAbsence = new MessageAbsence();
            messageAbsence.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workermainpage workermainpage = new Workermainpage();
            workermainpage.Show();
            this.Hide();
        }
    }
}
