namespace Deneme1
{
    partial class FrmTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullaniciadi = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Label();
            this.kullaniciaditc = new System.Windows.Forms.TextBox();
            this.sifretc = new System.Windows.Forms.TextBox();
            this.giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AutoSize = true;
            this.kullaniciadi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadi.Location = new System.Drawing.Point(64, 138);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(132, 25);
            this.kullaniciadi.TabIndex = 0;
            this.kullaniciadi.Text = "Kullanıcı Adı";
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(139, 202);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(57, 25);
            this.sifre.TabIndex = 1;
            this.sifre.Text = "Şifre";
            this.sifre.Click += new System.EventHandler(this.sifre_Click);
            // 
            // kullaniciaditc
            // 
            this.kullaniciaditc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciaditc.Location = new System.Drawing.Point(207, 138);
            this.kullaniciaditc.Name = "kullaniciaditc";
            this.kullaniciaditc.Size = new System.Drawing.Size(262, 30);
            this.kullaniciaditc.TabIndex = 2;
            // 
            // sifretc
            // 
            this.sifretc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifretc.Location = new System.Drawing.Point(207, 202);
            this.sifretc.Name = "sifretc";
            this.sifretc.PasswordChar = '*';
            this.sifretc.Size = new System.Drawing.Size(262, 30);
            this.sifretc.TabIndex = 3;
            // 
            // giris
            // 
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.Location = new System.Drawing.Point(282, 258);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(106, 38);
            this.giris.TabIndex = 4;
            this.giris.Text = "Giriş";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // FrmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.sifretc);
            this.Controls.Add(this.kullaniciaditc);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciadi);
            this.Name = "FrmTeacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.FrmTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciadi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox kullaniciaditc;
        private System.Windows.Forms.TextBox sifretc;
        private System.Windows.Forms.Button giris;
    }
}