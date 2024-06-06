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
    public partial class MessageAbsenceCo : Form
    {
        public MessageAbsenceCo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbsenceCo absenceCo = new AbsenceCo();
            absenceCo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workermainpage workermainpage  = new Workermainpage();
            workermainpage.button6.Visible = false;
            workermainpage.button2.Visible = false;
            workermainpage.Show();
            this.Hide();
        }
    }
}
