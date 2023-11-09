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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();

            frmAdmin.ShowDialog();
        }

        private void ogrencibtn_Click(object sender, EventArgs e)
        {
            FrmStudent student = new FrmStudent();

            student.Show();
        }

        private void ogretmenbtn_Click(object sender, EventArgs e)
        {
            FrmTeacher teacher = new FrmTeacher();

            teacher.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
