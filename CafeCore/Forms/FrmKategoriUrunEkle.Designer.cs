namespace CafeCore.Forms
{
    partial class FrmKategoriUrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKategoriUrunEkle));
            this.tcKategoriEkle = new System.Windows.Forms.TabControl();
            this.tpKategoriEkle = new System.Windows.Forms.TabPage();
            this.btnKategoriGuncelle1 = new ShapedButton.YuvarlakButon();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKategoriSil1 = new ShapedButton.YuvarlakButon();
            this.btnKategoriEkle1 = new ShapedButton.YuvarlakButon();
            this.lstKategori = new System.Windows.Forms.ListView();
            this.txtKategoriSiraNo = new System.Windows.Forms.TextBox();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpUrunEkle = new System.Windows.Forms.TabPage();
            this.btnUrunGuncelle1 = new ShapedButton.YuvarlakButon();
            this.btnUrunSil1 = new ShapedButton.YuvarlakButon();
            this.btnUrunEkle1 = new ShapedButton.YuvarlakButon();
            this.cmbKategoriAdi = new System.Windows.Forms.ComboBox();
            this.lstUrun = new System.Windows.Forms.ListView();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKUAnaSayfa = new ShapedButton.YuvarlakButon();
            this.tcKategoriEkle.SuspendLayout();
            this.tpKategoriEkle.SuspendLayout();
            this.tpUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcKategoriEkle
            // 
            this.tcKategoriEkle.Controls.Add(this.tpKategoriEkle);
            this.tcKategoriEkle.Controls.Add(this.tpUrunEkle);
            this.tcKategoriEkle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tcKategoriEkle.ItemSize = new System.Drawing.Size(168, 42);
            this.tcKategoriEkle.Location = new System.Drawing.Point(0, 67);
            this.tcKategoriEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcKategoriEkle.Name = "tcKategoriEkle";
            this.tcKategoriEkle.SelectedIndex = 0;
            this.tcKategoriEkle.Size = new System.Drawing.Size(880, 337);
            this.tcKategoriEkle.TabIndex = 25;
            // 
            // tpKategoriEkle
            // 
            this.tpKategoriEkle.BackColor = System.Drawing.SystemColors.Control;
            this.tpKategoriEkle.Controls.Add(this.btnKategoriGuncelle1);
            this.tpKategoriEkle.Controls.Add(this.btnKategoriSil1);
            this.tpKategoriEkle.Controls.Add(this.btnKategoriEkle1);
            this.tpKategoriEkle.Controls.Add(this.lstKategori);
            this.tpKategoriEkle.Controls.Add(this.txtKategoriSiraNo);
            this.tpKategoriEkle.Controls.Add(this.txtKategoriAd);
            this.tpKategoriEkle.Controls.Add(this.label2);
            this.tpKategoriEkle.Controls.Add(this.label1);
            this.tpKategoriEkle.Location = new System.Drawing.Point(4, 46);
            this.tpKategoriEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpKategoriEkle.Name = "tpKategoriEkle";
            this.tpKategoriEkle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpKategoriEkle.Size = new System.Drawing.Size(872, 285);
            this.tpKategoriEkle.TabIndex = 0;
            this.tpKategoriEkle.Text = "Kategori Ekle";
            // 
            // btnKategoriGuncelle1
            // 
            this.btnKategoriGuncelle1.FlatAppearance.BorderSize = 0;
            this.btnKategoriGuncelle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriGuncelle1.ImageIndex = 3;
            this.btnKategoriGuncelle1.ImageList = this.ımageList1;
            this.btnKategoriGuncelle1.Location = new System.Drawing.Point(298, 195);
            this.btnKategoriGuncelle1.Name = "btnKategoriGuncelle1";
            this.btnKategoriGuncelle1.Size = new System.Drawing.Size(74, 72);
            this.btnKategoriGuncelle1.TabIndex = 24;
            this.btnKategoriGuncelle1.UseVisualStyleBackColor = true;
            this.btnKategoriGuncelle1.Click += new System.EventHandler(this.btnKategoriGuncelle1_Click);
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
            // btnKategoriSil1
            // 
            this.btnKategoriSil1.FlatAppearance.BorderSize = 0;
            this.btnKategoriSil1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriSil1.ImageIndex = 2;
            this.btnKategoriSil1.ImageList = this.ımageList1;
            this.btnKategoriSil1.Location = new System.Drawing.Point(157, 195);
            this.btnKategoriSil1.Name = "btnKategoriSil1";
            this.btnKategoriSil1.Size = new System.Drawing.Size(74, 72);
            this.btnKategoriSil1.TabIndex = 24;
            this.btnKategoriSil1.UseVisualStyleBackColor = true;
            this.btnKategoriSil1.Click += new System.EventHandler(this.btnKategoriSil1_Click);
            // 
            // btnKategoriEkle1
            // 
            this.btnKategoriEkle1.FlatAppearance.BorderSize = 0;
            this.btnKategoriEkle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriEkle1.ImageIndex = 1;
            this.btnKategoriEkle1.ImageList = this.ımageList1;
            this.btnKategoriEkle1.Location = new System.Drawing.Point(24, 195);
            this.btnKategoriEkle1.Name = "btnKategoriEkle1";
            this.btnKategoriEkle1.Size = new System.Drawing.Size(74, 72);
            this.btnKategoriEkle1.TabIndex = 24;
            this.btnKategoriEkle1.UseVisualStyleBackColor = true;
            this.btnKategoriEkle1.Click += new System.EventHandler(this.btnKategoriEkle1_Click);
            // 
            // lstKategori
            // 
            this.lstKategori.BackColor = System.Drawing.SystemColors.Control;
            this.lstKategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstKategori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstKategori.HideSelection = false;
            this.lstKategori.Location = new System.Drawing.Point(392, 10);
            this.lstKategori.Name = "lstKategori";
            this.lstKategori.Size = new System.Drawing.Size(472, 274);
            this.lstKategori.TabIndex = 23;
            this.lstKategori.UseCompatibleStateImageBehavior = false;
            this.lstKategori.SelectedIndexChanged += new System.EventHandler(this.lstKategori_SelectedIndexChanged);
            // 
            // txtKategoriSiraNo
            // 
            this.txtKategoriSiraNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKategoriSiraNo.Location = new System.Drawing.Point(24, 124);
            this.txtKategoriSiraNo.Name = "txtKategoriSiraNo";
            this.txtKategoriSiraNo.Size = new System.Drawing.Size(207, 25);
            this.txtKategoriSiraNo.TabIndex = 2;
            this.txtKategoriSiraNo.TextChanged += new System.EventHandler(this.txtKategoriSiraNo_TextChanged);
            this.txtKategoriSiraNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKategoriSiraNo_KeyPress);
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKategoriAd.Location = new System.Drawing.Point(24, 58);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(207, 25);
            this.txtKategoriAd.TabIndex = 1;
            this.txtKategoriAd.TextChanged += new System.EventHandler(this.txtKategoriAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kategori Sıra Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kategori Adı";
            // 
            // tpUrunEkle
            // 
            this.tpUrunEkle.BackColor = System.Drawing.SystemColors.Control;
            this.tpUrunEkle.Controls.Add(this.btnUrunGuncelle1);
            this.tpUrunEkle.Controls.Add(this.btnUrunSil1);
            this.tpUrunEkle.Controls.Add(this.btnUrunEkle1);
            this.tpUrunEkle.Controls.Add(this.cmbKategoriAdi);
            this.tpUrunEkle.Controls.Add(this.lstUrun);
            this.tpUrunEkle.Controls.Add(this.txtUrunFiyat);
            this.tpUrunEkle.Controls.Add(this.txtUrunAdi);
            this.tpUrunEkle.Controls.Add(this.label3);
            this.tpUrunEkle.Controls.Add(this.label9);
            this.tpUrunEkle.Controls.Add(this.label10);
            this.tpUrunEkle.Location = new System.Drawing.Point(4, 46);
            this.tpUrunEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUrunEkle.Name = "tpUrunEkle";
            this.tpUrunEkle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUrunEkle.Size = new System.Drawing.Size(872, 287);
            this.tpUrunEkle.TabIndex = 1;
            this.tpUrunEkle.Text = "Ürün Ekle";
            // 
            // btnUrunGuncelle1
            // 
            this.btnUrunGuncelle1.FlatAppearance.BorderSize = 0;
            this.btnUrunGuncelle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunGuncelle1.ImageIndex = 3;
            this.btnUrunGuncelle1.ImageList = this.ımageList1;
            this.btnUrunGuncelle1.Location = new System.Drawing.Point(298, 195);
            this.btnUrunGuncelle1.Name = "btnUrunGuncelle1";
            this.btnUrunGuncelle1.Size = new System.Drawing.Size(74, 72);
            this.btnUrunGuncelle1.TabIndex = 25;
            this.btnUrunGuncelle1.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle1.Click += new System.EventHandler(this.btnUrunGuncelle1_Click);
            // 
            // btnUrunSil1
            // 
            this.btnUrunSil1.FlatAppearance.BorderSize = 0;
            this.btnUrunSil1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunSil1.ImageIndex = 2;
            this.btnUrunSil1.ImageList = this.ımageList1;
            this.btnUrunSil1.Location = new System.Drawing.Point(157, 195);
            this.btnUrunSil1.Name = "btnUrunSil1";
            this.btnUrunSil1.Size = new System.Drawing.Size(74, 72);
            this.btnUrunSil1.TabIndex = 26;
            this.btnUrunSil1.UseVisualStyleBackColor = true;
            this.btnUrunSil1.Click += new System.EventHandler(this.btnUrunSil1_Click);
            // 
            // btnUrunEkle1
            // 
            this.btnUrunEkle1.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle1.ImageIndex = 1;
            this.btnUrunEkle1.ImageList = this.ımageList1;
            this.btnUrunEkle1.Location = new System.Drawing.Point(24, 195);
            this.btnUrunEkle1.Name = "btnUrunEkle1";
            this.btnUrunEkle1.Size = new System.Drawing.Size(74, 72);
            this.btnUrunEkle1.TabIndex = 27;
            this.btnUrunEkle1.UseVisualStyleBackColor = true;
            this.btnUrunEkle1.Click += new System.EventHandler(this.btnUrunEkle1_Click);
            // 
            // cmbKategoriAdi
            // 
            this.cmbKategoriAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKategoriAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKategoriAdi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbKategoriAdi.FormattingEnabled = true;
            this.cmbKategoriAdi.Location = new System.Drawing.Point(24, 32);
            this.cmbKategoriAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKategoriAdi.Name = "cmbKategoriAdi";
            this.cmbKategoriAdi.Size = new System.Drawing.Size(207, 28);
            this.cmbKategoriAdi.TabIndex = 1;
            this.cmbKategoriAdi.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriAdi_SelectedIndexChanged);
            // 
            // lstUrun
            // 
            this.lstUrun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUrun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstUrun.HideSelection = false;
            this.lstUrun.Location = new System.Drawing.Point(392, 5);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(474, 276);
            this.lstUrun.TabIndex = 23;
            this.lstUrun.UseCompatibleStateImageBehavior = false;
            this.lstUrun.SelectedIndexChanged += new System.EventHandler(this.lstUrun_SelectedIndexChanged);
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrunFiyat.Location = new System.Drawing.Point(24, 157);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(207, 25);
            this.txtUrunFiyat.TabIndex = 3;
            this.txtUrunFiyat.TextChanged += new System.EventHandler(this.txtUrunFiyat_TextChanged);
            this.txtUrunFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunFiyat_KeyPress);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrunAdi.Location = new System.Drawing.Point(24, 94);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(207, 25);
            this.txtUrunAdi.TabIndex = 2;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(24, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ürün Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(24, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Kategori Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnKUAnaSayfa
            // 
            this.btnKUAnaSayfa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKUAnaSayfa.FlatAppearance.BorderSize = 0;
            this.btnKUAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKUAnaSayfa.ImageIndex = 0;
            this.btnKUAnaSayfa.ImageList = this.ımageList1;
            this.btnKUAnaSayfa.Location = new System.Drawing.Point(797, 7);
            this.btnKUAnaSayfa.Name = "btnKUAnaSayfa";
            this.btnKUAnaSayfa.Size = new System.Drawing.Size(75, 76);
            this.btnKUAnaSayfa.TabIndex = 27;
            this.btnKUAnaSayfa.UseVisualStyleBackColor = true;
            this.btnKUAnaSayfa.Click += new System.EventHandler(this.btnKUAnaSayfa_Click);
            // 
            // FrmKategoriUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 404);
            this.Controls.Add(this.btnKUAnaSayfa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tcKategoriEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmKategoriUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KategoriUrunEkle_Load);
            this.tcKategoriEkle.ResumeLayout(false);
            this.tpKategoriEkle.ResumeLayout(false);
            this.tpKategoriEkle.PerformLayout();
            this.tpUrunEkle.ResumeLayout(false);
            this.tpUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcKategoriEkle;
        private System.Windows.Forms.TabPage tpKategoriEkle;
        private System.Windows.Forms.TabPage tpUrunEkle;
        private System.Windows.Forms.TextBox txtKategoriSiraNo;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstUrun;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbKategoriAdi;
        private System.Windows.Forms.ListView lstKategori;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ShapedButton.YuvarlakButon btnKUAnaSayfa;
        private System.Windows.Forms.ImageList ımageList1;
        private ShapedButton.YuvarlakButon btnKategoriGuncelle1;
        private ShapedButton.YuvarlakButon btnKategoriSil1;
        private ShapedButton.YuvarlakButon btnKategoriEkle1;
        private ShapedButton.YuvarlakButon btnUrunGuncelle1;
        private ShapedButton.YuvarlakButon btnUrunSil1;
        private ShapedButton.YuvarlakButon btnUrunEkle1;
    }
}