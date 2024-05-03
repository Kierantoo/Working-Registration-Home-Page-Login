using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Login_Page
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (e is KeyEventArgs keyEventArgs && keyEventArgs.KeyCode == Keys.Enter)
                    SearchButton.PerformClick();

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0H39E95;Initial Catalog=Username/Passwords;Integrated Security=True;Trust Server Certificate=True");
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    using (DataTable dt = new DataTable("PokemonList"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT *FROM Pokemon_List where pokemonid=@pokemonid or pokemonname like @pokemonname", conn))
                        {
                            cmd.Parameters.AddWithValue("pokemonid", Searchtxt.Text);
                            cmd.Parameters.AddWithValue("pokemonname", string.Format("%{0}%", Searchtxt.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView.DataSource = dt;
                            totaltxt.Text = $"Total Found: {dataGridView.Rows.Count}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
