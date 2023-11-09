namespace Deneme1
{
    partial class Teacher
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
            this.tc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cikis = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.kriter = new System.Windows.Forms.TextBox();
            this.kontenjan = new System.Windows.Forms.TextBox();
            this.sicil = new System.Windows.Forms.TextBox();
            this.ders = new System.Windows.Forms.TextBox();
            this.alan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc.Location = new System.Drawing.Point(437, 31);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(107, 25);
            this.tc.TabIndex = 0;
            this.tc.Text = "Öğretmen";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.cikis);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 374);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // cikis
            // 
            this.cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.Location = new System.Drawing.Point(6, 339);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(188, 29);
            this.cikis.TabIndex = 3;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(6, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Mesajlar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(6, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ders Kayıt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(6, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kişisel Bilgiler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.kaydet);
            this.groupBox2.Controls.Add(this.guncelle);
            this.groupBox2.Controls.Add(this.kriter);
            this.groupBox2.Controls.Add(this.tc);
            this.groupBox2.Controls.Add(this.kontenjan);
            this.groupBox2.Controls.Add(this.sicil);
            this.groupBox2.Controls.Add(this.ders);
            this.groupBox2.Controls.Add(this.alan);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.soyad);
            this.groupBox2.Controls.Add(this.ad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(256, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 374);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişisel Bilgiler";
            // 
            // kaydet
            // 
            this.kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet.Location = new System.Drawing.Point(359, 339);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(99, 29);
            this.kaydet.TabIndex = 15;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // guncelle
            // 
            this.guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.Location = new System.Drawing.Point(464, 339);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(99, 29);
            this.guncelle.TabIndex = 14;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // kriter
            // 
            this.kriter.Location = new System.Drawing.Point(135, 298);
            this.kriter.Name = "kriter";
            this.kriter.Size = new System.Drawing.Size(261, 27);
            this.kriter.TabIndex = 13;
            // 
            // kontenjan
            // 
            this.kontenjan.Location = new System.Drawing.Point(135, 249);
            this.kontenjan.Name = "kontenjan";
            this.kontenjan.Size = new System.Drawing.Size(261, 27);
            this.kontenjan.TabIndex = 12;
            // 
            // sicil
            // 
            this.sicil.Location = new System.Drawing.Point(135, 111);
            this.sicil.Name = "sicil";
            this.sicil.Size = new System.Drawing.Size(261, 27);
            this.sicil.TabIndex = 11;
            // 
            // ders
            // 
            this.ders.Location = new System.Drawing.Point(135, 201);
            this.ders.Name = "ders";
            this.ders.Size = new System.Drawing.Size(261, 27);
            this.ders.TabIndex = 10;
            // 
            // alan
            // 
            this.alan.Location = new System.Drawing.Point(135, 156);
            this.alan.Name = "alan";
            this.alan.Size = new System.Drawing.Size(261, 27);
            this.alan.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(19, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kriter Dersler :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kontenjan Bilgisi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Açılan Dersler :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "İlgi Alanları :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sicil Numarası : ";
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(135, 72);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(261, 27);
            this.soyad.TabIndex = 3;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(135, 31);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(261, 27);
            this.ad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kriter;
        private System.Windows.Forms.TextBox kontenjan;
        private System.Windows.Forms.TextBox sicil;
        private System.Windows.Forms.TextBox ders;
        private System.Windows.Forms.TextBox alan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button kaydet;
    }
}