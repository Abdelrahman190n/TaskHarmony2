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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checkemail checkemail = new Checkemail();
            checkemail.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (! string.IsNullOrEmpty(textBox1.Text) &&!string.IsNullOrEmpty(textBox2.Text))
            {
                Successfullyreset successfullyreset = new Successfullyreset();
                successfullyreset.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                button3.BringToFront();
                textBox1.PasswordChar = '\0';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '\0')
            {
                button4.BringToFront();
                textBox1.PasswordChar = '*';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                button5.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button6.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }
    }
}