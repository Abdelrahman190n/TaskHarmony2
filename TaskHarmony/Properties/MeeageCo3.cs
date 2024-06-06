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
    public partial class MeeageCo3 : Form
    {
        public MeeageCo3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engineermainpage engineermainpage = new Engineermainpage();
            engineermainpage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ِAbsentCo3 a=new _ِAbsentCo3();
            a.Show();
            this.Hide();
        }
    }
}
