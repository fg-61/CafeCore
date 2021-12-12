
namespace CafeCore.Forms
{
    partial class FrmKatEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKatEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.txtSiraNo = new System.Windows.Forms.TextBox();
            this.txtMasaSayisi = new System.Windows.Forms.TextBox();
            this.lstKat = new System.Windows.Forms.ListView();
            this.btnKattGeri = new ShapedButton.YuvarlakButon();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuncelle1 = new ShapedButton.YuvarlakButon();
            this.btnSil1 = new ShapedButton.YuvarlakButon();
            this.btnEkle1 = new ShapedButton.YuvarlakButon();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kat Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kısaltma Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kat Sıra Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Masa Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(168, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(168, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(168, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = ":";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAd.Location = new System.Drawing.Point(192, 84);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(207, 25);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(168, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = ":";
            // 
            // txtKod
            // 
            this.txtKod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKod.Location = new System.Drawing.Point(192, 133);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(207, 25);
            this.txtKod.TabIndex = 2;
            this.txtKod.TextChanged += new System.EventHandler(this.txtKod_TextChanged);
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSiraNo.Location = new System.Drawing.Point(192, 182);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Size = new System.Drawing.Size(207, 25);
            this.txtSiraNo.TabIndex = 3;
            this.txtSiraNo.TextChanged += new System.EventHandler(this.txtSiraNo_TextChanged);
            this.txtSiraNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSiraNo_KeyPress);
            // 
            // txtMasaSayisi
            // 
            this.txtMasaSayisi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMasaSayisi.Location = new System.Drawing.Point(192, 230);
            this.txtMasaSayisi.Name = "txtMasaSayisi";
            this.txtMasaSayisi.Size = new System.Drawing.Size(207, 25);
            this.txtMasaSayisi.TabIndex = 4;
            this.txtMasaSayisi.TextChanged += new System.EventHandler(this.txtMasaSayisi_TextChanged);
            this.txtMasaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMasaSayisi_KeyPress);
            // 
            // lstKat
            // 
            this.lstKat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstKat.HideSelection = false;
            this.lstKat.Location = new System.Drawing.Point(413, 86);
            this.lstKat.Name = "lstKat";
            this.lstKat.Size = new System.Drawing.Size(455, 284);
            this.lstKat.TabIndex = 8;
            this.lstKat.UseCompatibleStateImageBehavior = false;
            this.lstKat.SelectedIndexChanged += new System.EventHandler(this.lstKat_SelectedIndexChanged);
            // 
            // btnKattGeri
            // 
            this.btnKattGeri.FlatAppearance.BorderSize = 0;
            this.btnKattGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKattGeri.ImageIndex = 0;
            this.btnKattGeri.ImageList = this.ımageList1;
            this.btnKattGeri.Location = new System.Drawing.Point(798, 4);
            this.btnKattGeri.Name = "btnKattGeri";
            this.btnKattGeri.Size = new System.Drawing.Size(75, 76);
            this.btnKattGeri.TabIndex = 27;
            this.btnKattGeri.UseVisualStyleBackColor = true;
            this.btnKattGeri.Click += new System.EventHandler(this.btnKattGeri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ana.jpg");
            this.ımageList1.Images.SetKeyName(1, "ekle.jpg");
            this.ımageList1.Images.SetKeyName(2, "sil.jpg");
            this.ımageList1.Images.SetKeyName(3, "update.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuncelle1
            // 
            this.btnGuncelle1.FlatAppearance.BorderSize = 0;
            this.btnGuncelle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle1.ImageIndex = 3;
            this.btnGuncelle1.ImageList = this.ımageList1;
            this.btnGuncelle1.Location = new System.Drawing.Point(307, 302);
            this.btnGuncelle1.Name = "btnGuncelle1";
            this.btnGuncelle1.Size = new System.Drawing.Size(74, 72);
            this.btnGuncelle1.TabIndex = 29;
            this.btnGuncelle1.UseVisualStyleBackColor = true;
            this.btnGuncelle1.Click += new System.EventHandler(this.btnGuncelle1_Click);
            // 
            // btnSil1
            // 
            this.btnSil1.FlatAppearance.BorderSize = 0;
            this.btnSil1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil1.ImageIndex = 2;
            this.btnSil1.ImageList = this.ımageList1;
            this.btnSil1.Location = new System.Drawing.Point(166, 302);
            this.btnSil1.Name = "btnSil1";
            this.btnSil1.Size = new System.Drawing.Size(74, 72);
            this.btnSil1.TabIndex = 30;
            this.btnSil1.UseVisualStyleBackColor = true;
            this.btnSil1.Click += new System.EventHandler(this.btnSil1_Click);
            // 
            // btnEkle1
            // 
            this.btnEkle1.FlatAppearance.BorderSize = 0;
            this.btnEkle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle1.ImageIndex = 1;
            this.btnEkle1.ImageList = this.ımageList1;
            this.btnEkle1.Location = new System.Drawing.Point(33, 302);
            this.btnEkle1.Name = "btnEkle1";
            this.btnEkle1.Size = new System.Drawing.Size(74, 72);
            this.btnEkle1.TabIndex = 31;
            this.btnEkle1.UseVisualStyleBackColor = true;
            this.btnEkle1.Click += new System.EventHandler(this.btnEkle1_Click);
            // 
            // FrmKatEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 404);
            this.Controls.Add(this.btnGuncelle1);
            this.Controls.Add(this.btnSil1);
            this.Controls.Add(this.btnEkle1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKattGeri);
            this.Controls.Add(this.lstKat);
            this.Controls.Add(this.txtMasaSayisi);
            this.Controls.Add(this.txtSiraNo);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKatEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kat Ekleme";
            this.Load += new System.EventHandler(this.KatEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.TextBox txtSiraNo;
        private System.Windows.Forms.TextBox txtMasaSayisi;
        private System.Windows.Forms.ListView lstKat;
        private ShapedButton.YuvarlakButon btnKattGeri;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ShapedButton.YuvarlakButon btnGuncelle1;
        private ShapedButton.YuvarlakButon btnSil1;
        private ShapedButton.YuvarlakButon btnEkle1;
    }
}