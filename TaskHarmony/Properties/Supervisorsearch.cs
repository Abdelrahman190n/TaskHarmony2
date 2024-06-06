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
    public partial class Supervisorsearch : Form
    {
        public Supervisorsearch()
        {
            InitializeComponent();
        }

        private void cbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbsearch2.Items.Add("Worker");
            cbsearch2.Items.Add("Engineer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supervisormainpage supervisormainpage   = new Supervisormainpage();
            supervisormainpage.Show();
            this.Hide();
        }

        private void done_Click(object sender, EventArgs e)
        {
            if (cbsearch2.SelectedIndex == 0)
            {
                ChatwithWorker chatwithworker = new ChatwithWorker();
                chatwithworker.Show();
                this.Hide();
            }
            else if (cbsearch2.SelectedIndex == 1)
            {
                ChatwithEn chatwithEn = new ChatwithEn();
                chatwithEn.Show();
                this.Hide();
            }
        }

        private void Engineerbutton_Click(object sender, EventArgs e)
        {
            ChatwithEn chatwithEn = new ChatwithEn();
            chatwithEn.Show();
            this.Hide();
        }

        private void superbutton_Click(object sender, EventArgs e)
        {
            ChatwithWorker chatwithworker = new ChatwithWorker();
            chatwithworker.Show();
            this.Hide();
        }

        private void cbsearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void Supervisorsearch_Load(object sender, EventArgs e)
        {

        }
    }
}
