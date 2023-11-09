using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using TesseractOCR;

namespace Deneme1
{
    public partial class StudentTranskript : MaterialSkin.Controls.MaterialForm
    {
        public StudentTranskript(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private string username;

        private void StudentTranskript_Load(object sender, EventArgs e)
        {
            transkriptyukle.Text = transkriptyukle.Text;
        }

        private void transkriptyukle_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var img = new Bitmap(openFileDialog1.FileName);
                var ocr = new TesseractEngine("./tessdata", "tur");
                var sonuc = ocr.Process(img);
                richTextBox1.Text = sonuc.GetText();
            }
        }
    }
}
