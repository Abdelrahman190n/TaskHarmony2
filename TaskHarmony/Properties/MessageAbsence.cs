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
    public partial class MessageAbsence : Form
    {
        public MessageAbsence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workermainpage workermainPage = new Workermainpage();
            workermainPage.button6.Visible = false;
            workermainPage.button2.Visible = true;
            workermainPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbsenceCi absenceCi = new AbsenceCi();
            absenceCi.Show();
            this.Hide();
        }
    }       
}
