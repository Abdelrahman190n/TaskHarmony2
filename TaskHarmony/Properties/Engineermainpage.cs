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
    public partial class Engineermainpage : Form
    {
        public Engineermainpage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutApp3 aboutApp3 = new AboutApp3();
            aboutApp3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saftysearch3 saftysearch3 = new saftysearch3();
            saftysearch3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
               _ِAbsentCo3 a = new _ِAbsentCo3();
                a.Show();
                this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chatsearch chatsearch = new chatsearch();
            chatsearch.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
            Absentci3 absentci3 = new Absentci3();
            absentci3.Show();
            this.Hide();
            
        }

        private void Engineermainpage_Load(object sender, EventArgs e)
        {

        }
    }
}
