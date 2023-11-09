using Newtonsoft.Json;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme1
{
    public partial class Student : MaterialSkin.Controls.MaterialForm
    {
        public Student(string username)
        {

            this.username = username;
            InitializeComponent();
    }

        private string username;

        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4}",
            "localhost", "5433", "postgres",
            "12345", "Deneme1");
        private NpgsqlCommand cmd;
        private string sql = null;


        private void Student_Load(object sender, EventArgs e)
        {
            st.Text = st.Text;
            conn = new NpgsqlConnection(connstring);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into ogrenci (ogrno, ograd, ogrsoyad, ogralan, ogrgano) values (@p1,@p2,@p3,@p4,@p5)", conn);
            cmd.Parameters.AddWithValue("@p1", int.Parse(ogrno.Text));
            cmd.Parameters.AddWithValue("@p2", ograd.Text);
            cmd.Parameters.AddWithValue("@p3", ogrsoyad.Text);
            string json = JsonConvert.SerializeObject(new { ogralan = ogralan.Text });
            cmd.Parameters.AddWithValue("@p4", NpgsqlDbType.Json, json);
            double ogrganoValue;
            if (Double.TryParse(ogrgano.Text, out ogrganoValue))
            {
                cmd.Parameters.AddWithValue("@p5", ogrganoValue);
            }
            else
            {
                MessageBox.Show("Geçersiz sayı girişi. Lütfen sayısal bir değer girin.");
            };
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Bilgileriniz kaydedilmiştir.");
        }

        public void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE ogretmen SET ograd = @p2, ogrsoyad = @p3, ogralan = @p4, ogrgano = @p5 WHERE ogrno = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", int.Parse(ogrno.Text));
            cmd.Parameters.AddWithValue("@p2", ograd.Text);
            cmd.Parameters.AddWithValue("@p3", ogrsoyad.Text);
            string json = JsonConvert.SerializeObject(new { ogralan = ogralan.Text });
            cmd.Parameters.AddWithValue("@p4", NpgsqlDbType.Json, json);
            cmd.Parameters.AddWithValue("@p5", ogrgano.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Bilgileriniz güncellenmiştir.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student girisEkran = new Student(username);
            girisEkran.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StudentRegistiration(username).Show();
        }
    }
}
