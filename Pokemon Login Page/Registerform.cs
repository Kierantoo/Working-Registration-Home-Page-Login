using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pokemon_Login_Page
{
    public partial class Registerform : Form
    {
        public Registerform()
        {
            InitializeComponent();
            
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0H39E95;Initial Catalog=Username/Passwords;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Users (FirstName, LastName, Email, user_name, Password) VALUES (@FirstName, @LastName, @Email, @user_name, @Password)", con);
            cmd.Parameters.AddWithValue("@FirstName", regFirstname.Text);
            cmd.Parameters.AddWithValue("@LastName", regLastname.Text);
            cmd.Parameters.AddWithValue("@Email", regEmail.Text);
            cmd.Parameters.AddWithValue("@user_name", regUsername.Text);
            cmd.Parameters.AddWithValue("@Password", regPassword.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Register Successful");
        }

        private void Linklog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();

        }
    }
}
