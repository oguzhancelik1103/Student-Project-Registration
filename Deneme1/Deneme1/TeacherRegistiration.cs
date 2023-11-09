using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Deneme1
{
    public partial class TeacherRegistiration : MaterialSkin.Controls.MaterialForm
    {
        public TeacherRegistiration(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private string username;

        private void TeacherRegistiration_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Teacher(username).Show();
        }
    }
}
