namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Operasi = new System.Windows.Forms.Label();
            this.NilaiA = new System.Windows.Forms.Label();
            this.NilaiB = new System.Windows.Forms.Label();
            this.Hasil = new System.Windows.Forms.Label();
            this.operasiHitung = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonhitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Operasi
            // 
            this.Operasi.AutoSize = true;
            this.Operasi.Location = new System.Drawing.Point(12, 29);
            this.Operasi.Name = "Operasi";
            this.Operasi.Size = new System.Drawing.Size(43, 13);
            this.Operasi.TabIndex = 0;
            this.Operasi.Text = "Operasi";
            this.Operasi.Click += new System.EventHandler(this.label1_Click);
            // 
            // NilaiA
            // 
            this.NilaiA.AutoSize = true;
            this.NilaiA.Location = new System.Drawing.Point(12, 58);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(37, 13);
            this.NilaiA.TabIndex = 1;
            this.NilaiA.Text = "Nilai A";
            // 
            // NilaiB
            // 
            this.NilaiB.AutoSize = true;
            this.NilaiB.Location = new System.Drawing.Point(12, 97);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(37, 13);
            this.NilaiB.TabIndex = 2;
            this.NilaiB.Text = "Nilai B";
            // 
            // Hasil
            // 
            this.Hasil.AutoSize = true;
            this.Hasil.Location = new System.Drawing.Point(12, 127);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(30, 13);
            this.Hasil.TabIndex = 3;
            this.Hasil.Text = "Hasil";
            this.Hasil.Click += new System.EventHandler(this.Hasil_Click);
            // 
            // operasiHitung
            // 
            this.operasiHitung.FormattingEnabled = true;
            this.operasiHitung.Location = new System.Drawing.Point(80, 29);
            this.operasiHitung.Name = "operasiHitung";
            this.operasiHitung.Size = new System.Drawing.Size(149, 21);
            this.operasiHitung.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonhitung
            // 
            this.buttonhitung.Location = new System.Drawing.Point(109, 174);
            this.buttonhitung.Name = "buttonhitung";
            this.buttonhitung.Size = new System.Drawing.Size(75, 23);
            this.buttonhitung.TabIndex = 8;
            this.buttonhitung.Text = "Hitung";
            this.buttonhitung.UseVisualStyleBackColor = true;
            this.buttonhitung.Click += new System.EventHandler(this.buttonhitung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonhitung);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.operasiHitung);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.Operasi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Operasi;
        private System.Windows.Forms.Label NilaiA;
        private System.Windows.Forms.Label NilaiB;
        private System.Windows.Forms.Label Hasil;
        private System.Windows.Forms.ComboBox operasiHitung;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonhitung;
    }
}

