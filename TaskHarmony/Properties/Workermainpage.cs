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
    public partial class Workermainpage : Form
    {
        public Workermainpage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            workersearch workersearch = new workersearch();
            workersearch.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbsenceCo absenceCi = new AbsenceCo();
            absenceCi.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            saftysearch safty = new saftysearch();
            safty.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutAppworker aboutAppworker = new AboutAppworker();
            aboutAppworker.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbsenceCi absenceCi = new AbsenceCi();
            absenceCi.Show();
            this.Hide();
        }
    }
}
