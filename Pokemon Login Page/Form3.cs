using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Login_Page
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void MC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f2 = new Form4();
            f2.Show();
        }

        private void CD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f3 = new Form5();
            f3.Show();
        }

        private void Mail_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f4 = new Form6();
            f4.Show();
        }

        private void PC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f5 = new Form7();
            f5.Show();
        }

    }
}