using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskHarmony.Properties
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void arbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox5.Text != null && textBox2.Text != null && textBox2.Text.Length == 11 && textBox2.Text.StartsWith("01") && textBox3.Text.Contains("@gmail.com") && textBox4 != null && textBox4.Text.Length >= 5)
            {
                MessageBox.Show("Register Successfully!");
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
            if (textBox4.Text.Length <= 5)
            {
                MessageBox.Show("password should be 5 or more numbers");
            }
            if (textBox3.Text.Length == 0 || !textBox3.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Invalid Email");
            }
        }

        private void backbutton2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox4.PasswordChar == '\0')
{
                button2.BringToFront();
                textBox4.PasswordChar = '*';
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.PasswordChar == '*')
            {
                button1.BringToFront();
                textBox4.PasswordChar = '\0';
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}