namespace MyHamburgercim
{
    partial class SiparisOlustur
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
            this.cmBoxMenu = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonBuyuk = new System.Windows.Forms.RadioButton();
            this.radioButtonOrta = new System.Windows.Forms.RadioButton();
            this.radioButtonKucuk = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.listBoxSepet = new System.Windows.Forms.ListBox();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Seçin";
            // 
            // cmBoxMenu
            // 
            this.cmBoxMenu.FormattingEnabled = true;
            this.cmBoxMenu.Location = new System.Drawing.Point(28, 46);
            this.cmBoxMenu.Name = "cmBoxMenu";
            this.cmBoxMenu.Size = new System.Drawing.Size(251, 29);
            this.cmBoxMenu.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonBuyuk);
            this.groupBox1.Controls.Add(this.radioButtonOrta);
            this.groupBox1.Controls.Add(this.radioButtonKucuk);
            this.groupBox1.Location = new System.Drawing.Point(28, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boyut Seçin";
            // 
            // radioButtonBuyuk
            // 
            this.radioButtonBuyuk.AutoSize = true;
            this.radioButtonBuyuk.Location = new System.Drawing.Point(159, 38);
            this.radioButtonBuyuk.Name = "radioButtonBuyuk";
            this.radioButtonBuyuk.Size = new System.Drawing.Size(71, 25);
            this.radioButtonBuyuk.TabIndex = 5;
            this.radioButtonBuyuk.TabStop = true;
            this.radioButtonBuyuk.Text = "Büyük";
            this.radioButtonBuyuk.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrta
            // 
            this.radioButtonOrta.AutoSize = true;
            this.radioButtonOrta.Location = new System.Drawing.Point(94, 38);
            this.radioButtonOrta.Name = "radioButtonOrta";
            this.radioButtonOrta.Size = new System.Drawing.Size(59, 25);
            this.radioButtonOrta.TabIndex = 4;
            this.radioButtonOrta.TabStop = true;
            this.radioButtonOrta.Text = "Orta";
            this.radioButtonOrta.UseVisualStyleBackColor = true;
            // 
            // radioButtonKucuk
            // 
            this.radioButtonKucuk.AutoSize = true;
            this.radioButtonKucuk.Checked = true;
            this.radioButtonKucuk.Location = new System.Drawing.Point(18, 38);
            this.radioButtonKucuk.Name = "radioButtonKucuk";
            this.radioButtonKucuk.Size = new System.Drawing.Size(70, 25);
            this.radioButtonKucuk.TabIndex = 3;
            this.radioButtonKucuk.TabStop = true;
            this.radioButtonKucuk.Text = "Küçük";
            this.radioButtonKucuk.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 187);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(251, 100);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adet : ";
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Location = new System.Drawing.Point(137, 312);
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(75, 29);
            this.numericUpDownAdet.TabIndex = 5;
            this.numericUpDownAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(28, 416);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(251, 40);
            this.btnSiparisEkle.TabIndex = 6;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // listBoxSepet
            // 
            this.listBoxSepet.FormattingEnabled = true;
            this.listBoxSepet.ItemHeight = 21;
            this.listBoxSepet.Location = new System.Drawing.Point(285, 12);
            this.listBoxSepet.Name = "listBoxSepet";
            this.listBoxSepet.Size = new System.Drawing.Size(519, 277);
            this.listBoxSepet.TabIndex = 7;
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(398, 306);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(100, 29);
            this.txtToplamFiyat.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Toplam Fiyat : ";
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(553, 295);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(251, 40);
            this.btnSiparisiTamamla.TabIndex = 13;
            this.btnSiparisiTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            // 
            // SiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 468);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.txtToplamFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxSepet);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.numericUpDownAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmBoxMenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SiparisOlustur";
            this.Text = "SiparisOlustur";
            this.Load += new System.EventHandler(this.SiparisOlustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBoxMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonBuyuk;
        private System.Windows.Forms.RadioButton radioButtonOrta;
        private System.Windows.Forms.RadioButton radioButtonKucuk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.ListBox listBoxSepet;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiparisiTamamla;
    }
}