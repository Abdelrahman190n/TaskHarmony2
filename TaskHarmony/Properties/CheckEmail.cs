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
    public partial class Checkemail : Form
    {
        public Checkemail()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) &&!string.IsNullOrEmpty(textBox4.Text) &&!string.IsNullOrEmpty(textBox5.Text))
            {
                ChangePass changePass = new ChangePass();
                changePass.Show();
                this.Hide();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForgetPass forgetPass = new ForgetPass();
            forgetPass.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ForgetPass forgetPass = new ForgetPass();
            forgetPass.Show();
            this.Hide();
        }
    }
}
