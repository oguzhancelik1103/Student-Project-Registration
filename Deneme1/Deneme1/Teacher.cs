using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Deneme1
{
    public partial class Teacher : MaterialSkin.Controls.MaterialForm
    {
        public Teacher(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4}",
            "localhost", "5433", "postgres",
            "12345", "Deneme1");
        private NpgsqlCommand cmd;
        private string sql = null;

        private string username;

        private void Teacher_Load(object sender, EventArgs e)
        {
            tc.Text = tc.Text;
            conn = new NpgsqlConnection(connstring);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into ogretmen (ogrtsicil, ogrtad, ogrtsoyad, ogrtalan, ogrtkontenjan, ogrtders, ogrtkriter) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn);
            cmd.Parameters.AddWithValue("@p1", int.Parse(sicil.Text));
            cmd.Parameters.AddWithValue("@p2", ad.Text);
            cmd.Parameters.AddWithValue("@p3", soyad.Text);
            string json = JsonConvert.SerializeObject(new { alan = alan.Text });
            cmd.Parameters.AddWithValue("@p4", NpgsqlDbType.Json, json);
            cmd.Parameters.AddWithValue("@p5", int.Parse(kontenjan.Text));
            string json1 = JsonConvert.SerializeObject(new { ders = ders.Text });
            cmd.Parameters.AddWithValue("@p6", NpgsqlDbType.Json, json1);
            string json2 = JsonConvert.SerializeObject(new { kriter = kriter.Text });
            cmd.Parameters.AddWithValue("@p7", NpgsqlDbType.Json, json2);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Bilgileriniz kaydedilmiştir.");
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE ogretmen SET ogrtad = @p2, ogrtsoyad = @p3, ogrtalan = @p4, ogrtkontenjan = @p5, ogrtders = @p6, ogrtkriter = @p7 WHERE ogrtsicil = @p1", conn);
                cmd.Parameters.AddWithValue("@p1", int.Parse(sicil.Text));
                cmd.Parameters.AddWithValue("@p2", ad.Text);
                cmd.Parameters.AddWithValue("@p3", soyad.Text);
                string json = JsonConvert.SerializeObject(new { alan = alan.Text });
                cmd.Parameters.AddWithValue("@p4", NpgsqlDbType.Json, json);
                cmd.Parameters.AddWithValue("@p5", int.Parse(kontenjan.Text));
                string json1 = JsonConvert.SerializeObject(new { ders = ders.Text });
                cmd.Parameters.AddWithValue("@p6", NpgsqlDbType.Json, json1);
                string json2 = JsonConvert.SerializeObject(new { kriter = kriter.Text });
                cmd.Parameters.AddWithValue("@p7", NpgsqlDbType.Json, json2);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Bilgileriniz güncellenmiştir.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher girisEkran = new Teacher(username);
            girisEkran.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TeacherRegistiration(username).Show();
        }
    }
}
