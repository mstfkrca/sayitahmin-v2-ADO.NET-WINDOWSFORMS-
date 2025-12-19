namespace FrmOyun
{
    partial class FrmOyun
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            SuspendLayout();
            // 
            // cmbBasamak
            // 
            cmbBasamak.FormattingEnabled = true;
            cmbBasamak.Items.AddRange(new object[] { "3", "4", "5" });
            cmbBasamak.Location = new Point(92, 71);
            cmbBasamak.Name = "cmbBasamak";
            cmbBasamak.Size = new Size(121, 23);
            cmbBasamak.TabIndex = 0;
            cmbBasamak.Text = "3";
            cmbBasamak.SelectedIndexChanged += cmbBasamak_SelectedIndexChanged;
            // 
            // btnBasla
            // 
            btnBasla.Location = new Point(385, 71);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(174, 23);
            btnBasla.TabIndex = 1;
            btnBasla.Text = "Oyunu Başlat";
            btnBasla.UseVisualStyleBackColor = true;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(265, 178);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(16, 15);
            lblDurum.TabIndex = 2;
            lblDurum.Text = "...";
            // 
            // txtTahmin
            // 
            txtTahmin.Location = new Point(199, 361);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(100, 23);
            txtTahmin.TabIndex = 3;
            // 
            // btnTahmin
            // 
            btnTahmin.Enabled = false;
            btnTahmin.Location = new Point(599, 370);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(123, 23);
            btnTahmin.TabIndex = 4;
            btnTahmin.Text = "Tahmin Et";
            btnTahmin.UseVisualStyleBackColor = true;
            // 
            // lblPuan
            // 
            lblPuan.AutoSize = true;
            lblPuan.Location = new Point(761, 122);
            lblPuan.Name = "lblPuan";
            lblPuan.Size = new Size(58, 15);
            lblPuan.TabIndex = 5;
            lblPuan.Text = "Puan: 100";
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.Location = new Point(764, 145);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(13, 15);
            lblSure.TabIndex = 6;
            lblSure.Text = "0";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // FrmOyun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 707);
            Controls.Add(lblSure);
            Controls.Add(lblPuan);
            Controls.Add(btnTahmin);
            Controls.Add(txtTahmin);
            Controls.Add(lblDurum);
            Controls.Add(btnBasla);
            Controls.Add(cmbBasamak);
            Name = "FrmOyun";
            Text = "FrmOyun";
            Load += FrmOyun_Load;
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
    }
}
