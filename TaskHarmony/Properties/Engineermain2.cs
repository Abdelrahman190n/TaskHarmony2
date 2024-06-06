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
    public partial class Engineermain2 : Form
    {
        public Engineermain2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ِAbsentCo3 A=new _ِAbsentCo3();
            A.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saftysearch3 saftysearch3 = new saftysearch3();
            saftysearch3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutApp3 AboutApp = new AboutApp3();
            AboutApp.Show();
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
