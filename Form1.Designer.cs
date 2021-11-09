namespace ClientProxyForm_P5_20190140015
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
            this.label1 = new System.Windows.Forms.Label();
            this.angkainput1 = new System.Windows.Forms.TextBox();
            this.angkainput2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHasil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.jumlah = new System.Windows.Forms.Label();
            this.kurang = new System.Windows.Forms.Label();
            this.kali = new System.Windows.Forms.Label();
            this.bagi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka 1";
            // 
            // angkainput1
            // 
            this.angkainput1.Location = new System.Drawing.Point(139, 80);
            this.angkainput1.Name = "angkainput1";
            this.angkainput1.Size = new System.Drawing.Size(144, 20);
            this.angkainput1.TabIndex = 1;
            // 
            // angkainput2
            // 
            this.angkainput2.Location = new System.Drawing.Point(139, 117);
            this.angkainput2.Name = "angkainput2";
            this.angkainput2.Size = new System.Drawing.Size(144, 20);
            this.angkainput2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Angka 2";
            // 
            // btnHasil
            // 
            this.btnHasil.Location = new System.Drawing.Point(175, 166);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(75, 23);
            this.btnHasil.TabIndex = 5;
            this.btnHasil.Text = "Hasil";
            this.btnHasil.UseVisualStyleBackColor = true;
            this.btnHasil.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasil Pembagian :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasil Perkalian :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hasil Pengurangan :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hasil Penjumlahan :";
            // 
            // jumlah
            // 
            this.jumlah.AutoSize = true;
            this.jumlah.Location = new System.Drawing.Point(516, 80);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(0, 13);
            this.jumlah.TabIndex = 10;
            // 
            // kurang
            // 
            this.kurang.AutoSize = true;
            this.kurang.Location = new System.Drawing.Point(516, 102);
            this.kurang.Name = "kurang";
            this.kurang.Size = new System.Drawing.Size(0, 13);
            this.kurang.TabIndex = 11;
            // 
            // kali
            // 
            this.kali.AutoSize = true;
            this.kali.Location = new System.Drawing.Point(516, 124);
            this.kali.Name = "kali";
            this.kali.Size = new System.Drawing.Size(0, 13);
            this.kali.TabIndex = 12;
            // 
            // bagi
            // 
            this.bagi.AutoSize = true;
            this.bagi.Location = new System.Drawing.Point(516, 145);
            this.bagi.Name = "bagi";
            this.bagi.Size = new System.Drawing.Size(0, 13);
            this.bagi.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 310);
            this.Controls.Add(this.bagi);
            this.Controls.Add(this.kali);
            this.Controls.Add(this.kurang);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHasil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.angkainput2);
            this.Controls.Add(this.angkainput1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox angkainput1;
        private System.Windows.Forms.TextBox angkainput2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHasil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label jumlah;
        private System.Windows.Forms.Label kurang;
        private System.Windows.Forms.Label kali;
        private System.Windows.Forms.Label bagi;
    }
}

