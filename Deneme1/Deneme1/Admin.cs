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
    public partial class Admin : MaterialSkin.Controls.MaterialForm
    {
        public Admin(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private string username;

        private void Admin_Load(object sender, EventArgs e)
        {
            ad.Text = ad.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
