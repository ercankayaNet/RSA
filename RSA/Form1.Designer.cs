namespace RSA
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnGizliAnahtarUret = new System.Windows.Forms.Button();
            this.rtbGizli = new System.Windows.Forms.RichTextBox();
            this.rtbSayi1 = new System.Windows.Forms.RichTextBox();
            this.rtbSayi2 = new System.Windows.Forms.RichTextBox();
            this.rtbE = new System.Windows.Forms.RichTextBox();
            this.lbAcıkAnahtarSinir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSifreleDesifrele = new System.Windows.Forms.Button();
            this.rtbAnahtar = new System.Windows.Forms.RichTextBox();
            this.rtbNsayisi = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFiN = new System.Windows.Forms.Label();
            this.lbAnahtar = new System.Windows.Forms.Label();
            this.rtbMetin = new System.Windows.Forms.RichTextBox();
            this.lbN = new System.Windows.Forms.Label();
            this.lbMetin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbOlusanMetin = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "2 Asal Sayı Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Açık Anahtar (E) Belirleyiniz. Fi(N) ile aralarında asal olmalı.";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Location = new System.Drawing.Point(304, 151);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 35);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnGizliAnahtarUret
            // 
            this.btnGizliAnahtarUret.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnGizliAnahtarUret.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGizliAnahtarUret.Location = new System.Drawing.Point(278, 312);
            this.btnGizliAnahtarUret.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGizliAnahtarUret.Name = "btnGizliAnahtarUret";
            this.btnGizliAnahtarUret.Size = new System.Drawing.Size(151, 34);
            this.btnGizliAnahtarUret.TabIndex = 8;
            this.btnGizliAnahtarUret.Text = "Gizli Anahtar Üret";
            this.btnGizliAnahtarUret.UseVisualStyleBackColor = false;
            this.btnGizliAnahtarUret.Click += new System.EventHandler(this.btnGizliAnahtarUret_Click);
            // 
            // rtbGizli
            // 
            this.rtbGizli.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbGizli.Location = new System.Drawing.Point(38, 353);
            this.rtbGizli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbGizli.Name = "rtbGizli";
            this.rtbGizli.Size = new System.Drawing.Size(602, 112);
            this.rtbGizli.TabIndex = 10;
            this.rtbGizli.Text = "";
            this.rtbGizli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbGizli_KeyPress);
            // 
            // rtbSayi1
            // 
            this.rtbSayi1.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbSayi1.Location = new System.Drawing.Point(98, 72);
            this.rtbSayi1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbSayi1.Name = "rtbSayi1";
            this.rtbSayi1.Size = new System.Drawing.Size(550, 29);
            this.rtbSayi1.TabIndex = 11;
            this.rtbSayi1.Text = "";
            this.rtbSayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbSayi1_KeyPress);
            // 
            // rtbSayi2
            // 
            this.rtbSayi2.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbSayi2.Location = new System.Drawing.Point(98, 115);
            this.rtbSayi2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbSayi2.Name = "rtbSayi2";
            this.rtbSayi2.Size = new System.Drawing.Size(550, 29);
            this.rtbSayi2.TabIndex = 11;
            this.rtbSayi2.Text = "";
            this.rtbSayi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbSayi2_KeyPress);
            // 
            // rtbE
            // 
            this.rtbE.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbE.Location = new System.Drawing.Point(38, 272);
            this.rtbE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbE.Name = "rtbE";
            this.rtbE.Size = new System.Drawing.Size(602, 29);
            this.rtbE.TabIndex = 11;
            this.rtbE.Text = "";
            this.rtbE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbE_KeyPress);
            // 
            // lbAcıkAnahtarSinir
            // 
            this.lbAcıkAnahtarSinir.AutoSize = true;
            this.lbAcıkAnahtarSinir.Location = new System.Drawing.Point(33, 222);
            this.lbAcıkAnahtarSinir.Name = "lbAcıkAnahtarSinir";
            this.lbAcıkAnahtarSinir.Size = new System.Drawing.Size(0, 19);
            this.lbAcıkAnahtarSinir.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "1.Sayı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "2.Sayı";
            // 
            // btnSifreleDesifrele
            // 
            this.btnSifreleDesifrele.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSifreleDesifrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSifreleDesifrele.Location = new System.Drawing.Point(197, 288);
            this.btnSifreleDesifrele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSifreleDesifrele.Name = "btnSifreleDesifrele";
            this.btnSifreleDesifrele.Size = new System.Drawing.Size(154, 39);
            this.btnSifreleDesifrele.TabIndex = 12;
            this.btnSifreleDesifrele.Text = "Şifrele / Deşifrele";
            this.btnSifreleDesifrele.UseVisualStyleBackColor = false;
            this.btnSifreleDesifrele.Click += new System.EventHandler(this.btnSifreleDesifrele_Click);
            // 
            // rtbAnahtar
            // 
            this.rtbAnahtar.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbAnahtar.Location = new System.Drawing.Point(120, 45);
            this.rtbAnahtar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbAnahtar.Name = "rtbAnahtar";
            this.rtbAnahtar.Size = new System.Drawing.Size(332, 52);
            this.rtbAnahtar.TabIndex = 13;
            this.rtbAnahtar.Text = "";
            this.rtbAnahtar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbAnahtar_KeyPress);
            // 
            // rtbNsayisi
            // 
            this.rtbNsayisi.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbNsayisi.Location = new System.Drawing.Point(120, 105);
            this.rtbNsayisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbNsayisi.Name = "rtbNsayisi";
            this.rtbNsayisi.Size = new System.Drawing.Size(332, 55);
            this.rtbNsayisi.TabIndex = 13;
            this.rtbNsayisi.Text = "";
            this.rtbNsayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbNsayisi_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fi(N) = ";
            // 
            // lbFiN
            // 
            this.lbFiN.AutoSize = true;
            this.lbFiN.Location = new System.Drawing.Point(96, 250);
            this.lbFiN.Name = "lbFiN";
            this.lbFiN.Size = new System.Drawing.Size(0, 19);
            this.lbFiN.TabIndex = 16;
            // 
            // lbAnahtar
            // 
            this.lbAnahtar.AutoSize = true;
            this.lbAnahtar.Location = new System.Drawing.Point(19, 48);
            this.lbAnahtar.Name = "lbAnahtar";
            this.lbAnahtar.Size = new System.Drawing.Size(60, 19);
            this.lbAnahtar.TabIndex = 17;
            this.lbAnahtar.Text = "Anahtar";
            // 
            // rtbMetin
            // 
            this.rtbMetin.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbMetin.Location = new System.Drawing.Point(120, 168);
            this.rtbMetin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbMetin.Name = "rtbMetin";
            this.rtbMetin.Size = new System.Drawing.Size(332, 101);
            this.rtbMetin.TabIndex = 13;
            this.rtbMetin.Text = "";
            this.rtbMetin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbMetin_KeyPress);
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Location = new System.Drawing.Point(19, 108);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(60, 19);
            this.lbN.TabIndex = 17;
            this.lbN.Text = "N Sayısı";
            // 
            // lbMetin
            // 
            this.lbMetin.AutoSize = true;
            this.lbMetin.Location = new System.Drawing.Point(19, 172);
            this.lbMetin.Name = "lbMetin";
            this.lbMetin.Size = new System.Drawing.Size(47, 19);
            this.lbMetin.TabIndex = 17;
            this.lbMetin.Text = "Metin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Oluşan Metin";
            // 
            // rtbOlusanMetin
            // 
            this.rtbOlusanMetin.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbOlusanMetin.Location = new System.Drawing.Point(120, 353);
            this.rtbOlusanMetin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbOlusanMetin.Name = "rtbOlusanMetin";
            this.rtbOlusanMetin.Size = new System.Drawing.Size(332, 112);
            this.rtbOlusanMetin.TabIndex = 18;
            this.rtbOlusanMetin.Text = "";
            this.rtbOlusanMetin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbOlusanMetin_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbAcıkAnahtarSinir);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.lbFiN);
            this.groupBox1.Controls.Add(this.btnGizliAnahtarUret);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rtbGizli);
            this.groupBox1.Controls.Add(this.rtbSayi1);
            this.groupBox1.Controls.Add(this.rtbSayi2);
            this.groupBox1.Controls.Add(this.rtbE);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(681, 492);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anahtar Üretimi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbAnahtar);
            this.groupBox2.Controls.Add(this.btnSifreleDesifrele);
            this.groupBox2.Controls.Add(this.rtbOlusanMetin);
            this.groupBox2.Controls.Add(this.rtbNsayisi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rtbMetin);
            this.groupBox2.Controls.Add(this.lbMetin);
            this.groupBox2.Controls.Add(this.lbAnahtar);
            this.groupBox2.Controls.Add(this.lbN);
            this.groupBox2.Location = new System.Drawing.Point(713, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(494, 492);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifreleme / Deşifreleme";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1115, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ercan KAYA";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1215, 531);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnGizliAnahtarUret;
        private System.Windows.Forms.RichTextBox rtbGizli;
        private System.Windows.Forms.RichTextBox rtbSayi1;
        private System.Windows.Forms.RichTextBox rtbSayi2;
        private System.Windows.Forms.RichTextBox rtbE;
        private System.Windows.Forms.Label lbAcıkAnahtarSinir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSifreleDesifrele;
        private System.Windows.Forms.RichTextBox rtbAnahtar;
        private System.Windows.Forms.RichTextBox rtbNsayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbFiN;
        private System.Windows.Forms.Label lbAnahtar;
        private System.Windows.Forms.RichTextBox rtbMetin;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbMetin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbOlusanMetin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
    }
}

