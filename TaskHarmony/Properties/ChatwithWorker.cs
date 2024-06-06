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
    public partial class ChatwithWorker : Form
    {
        public ChatwithWorker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supervisorsearch supervisorsearch = new Supervisorsearch();
            supervisorsearch.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChatwithWorker2 chatwithWorker = new ChatwithWorker2();
            chatwithWorker.Show();
            this.Hide();
        }
    }
}
