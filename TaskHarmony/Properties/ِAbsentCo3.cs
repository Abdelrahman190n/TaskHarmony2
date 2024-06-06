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
    public partial class _ِAbsentCo3 : Form
    {
        public _ِAbsentCo3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MeeageCo3 meeageCo3 = new MeeageCo3();
            meeageCo3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engineermain2 engineermain2 = new Engineermain2();
            engineermain2.Show();
            this.Hide();
        }
    }
}
