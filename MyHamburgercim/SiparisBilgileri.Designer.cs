namespace MyHamburgercim
{
    partial class SiparisBilgileri
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
            this.lsBoxTumSiparisler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.lblToplamSiparisSayisi = new System.Windows.Forms.Label();
            this.lblExtraMalzemeGeliri = new System.Windows.Forms.Label();
            this.lblSatilanUrunAdedi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tüm Siparişler";
            // 
            // lsBoxTumSiparisler
            // 
            this.lsBoxTumSiparisler.FormattingEnabled = true;
            this.lsBoxTumSiparisler.ItemHeight = 21;
            this.lsBoxTumSiparisler.Location = new System.Drawing.Point(16, 33);
            this.lsBoxTumSiparisler.Name = "lsBoxTumSiparisler";
            this.lsBoxTumSiparisler.Size = new System.Drawing.Size(582, 403);
            this.lsBoxTumSiparisler.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCiro);
            this.groupBox1.Location = new System.Drawing.Point(620, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplamSiparisSayisi);
            this.groupBox2.Location = new System.Drawing.Point(620, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam Sipariş Sayısı";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblExtraMalzemeGeliri);
            this.groupBox3.Location = new System.Drawing.Point(620, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extra Malzeme Geliri";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSatilanUrunAdedi);
            this.groupBox4.Location = new System.Drawing.Point(620, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 90);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Satılan Ürün Adedi";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Location = new System.Drawing.Point(27, 41);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(0, 21);
            this.lblCiro.TabIndex = 0;
            // 
            // lblToplamSiparisSayisi
            // 
            this.lblToplamSiparisSayisi.AutoSize = true;
            this.lblToplamSiparisSayisi.Location = new System.Drawing.Point(27, 44);
            this.lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            this.lblToplamSiparisSayisi.Size = new System.Drawing.Size(0, 21);
            this.lblToplamSiparisSayisi.TabIndex = 1;
            // 
            // lblExtraMalzemeGeliri
            // 
            this.lblExtraMalzemeGeliri.AutoSize = true;
            this.lblExtraMalzemeGeliri.Location = new System.Drawing.Point(27, 40);
            this.lblExtraMalzemeGeliri.Name = "lblExtraMalzemeGeliri";
            this.lblExtraMalzemeGeliri.Size = new System.Drawing.Size(0, 21);
            this.lblExtraMalzemeGeliri.TabIndex = 2;
            // 
            // lblSatilanUrunAdedi
            // 
            this.lblSatilanUrunAdedi.AutoSize = true;
            this.lblSatilanUrunAdedi.Location = new System.Drawing.Point(27, 41);
            this.lblSatilanUrunAdedi.Name = "lblSatilanUrunAdedi";
            this.lblSatilanUrunAdedi.Size = new System.Drawing.Size(0, 21);
            this.lblSatilanUrunAdedi.TabIndex = 3;
            // 
            // SiparisBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 468);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsBoxTumSiparisler);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SiparisBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisBilgileri";
            this.Load += new System.EventHandler(this.SiparisBilgileri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsBoxTumSiparisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToplamSiparisSayisi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblExtraMalzemeGeliri;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSatilanUrunAdedi;
    }
}