namespace Deneme1
{
    partial class FrmAdmin
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
            this.kullaniciadiad = new System.Windows.Forms.TextBox();
            this.sifread = new System.Windows.Forms.TextBox();
            this.giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AutoSize = true;
            this.kullaniciadi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadi.Location = new System.Drawing.Point(65, 115);
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
            this.sifre.Location = new System.Drawing.Point(140, 191);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(57, 25);
            this.sifre.TabIndex = 1;
            this.sifre.Text = "Şifre";
            // 
            // kullaniciadiad
            // 
            this.kullaniciadiad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadiad.Location = new System.Drawing.Point(203, 115);
            this.kullaniciadiad.Name = "kullaniciadiad";
            this.kullaniciadiad.Size = new System.Drawing.Size(219, 30);
            this.kullaniciadiad.TabIndex = 2;
            // 
            // sifread
            // 
            this.sifread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifread.Location = new System.Drawing.Point(203, 191);
            this.sifread.Name = "sifread";
            this.sifread.PasswordChar = '*';
            this.sifread.Size = new System.Drawing.Size(219, 30);
            this.sifread.TabIndex = 3;
            // 
            // giris
            // 
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.Location = new System.Drawing.Point(265, 237);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(81, 36);
            this.giris.TabIndex = 4;
            this.giris.Text = "Giriş";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.sifread);
            this.Controls.Add(this.kullaniciadiad);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciadi);
            this.Name = "FrmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciadi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox kullaniciadiad;
        private System.Windows.Forms.TextBox sifread;
        private System.Windows.Forms.Button giris;
    }
}