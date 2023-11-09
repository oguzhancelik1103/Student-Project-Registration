namespace Deneme1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ogretmenbtn = new System.Windows.Forms.Button();
            this.adminbtn = new System.Windows.Forms.Button();
            this.ogrencibtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.ogretmenbtn);
            this.panel1.Controls.Add(this.adminbtn);
            this.panel1.Controls.Add(this.ogrencibtn);
            this.panel1.Location = new System.Drawing.Point(750, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 494);
            this.panel1.TabIndex = 0;
            // 
            // ogretmenbtn
            // 
            this.ogretmenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogretmenbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogretmenbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ogretmenbtn.Location = new System.Drawing.Point(18, 144);
            this.ogretmenbtn.Name = "ogretmenbtn";
            this.ogretmenbtn.Size = new System.Drawing.Size(220, 62);
            this.ogretmenbtn.TabIndex = 2;
            this.ogretmenbtn.Text = "Öğretmen";
            this.ogretmenbtn.UseVisualStyleBackColor = true;
            this.ogretmenbtn.Click += new System.EventHandler(this.ogretmenbtn_Click);
            // 
            // adminbtn
            // 
            this.adminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminbtn.Location = new System.Drawing.Point(18, 415);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(220, 40);
            this.adminbtn.TabIndex = 1;
            this.adminbtn.Text = "Admin";
            this.adminbtn.UseVisualStyleBackColor = true;
            this.adminbtn.Click += new System.EventHandler(this.adminbtn_Click);
            // 
            // ogrencibtn
            // 
            this.ogrencibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrencibtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrencibtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ogrencibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ogrencibtn.Location = new System.Drawing.Point(18, 47);
            this.ogrencibtn.Name = "ogrencibtn";
            this.ogrencibtn.Size = new System.Drawing.Size(220, 60);
            this.ogrencibtn.TabIndex = 0;
            this.ogrencibtn.Text = "Öğrenci";
            this.ogrencibtn.UseVisualStyleBackColor = true;
            this.ogrencibtn.Click += new System.EventHandler(this.ogrencibtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 494);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 558);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proje Dersi Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ogrencibtn;
        private System.Windows.Forms.Button ogretmenbtn;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

