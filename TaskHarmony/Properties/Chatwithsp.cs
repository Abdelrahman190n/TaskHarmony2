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
    public partial class Chatwithsp : Form
    {
        public Chatwithsp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chatsearch chatsearch = new chatsearch();
            chatsearch.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chatsearch chatsearch = new chatsearch();
            chatsearch.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            chatwithsp2 chatsearch = new chatwithsp2();
            chatsearch.Show();
            this.Hide();
        }
    }
}
