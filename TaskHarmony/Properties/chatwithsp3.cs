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
    public partial class chatwithsp3 : Form
    {
        public chatwithsp3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chatsearch chatsearch = new chatsearch();
            chatsearch.Show();
            this.Hide();
        }
    }
}
