namespace sayitahmin_v2
{
    partial class FrmOyun
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
            components = new System.ComponentModel.Container();
            cmbBasamak = new ComboBox();
            btnBasla = new Button();
            lblDurum = new Label();
            txtTahmin = new TextBox();
            btnTahmin = new Button();
            lblPuan = new Label();
            lblSure = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            flowGecmis = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            button1 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btnSil = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            lstSkorlar = new ListBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbBasamak
            // 
            cmbBasamak.FormattingEnabled = true;
            cmbBasamak.Items.AddRange(new object[] { "3", "4", "5" });
            cmbBasamak.Location = new Point(270, 64);
            cmbBasamak.Margin = new Padding(3, 4, 3, 4);
            cmbBasamak.Name = "cmbBasamak";
            cmbBasamak.Size = new Size(138, 28);
            cmbBasamak.TabIndex = 0;
            cmbBasamak.Text = "Seçiniz";
            // 
            // btnBasla
            // 
            btnBasla.Location = new Point(451, 64);
            btnBasla.Margin = new Padding(3, 4, 3, 4);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(176, 31);
            btnBasla.TabIndex = 1;
            btnBasla.Text = "Oyunu Başlat";
            btnBasla.UseVisualStyleBackColor = true;
            btnBasla.Click += btnBasla_Click;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.BackColor = Color.White;
            lblDurum.Location = new Point(42, 174);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(134, 20);
            lblDurum.TabIndex = 2;
            lblDurum.Text = "KALAN HAKKINIZ :";
            // 
            // txtTahmin
            // 
            txtTahmin.Location = new Point(231, 171);
            txtTahmin.Margin = new Padding(3, 4, 3, 4);
            txtTahmin.MaxLength = 3;
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(255, 27);
            txtTahmin.TabIndex = 3;
            // 
            // btnTahmin
            // 
            btnTahmin.Location = new Point(505, 174);
            btnTahmin.Margin = new Padding(3, 4, 3, 4);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(136, 119);
            btnTahmin.TabIndex = 4;
            btnTahmin.Text = "Tahmin Et";
            btnTahmin.UseVisualStyleBackColor = true;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // lblPuan
            // 
            lblPuan.AutoSize = true;
            lblPuan.BackColor = Color.White;
            lblPuan.Location = new Point(805, 111);
            lblPuan.Name = "lblPuan";
            lblPuan.Size = new Size(99, 20);
            lblPuan.TabIndex = 5;
            lblPuan.Text = "Puanınız : 100";
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.BackColor = Color.White;
            lblSure.Location = new Point(805, 151);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(17, 20);
            lblSure.TabIndex = 6;
            lblSure.Text = "0";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // flowGecmis
            // 
            flowGecmis.AutoScroll = true;
            flowGecmis.Location = new Point(58, 252);
            flowGecmis.Margin = new Padding(3, 4, 3, 4);
            flowGecmis.Name = "flowGecmis";
            flowGecmis.Size = new Size(417, 312);
            flowGecmis.TabIndex = 7;
            flowGecmis.Paint += flowGecmis_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btn0);
            groupBox1.Controls.Add(btn9);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btn8);
            groupBox1.Controls.Add(btn7);
            groupBox1.Controls.Add(btn6);
            groupBox1.Controls.Add(btn5);
            groupBox1.Controls.Add(btn4);
            groupBox1.Controls.Add(btn3);
            groupBox1.Controls.Add(btn2);
            groupBox1.Controls.Add(btn1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(635, 402);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(435, 297);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tuş Takımı";
            // 
            // button1
            // 
            button1.Location = new Point(306, 222);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 12;
            button1.Text = "Tahmin Et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(170, 222);
            btn0.Margin = new Padding(3, 4, 3, 4);
            btn0.Name = "btn0";
            btn0.Size = new Size(86, 31);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += RakamButon_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(306, 164);
            btn9.Margin = new Padding(3, 4, 3, 4);
            btn9.Name = "btn9";
            btn9.Size = new Size(86, 31);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += RakamButon_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(46, 222);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(86, 31);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click_1;
            // 
            // btn8
            // 
            btn8.Location = new Point(170, 164);
            btn8.Margin = new Padding(3, 4, 3, 4);
            btn8.Name = "btn8";
            btn8.Size = new Size(86, 31);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += RakamButon_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(46, 164);
            btn7.Margin = new Padding(3, 4, 3, 4);
            btn7.Name = "btn7";
            btn7.Size = new Size(86, 31);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += RakamButon_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(306, 105);
            btn6.Margin = new Padding(3, 4, 3, 4);
            btn6.Name = "btn6";
            btn6.Size = new Size(86, 31);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += RakamButon_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(170, 105);
            btn5.Margin = new Padding(3, 4, 3, 4);
            btn5.Name = "btn5";
            btn5.Size = new Size(86, 31);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += RakamButon_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(46, 105);
            btn4.Margin = new Padding(3, 4, 3, 4);
            btn4.Name = "btn4";
            btn4.Size = new Size(86, 31);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += RakamButon_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(306, 47);
            btn3.Margin = new Padding(3, 4, 3, 4);
            btn3.Name = "btn3";
            btn3.Size = new Size(86, 31);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += RakamButon_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(170, 47);
            btn2.Margin = new Padding(3, 4, 3, 4);
            btn2.Name = "btn2";
            btn2.Size = new Size(86, 31);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += RakamButon_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(46, 47);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(86, 31);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += RakamButon_Click;
            // 
            // lstSkorlar
            // 
            lstSkorlar.FormattingEnabled = true;
            lstSkorlar.Location = new Point(928, 88);
            lstSkorlar.Margin = new Padding(3, 4, 3, 4);
            lstSkorlar.Name = "lstSkorlar";
            lstSkorlar.Size = new Size(267, 224);
            lstSkorlar.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(929, 64);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 11;
            label1.Text = "EN İYİ 5 OYUNCU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(42, 64);
            label2.Name = "label2";
            label2.Size = new Size(194, 20);
            label2.TabIndex = 10;
            label2.Text = "Oyun Kaç Basamaklı Olsun ?";
            // 
            // FrmOyun
            // 
            AcceptButton = btnTahmin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1338, 1055);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstSkorlar);
            Controls.Add(groupBox1);
            Controls.Add(flowGecmis);
            Controls.Add(lblSure);
            Controls.Add(lblPuan);
            Controls.Add(btnTahmin);
            Controls.Add(txtTahmin);
            Controls.Add(lblDurum);
            Controls.Add(btnBasla);
            Controls.Add(cmbBasamak);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmOyun";
            Text = "FrmOyun";
            Load += FrmOyun_Load;
            Click += FrmOyun_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBasamak;
        private Button btnBasla;
        private Label lblDurum;
        private TextBox txtTahmin;
        private Button btnTahmin;
        private Label lblPuan;
        private Label lblSure;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flowGecmis;
        private GroupBox groupBox1;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnSil;
        private ListBox lstSkorlar;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}