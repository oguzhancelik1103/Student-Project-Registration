using System;

namespace Deneme1
{
    partial class FrmStudent
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
            this.kullaniciaditxt = new System.Windows.Forms.TextBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AutoSize = true;
            this.kullaniciadi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadi.Location = new System.Drawing.Point(66, 109);
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
            this.sifre.Location = new System.Drawing.Point(141, 180);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(57, 25);
            this.sifre.TabIndex = 1;
            this.sifre.Text = "Şifre";
            // 
            // kullaniciaditxt
            // 
            this.kullaniciaditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciaditxt.Location = new System.Drawing.Point(208, 109);
            this.kullaniciaditxt.Name = "kullaniciaditxt";
            this.kullaniciaditxt.Size = new System.Drawing.Size(244, 30);
            this.kullaniciaditxt.TabIndex = 2;
            // 
            // sifretxt
            // 
            this.sifretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifretxt.Location = new System.Drawing.Point(208, 180);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.PasswordChar = '*';
            this.sifretxt.Size = new System.Drawing.Size(244, 30);
            this.sifretxt.TabIndex = 3;
            // 
            // giris
            // 
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.Location = new System.Drawing.Point(281, 228);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(90, 38);
            this.giris.TabIndex = 4;
            this.giris.Text = "Giriş";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kullaniciaditxt);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciadi);
            this.Name = "FrmStudent";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciadi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox kullaniciaditxt;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Button giris;
    }
}