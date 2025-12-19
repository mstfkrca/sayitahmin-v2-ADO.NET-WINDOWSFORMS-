namespace sayitahmin_v2
{
    partial class FrmKayit
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            txtTelefon = new TextBox();
            txtEposta = new TextBox();
            btnKayitOl = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(296, 42);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(296, 91);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(296, 140);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(296, 187);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(296, 234);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 4;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(296, 281);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(125, 27);
            txtEposta.TabIndex = 5;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(504, 155);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(94, 29);
            btnKayitOl.TabIndex = 6;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 49);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 7;
            label1.Text = "AD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 98);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 8;
            label2.Text = "SOYAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 147);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 9;
            label3.Text = "KULLANICI ADI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 194);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 10;
            label4.Text = "ŞİFRE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 241);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 11;
            label5.Text = "TELEFON";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(155, 288);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 12;
            label6.Text = "EPOSTA";
            // 
            // FrmKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 679);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKayitOl);
            Controls.Add(txtEposta);
            Controls.Add(txtTelefon);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "FrmKayit";
            Text = "FrmKayit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private TextBox txtTelefon;
        private TextBox txtEposta;
        private Button btnKayitOl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}