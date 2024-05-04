using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void MC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Next f2 = new Next();
            f2.Show();
        }

        private void CD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Next f2 = new Next();
            f2.Show();
        }

        private void Mail_Click(object sender, EventArgs e)
        {
            this.Hide();
            Next f2 = new Next();
            f2.Show();
        }

        private void PC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Next f2 = new Next();
            f2.Show();
        }
    }
}
