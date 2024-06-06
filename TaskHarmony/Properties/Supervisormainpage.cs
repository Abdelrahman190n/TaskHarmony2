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
    public partial class Supervisormainpage : Form
    {
        public Supervisormainpage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supervisorsearch supervisorsearch = new Supervisorsearch();
            supervisorsearch.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Absentco absentco = new Absentco();
            absentco.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saftysearch1 saftysearch1   = new saftysearch1();
            saftysearch1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutApp2 aboutApp2 = new AboutApp2();
            aboutApp2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Absentci absentci = new Absentci();
            absentci.Show();
            this.Hide();
        }
    }
}
