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
    public partial class MessageCo : Form
    {
        public MessageCo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Absentco absentco = new Absentco();
            absentco.Show();
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
