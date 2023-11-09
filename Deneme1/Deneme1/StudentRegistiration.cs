using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme1
{
    public partial class StudentRegistiration : MaterialSkin.Controls.MaterialForm
    {
        public StudentRegistiration(string username)
        {
            this.username = username;
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            DoldurComboBox();
        }

        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4}",
            "localhost", "5433", "postgres",
            "12345", "Deneme1");
        private NpgsqlCommand cmd;
        private string sql = null;
        private string username;
        

        private void DoldurComboBox()
        {
            string sql = "SELECT ogrtad, ogrtsoyad, ogrtders FROM ogretmen";
            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            comboBox1.Items.Add(row["ogrtad"].ToString() + " " + row["ogrtsoyad"].ToString() + " " + row["ogrtders"].ToString() );
                        }
                    }
                }
            }
        }


        private void StudentRegistiration_Load(object sender, EventArgs e)
        {
            label2.Text = label2.Text;
            conn = new NpgsqlConnection(connstring);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Student(username).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*DateTime tarih = DateTime.Now;
            EkleOgrenciOgretmen(ogrno, ogrtsicil, tarih);*/
        }
        private void CreateRelationship(int ogrno, int ogrtsicil)
        {
            string connectionString = "your_connection_string_here";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO OgrenciOgretmen (OgrenciID, OgretmenID, Tarih) VALUES (@ogrno, @ogrtsicil, @tarih)";

                    cmd.Parameters.AddWithValue("@ogrno", ogrno);
                    cmd.Parameters.AddWithValue("@ogrtsicil", ogrtsicil);
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ders talebiniz gönderildi.");
                    }
                    else
                    {
                        MessageBox.Show("İlişki kaydedilemedi.");
                    }
                }
                connection.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

