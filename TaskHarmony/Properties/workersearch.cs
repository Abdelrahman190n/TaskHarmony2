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
    public partial class workersearch : Form
    {
        public workersearch()
        {
            InitializeComponent();
            cbsearch.Items.Add("Engineer");
            cbsearch.Items.Add("Supervisor");
        }

        private void workersearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void workersearch_Load(object sender, EventArgs e)
        {

        }

        private void Engineerbutton_Click(object sender, EventArgs e)
        {
          chatengineer chatwithengineer = new chatengineer();
            chatwithengineer.Show();
            this.Hide();
        }

        private void done_Click(object sender, EventArgs e)
        {

            if (cbsearch.SelectedIndex == 0)
            {
                chatengineer chatwithengineer = new chatengineer();
                chatwithengineer.Show();
                this.Hide();
            }
            else if (cbsearch.SelectedIndex == 1)
            {
                chatsupervisor chatwithsuperviosor = new chatsupervisor();
                chatwithsuperviosor.Show();
                this.Hide();

            }
        }

        private void superbutton_Click(object sender, EventArgs e)
        {

            chatsupervisor chatwithsuperviosor = new chatsupervisor();
            chatwithsuperviosor.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workermainpage workermainpage = new Workermainpage();
            workermainpage.Show();
            this.Hide();
        }

        private void cbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
