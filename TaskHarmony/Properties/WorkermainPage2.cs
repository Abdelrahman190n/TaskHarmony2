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
    public partial class WorkermainPage2 : Form
    {
        public WorkermainPage2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbsenceCo absenceCo = new AbsenceCo();
            absenceCo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            workersearch workersearch = new workersearch();
            workersearch.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saftysearch saftysearch = new saftysearch();
            saftysearch.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutAppworker aboutAppworker   = new AboutAppworker();
            aboutAppworker.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
    }
}
