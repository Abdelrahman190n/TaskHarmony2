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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void workerbutton_Click(object sender, EventArgs e)
        {
            Workermainpage workermainpage = new Workermainpage();
            workermainpage.Show();
            this.Hide();
        }

        private void superbutton_Click(object sender, EventArgs e)
        {
            Supervisormainpage supervisormainpage = new Supervisormainpage();
            supervisormainpage.Show();
            this.Hide();
        }

        private void Engineerbutton_Click(object sender, EventArgs e)
        {
            Engineermainpage engineermainpage = new Engineermainpage();
            engineermainpage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
