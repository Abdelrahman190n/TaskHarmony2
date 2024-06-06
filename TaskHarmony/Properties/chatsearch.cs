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
    public partial class chatsearch : Form
    {
        public chatsearch()
        {
            InitializeComponent();
            cbsearch5.Items.Add("Worker");
            cbsearch5.Items.Add("Suervisor");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engineermainpage engineermainpage =new Engineermainpage();
            engineermainpage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chatwithsp chatwithsp =new Chatwithsp();
            chatwithsp.Show();
            this.Hide();
        }

        private void done_Click(object sender, EventArgs e)
        {
            if (cbsearch5.SelectedIndex == 0)
            {
                Chatwithsp chatwithsp = new Chatwithsp();
                chatwithsp.Show();
                this.Hide();
            }
            else if(cbsearch5.SelectedIndex == 1)
            {
                chatwithwr chatwithwr = new chatwithwr();
                chatwithwr.Show();
                this.Hide();
            }
        }

        private void chatsearch_Load(object sender, EventArgs e)
        {

        }

        private void Engineerbutton_Click(object sender, EventArgs e)
        {
            chatwithwr chatwithwr =new chatwithwr();
            chatwithwr.Show();
            this.Hide();
        }
    }
}
