
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
            this.btnKatGeri = new ShapedButton.YuvarlakButon();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuncelle = new ShapedButton.YuvarlakButon();
            this.btnSil = new ShapedButton.YuvarlakButon();
            this.btnEkle = new ShapedButton.YuvarlakButon();
            this.yuvarlakButon1 = new ShapedButton.YuvarlakButon();
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
            // 
            // txtMasaSayisi
            // 
            this.txtMasaSayisi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMasaSayisi.Location = new System.Drawing.Point(192, 230);
            this.txtMasaSayisi.Name = "txtMasaSayisi";
            this.txtMasaSayisi.Size = new System.Drawing.Size(207, 25);
            this.txtMasaSayisi.TabIndex = 4;
            this.txtMasaSayisi.TextChanged += new System.EventHandler(this.txtMasaSayisi_TextChanged);
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
            // btnKatGeri
            // 
            this.btnKatGeri.FlatAppearance.BorderSize = 0;
            this.btnKatGeri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnKatGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKatGeri.ImageIndex = 0;
            this.btnKatGeri.ImageList = this.ımageList1;
            this.btnKatGeri.Location = new System.Drawing.Point(798, 4);
            this.btnKatGeri.Name = "btnKatGeri";
            this.btnKatGeri.Size = new System.Drawing.Size(75, 76);
            this.btnKatGeri.TabIndex = 27;
            this.btnKatGeri.UseVisualStyleBackColor = true;
            this.btnKatGeri.Click += new System.EventHandler(this.btnKatGeri_Click);
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
            this.ımageList1.Images.SetKeyName(4, "WhatsApp Image 2021-12-12 at 16.53.10.jpeg");
            this.ımageList1.Images.SetKeyName(5, "efso.jpg");
            this.ımageList1.Images.SetKeyName(6, "fdsfsd.jpg");
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
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ImageIndex = 5;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(227, 302);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(74, 72);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ImageIndex = 2;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(130, 302);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(74, 72);
            this.btnSil.TabIndex = 30;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ImageIndex = 1;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(33, 302);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(74, 72);
            this.btnEkle.TabIndex = 31;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // yuvarlakButon1
            // 
            this.yuvarlakButon1.FlatAppearance.BorderSize = 0;
            this.yuvarlakButon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakButon1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yuvarlakButon1.ImageIndex = 6;
            this.yuvarlakButon1.ImageList = this.ımageList1;
            this.yuvarlakButon1.Location = new System.Drawing.Point(324, 302);
            this.yuvarlakButon1.Name = "yuvarlakButon1";
            this.yuvarlakButon1.Size = new System.Drawing.Size(74, 72);
            this.yuvarlakButon1.TabIndex = 32;
            this.yuvarlakButon1.UseVisualStyleBackColor = true;
            this.yuvarlakButon1.Click += new System.EventHandler(this.yuvarlakButon1_Click);
            // 
            // FrmKatEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 404);
            this.Controls.Add(this.yuvarlakButon1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKatGeri);
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
        private ShapedButton.YuvarlakButon btnKatGeri;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ShapedButton.YuvarlakButon btnGuncelle;
        private ShapedButton.YuvarlakButon btnSil;
        private ShapedButton.YuvarlakButon btnEkle;
        private ShapedButton.YuvarlakButon yuvarlakButon1;
    }
}