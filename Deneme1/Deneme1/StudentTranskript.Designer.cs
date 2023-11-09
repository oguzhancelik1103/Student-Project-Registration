namespace Deneme1
{
    partial class StudentTranskript
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.transkriptyukle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(80, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(529, 278);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // transkriptyukle
            // 
            this.transkriptyukle.Location = new System.Drawing.Point(80, 79);
            this.transkriptyukle.Name = "transkriptyukle";
            this.transkriptyukle.Size = new System.Drawing.Size(163, 29);
            this.transkriptyukle.TabIndex = 2;
            this.transkriptyukle.Text = "Transkript Yükle";
            this.transkriptyukle.UseVisualStyleBackColor = true;
            this.transkriptyukle.Click += new System.EventHandler(this.transkriptyukle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // StudentTranskript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transkriptyukle);
            this.Controls.Add(this.richTextBox1);
            this.Name = "StudentTranskript";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.StudentTranskript_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button transkriptyukle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}