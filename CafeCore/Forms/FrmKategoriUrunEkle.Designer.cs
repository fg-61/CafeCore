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
            this.btnKategoriGuncelle = new ShapedButton.YuvarlakButon();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKategoriSil = new ShapedButton.YuvarlakButon();
            this.btnKategoriEkle = new ShapedButton.YuvarlakButon();
            this.lstKategori = new System.Windows.Forms.ListView();
            this.txtKategoriSiraNo = new System.Windows.Forms.TextBox();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpUrunEkle = new System.Windows.Forms.TabPage();
            this.btnUrunGuncelle = new ShapedButton.YuvarlakButon();
            this.btnUrunSil = new ShapedButton.YuvarlakButon();
            this.btnUrunEkle = new ShapedButton.YuvarlakButon();
            this.cmbKategoriAdi = new System.Windows.Forms.ComboBox();
            this.lstUrun = new System.Windows.Forms.ListView();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnaSayfa = new ShapedButton.YuvarlakButon();
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
            this.tcKategoriEkle.Location = new System.Drawing.Point(0, 89);
            this.tcKategoriEkle.Name = "tcKategoriEkle";
            this.tcKategoriEkle.SelectedIndex = 0;
            this.tcKategoriEkle.Size = new System.Drawing.Size(1006, 449);
            this.tcKategoriEkle.TabIndex = 25;
            // 
            // tpKategoriEkle
            // 
            this.tpKategoriEkle.BackColor = System.Drawing.Color.White;
            this.tpKategoriEkle.Controls.Add(this.btnKategoriGuncelle);
            this.tpKategoriEkle.Controls.Add(this.btnKategoriSil);
            this.tpKategoriEkle.Controls.Add(this.btnKategoriEkle);
            this.tpKategoriEkle.Controls.Add(this.lstKategori);
            this.tpKategoriEkle.Controls.Add(this.txtKategoriSiraNo);
            this.tpKategoriEkle.Controls.Add(this.txtKategoriAd);
            this.tpKategoriEkle.Controls.Add(this.label2);
            this.tpKategoriEkle.Controls.Add(this.label1);
            this.tpKategoriEkle.Location = new System.Drawing.Point(4, 46);
            this.tpKategoriEkle.Name = "tpKategoriEkle";
            this.tpKategoriEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tpKategoriEkle.Size = new System.Drawing.Size(998, 399);
            this.tpKategoriEkle.TabIndex = 0;
            this.tpKategoriEkle.Text = "Kategori Ekle";
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.FlatAppearance.BorderSize = 0;
            this.btnKategoriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriGuncelle.ImageIndex = 4;
            this.btnKategoriGuncelle.ImageList = this.ımageList1;
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(341, 260);
            this.btnKategoriGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(85, 96);
            this.btnKategoriGuncelle.TabIndex = 24;
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
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
            this.ımageList1.Images.SetKeyName(4, "efso.jpg");
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.FlatAppearance.BorderSize = 0;
            this.btnKategoriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriSil.ImageIndex = 2;
            this.btnKategoriSil.ImageList = this.ımageList1;
            this.btnKategoriSil.Location = new System.Drawing.Point(179, 260);
            this.btnKategoriSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(85, 96);
            this.btnKategoriSil.TabIndex = 24;
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.FlatAppearance.BorderSize = 0;
            this.btnKategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriEkle.ImageIndex = 1;
            this.btnKategoriEkle.ImageList = this.ımageList1;
            this.btnKategoriEkle.Location = new System.Drawing.Point(27, 260);
            this.btnKategoriEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(85, 96);
            this.btnKategoriEkle.TabIndex = 24;
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // lstKategori
            // 
            this.lstKategori.BackColor = System.Drawing.Color.White;
            this.lstKategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstKategori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstKategori.HideSelection = false;
            this.lstKategori.Location = new System.Drawing.Point(448, 13);
            this.lstKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstKategori.Name = "lstKategori";
            this.lstKategori.Size = new System.Drawing.Size(539, 365);
            this.lstKategori.TabIndex = 23;
            this.lstKategori.UseCompatibleStateImageBehavior = false;
            this.lstKategori.SelectedIndexChanged += new System.EventHandler(this.lstKategori_SelectedIndexChanged);
            // 
            // txtKategoriSiraNo
            // 
            this.txtKategoriSiraNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKategoriSiraNo.Location = new System.Drawing.Point(27, 165);
            this.txtKategoriSiraNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKategoriSiraNo.Name = "txtKategoriSiraNo";
            this.txtKategoriSiraNo.Size = new System.Drawing.Size(236, 30);
            this.txtKategoriSiraNo.TabIndex = 2;
            this.txtKategoriSiraNo.TextChanged += new System.EventHandler(this.txtKategoriSiraNo_TextChanged);
            this.txtKategoriSiraNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKategoriSiraNo_KeyPress);
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKategoriAd.Location = new System.Drawing.Point(27, 77);
            this.txtKategoriAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(236, 30);
            this.txtKategoriAd.TabIndex = 1;
            this.txtKategoriAd.TextChanged += new System.EventHandler(this.txtKategoriAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kategori Sıra Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kategori Adı";
            // 
            // tpUrunEkle
            // 
            this.tpUrunEkle.BackColor = System.Drawing.Color.White;
            this.tpUrunEkle.Controls.Add(this.btnUrunGuncelle);
            this.tpUrunEkle.Controls.Add(this.btnUrunSil);
            this.tpUrunEkle.Controls.Add(this.btnUrunEkle);
            this.tpUrunEkle.Controls.Add(this.cmbKategoriAdi);
            this.tpUrunEkle.Controls.Add(this.lstUrun);
            this.tpUrunEkle.Controls.Add(this.txtUrunFiyat);
            this.tpUrunEkle.Controls.Add(this.txtUrunAdi);
            this.tpUrunEkle.Controls.Add(this.label3);
            this.tpUrunEkle.Controls.Add(this.label9);
            this.tpUrunEkle.Controls.Add(this.label10);
            this.tpUrunEkle.Location = new System.Drawing.Point(4, 46);
            this.tpUrunEkle.Name = "tpUrunEkle";
            this.tpUrunEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tpUrunEkle.Size = new System.Drawing.Size(998, 399);
            this.tpUrunEkle.TabIndex = 1;
            this.tpUrunEkle.Text = "Ürün Ekle";
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.FlatAppearance.BorderSize = 0;
            this.btnUrunGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunGuncelle.ImageIndex = 4;
            this.btnUrunGuncelle.ImageList = this.ımageList1;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(341, 260);
            this.btnUrunGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(85, 96);
            this.btnUrunGuncelle.TabIndex = 25;
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.FlatAppearance.BorderSize = 0;
            this.btnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunSil.ImageIndex = 2;
            this.btnUrunSil.ImageList = this.ımageList1;
            this.btnUrunSil.Location = new System.Drawing.Point(179, 260);
            this.btnUrunSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(85, 96);
            this.btnUrunSil.TabIndex = 26;
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.ImageIndex = 1;
            this.btnUrunEkle.ImageList = this.ımageList1;
            this.btnUrunEkle.Location = new System.Drawing.Point(27, 260);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(85, 96);
            this.btnUrunEkle.TabIndex = 27;
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // cmbKategoriAdi
            // 
            this.cmbKategoriAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKategoriAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKategoriAdi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbKategoriAdi.FormattingEnabled = true;
            this.cmbKategoriAdi.Location = new System.Drawing.Point(27, 43);
            this.cmbKategoriAdi.Name = "cmbKategoriAdi";
            this.cmbKategoriAdi.Size = new System.Drawing.Size(236, 33);
            this.cmbKategoriAdi.TabIndex = 1;
            this.cmbKategoriAdi.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriAdi_SelectedIndexChanged);
            // 
            // lstUrun
            // 
            this.lstUrun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUrun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstUrun.HideSelection = false;
            this.lstUrun.Location = new System.Drawing.Point(448, 7);
            this.lstUrun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(542, 368);
            this.lstUrun.TabIndex = 23;
            this.lstUrun.UseCompatibleStateImageBehavior = false;
            this.lstUrun.SelectedIndexChanged += new System.EventHandler(this.lstUrun_SelectedIndexChanged);
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrunFiyat.Location = new System.Drawing.Point(27, 209);
            this.txtUrunFiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(236, 30);
            this.txtUrunFiyat.TabIndex = 3;
            this.txtUrunFiyat.TextChanged += new System.EventHandler(this.txtUrunFiyat_TextChanged);
            this.txtUrunFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunFiyat_KeyPress);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrunAdi.Location = new System.Drawing.Point(27, 125);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(236, 30);
            this.txtUrunAdi.TabIndex = 2;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(27, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ürün Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(27, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Kategori Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnaSayfa.FlatAppearance.BorderSize = 0;
            this.btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfa.ImageIndex = 0;
            this.btnAnaSayfa.ImageList = this.ımageList1;
            this.btnAnaSayfa.Location = new System.Drawing.Point(911, 9);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(86, 101);
            this.btnAnaSayfa.TabIndex = 27;
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // FrmKategoriUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 539);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tcKategoriEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private ShapedButton.YuvarlakButon btnAnaSayfa;
        private System.Windows.Forms.ImageList ımageList1;
        private ShapedButton.YuvarlakButon btnKategoriGuncelle;
        private ShapedButton.YuvarlakButon btnKategoriSil;
        private ShapedButton.YuvarlakButon btnKategoriEkle;
        private ShapedButton.YuvarlakButon btnUrunGuncelle;
        private ShapedButton.YuvarlakButon btnUrunSil;
        private ShapedButton.YuvarlakButon btnUrunEkle;
    }
}