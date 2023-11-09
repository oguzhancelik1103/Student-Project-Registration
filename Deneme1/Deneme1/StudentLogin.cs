using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme1
{
    public partial class FrmStudent : MaterialSkin.Controls.MaterialForm
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4}",
            "localhost", "5433", "postgres",
            "12345", "Deneme1");
        private NpgsqlCommand cmd;
        private string sql = null;

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void giris_Click(object sender, EventArgs e)
        {
                try
                {
                    conn.Open();
                    sql = @"select * from ulogin(:_username,:_password)";
                    cmd = new NpgsqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("_username", kullaniciaditxt.Text);
                    cmd.Parameters.AddWithValue("_password", sifretxt.Text);

                    Boolean result = (Boolean)cmd.ExecuteScalar();
                    conn.Close();

                    if (result == true)
                    {
                        this.Hide();
                        new Student(kullaniciaditxt.Text).Show();
                    }
                    else
                    {
                        MessageBox.Show("Please check your username or password", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
        }
    }
}
