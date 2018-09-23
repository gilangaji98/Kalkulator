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
            this.NamaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nilaiA = new System.Windows.Forms.Label();
            this.nilaiB = new System.Windows.Forms.Label();
            this.NamaText1 = new System.Windows.Forms.TextBox();
            this.NamaText2 = new System.Windows.Forms.TextBox();
            this.btn_Hitung = new System.Windows.Forms.Button();
            this.hasil = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NamaComboBox
            // 
            this.NamaComboBox.FormattingEnabled = true;
            this.NamaComboBox.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.NamaComboBox.Location = new System.Drawing.Point(93, 12);
            this.NamaComboBox.Name = "NamaComboBox";
            this.NamaComboBox.Size = new System.Drawing.Size(91, 21);
            this.NamaComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operasi";
            // 
            // nilaiA
            // 
            this.nilaiA.AutoSize = true;
            this.nilaiA.Location = new System.Drawing.Point(16, 62);
            this.nilaiA.Name = "nilaiA";
            this.nilaiA.Size = new System.Drawing.Size(37, 13);
            this.nilaiA.TabIndex = 2;
            this.nilaiA.Text = "Nilai A";
            // 
            // nilaiB
            // 
            this.nilaiB.AutoSize = true;
            this.nilaiB.Location = new System.Drawing.Point(16, 99);
            this.nilaiB.Name = "nilaiB";
            this.nilaiB.Size = new System.Drawing.Size(37, 13);
            this.nilaiB.TabIndex = 3;
            this.nilaiB.Text = "Nilai B";
            // 
            // NamaText1
            // 
            this.NamaText1.Location = new System.Drawing.Point(92, 62);
            this.NamaText1.Name = "NamaText1";
            this.NamaText1.Size = new System.Drawing.Size(91, 20);
            this.NamaText1.TabIndex = 4;
            // 
            // NamaText2
            // 
            this.NamaText2.Location = new System.Drawing.Point(92, 96);
            this.NamaText2.Name = "NamaText2";
            this.NamaText2.Size = new System.Drawing.Size(91, 20);
            this.NamaText2.TabIndex = 5;
            // 
            // btn_Hitung
            // 
            this.btn_Hitung.Location = new System.Drawing.Point(108, 173);
            this.btn_Hitung.Name = "btn_Hitung";
            this.btn_Hitung.Size = new System.Drawing.Size(75, 23);
            this.btn_Hitung.TabIndex = 6;
            this.btn_Hitung.Text = "Hitung";
            this.btn_Hitung.UseVisualStyleBackColor = true;
            this.btn_Hitung.Click += new System.EventHandler(this.btn_Hitung_Click);
            // 
            // hasil
            // 
            this.hasil.AutoSize = true;
            this.hasil.Location = new System.Drawing.Point(17, 134);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(30, 13);
            this.hasil.TabIndex = 7;
            this.hasil.Text = "Hasil";
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(92, 130);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(92, 20);
            this.txtHasil.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 215);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.btn_Hitung);
            this.Controls.Add(this.NamaText2);
            this.Controls.Add(this.NamaText1);
            this.Controls.Add(this.nilaiB);
            this.Controls.Add(this.nilaiA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NamaComboBox);
            this.Name = "Form1";
            this.Text = "Aplikasi Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NamaComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nilaiA;
        private System.Windows.Forms.Label nilaiB;
        private System.Windows.Forms.TextBox NamaText1;
        private System.Windows.Forms.TextBox NamaText2;
        private System.Windows.Forms.Button btn_Hitung;
        private System.Windows.Forms.Label hasil;
        private System.Windows.Forms.TextBox txtHasil;
    }
}

