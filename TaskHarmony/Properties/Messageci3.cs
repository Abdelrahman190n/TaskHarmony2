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
    public partial class Messageci3 : Form
    {
        public Messageci3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engineermain2 engineermain2 = new Engineermain2();
            engineermain2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Absentci3 absentci3 = new Absentci3();
            absentci3.Show();
            this.Hide();
        }
    }
}
