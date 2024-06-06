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
    public partial class Absentco : Form
    {
        public Absentco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupermainPage2 supermainPage2 = new SupermainPage2();
            supermainPage2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageCo messageCo = new MessageCo();
            messageCo.Show();
            this.Hide();
        }
    }
}
