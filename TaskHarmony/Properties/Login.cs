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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ForgetPass forgetPass = new ForgetPass();
            forgetPass.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text==null && string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Invalid email and invalid password");
            }
            else if (!textBox2.Text.Contains("@gmail.com") && !string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Invalid email");
            }
            else if (textBox2.Text.Contains("@gmail.com") && string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Invalid password");
            }
            else if (textBox2.Text.Contains("@gmail.com") && !string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Login successfully!");
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(textBox1.PasswordChar == '*')
            {
                button1.BringToFront();
                textBox1.PasswordChar = '\0';
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '\0')
            {
                button3.BringToFront();
                textBox1.PasswordChar = '*';
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
