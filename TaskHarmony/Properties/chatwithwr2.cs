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
    public partial class chatwithwr2 : Form
    {
        public chatwithwr2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chatsearch chatsearch = new chatsearch();
            chatsearch.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chatwithwr3 chatwithwr = new chatwithwr3();
            chatwithwr.Show();
            this.Hide();
        }
    }
}
