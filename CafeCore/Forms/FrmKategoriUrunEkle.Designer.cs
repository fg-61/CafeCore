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
            this.tcKategoriEkle = new System.Windows.Forms.TabControl();
            this.tpKategoriEkle = new System.Windows.Forms.TabPage();
            this.lstKategori = new System.Windows.Forms.ListView();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.txtKategoriSiraNo = new System.Windows.Forms.TextBox();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpUrunEkle = new System.Windows.Forms.TabPage();
            this.cmbKategoriAdi = new System.Windows.Forms.ComboBox();
            this.lstUrun = new System.Windows.Forms.ListView();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tcKategoriEkle.SuspendLayout();
            this.tpKategoriEkle.SuspendLayout();
            this.tpUrunEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcKategoriEkle
            // 
            this.tcKategoriEkle.Controls.Add(this.tpKategoriEkle);
            this.tcKategoriEkle.Controls.Add(this.tpUrunEkle);
            this.tcKategoriEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcKategoriEkle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tcKategoriEkle.Location = new System.Drawing.Point(0, 0);
            this.tcKategoriEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcKategoriEkle.Name = "tcKategoriEkle";
            this.tcKategoriEkle.SelectedIndex = 0;
            this.tcKategoriEkle.Size = new System.Drawing.Size(880, 404);
            this.tcKategoriEkle.TabIndex = 25;
            // 
            // tpKategoriEkle
            // 
            this.tpKategoriEkle.BackColor = System.Drawing.SystemColors.Control;
            this.tpKategoriEkle.Controls.Add(this.lstKategori);
            this.tpKategoriEkle.Controls.Add(this.btnKategoriSil);
            this.tpKategoriEkle.Controls.Add(this.btnKategoriGuncelle);
            this.tpKategoriEkle.Controls.Add(this.btnKategoriEkle);
            this.tpKategoriEkle.Controls.Add(this.txtKategoriSiraNo);
            this.tpKategoriEkle.Controls.Add(this.txtKategoriAd);
            this.tpKategoriEkle.Controls.Add(this.label2);
            this.tpKategoriEkle.Controls.Add(this.label1);
            this.tpKategoriEkle.Location = new System.Drawing.Point(4, 46);
            this.tpKategoriEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpKategoriEkle.Name = "tpKategoriEkle";
            this.tpKategoriEkle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpKategoriEkle.Size = new System.Drawing.Size(872, 354);
            this.tpKategoriEkle.TabIndex = 0;
            this.tpKategoriEkle.Text = "Kategori Ekle";
            // 
            // lstKategori
            // 
            this.lstKategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstKategori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstKategori.HideSelection = false;
            this.lstKategori.Location = new System.Drawing.Point(413, 8);
            this.lstKategori.Name = "lstKategori";
            this.lstKategori.Size = new System.Drawing.Size(437, 344);
            this.lstKategori.TabIndex = 23;
            this.lstKategori.UseCompatibleStateImageBehavior = false;
            this.lstKategori.SelectedIndexChanged += new System.EventHandler(this.lstKategori_SelectedIndexChanged);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKategoriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriSil.ForeColor = System.Drawing.Color.White;
            this.btnKategoriSil.Location = new System.Drawing.Point(153, 285);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(95, 67);
            this.btnKategoriSil.TabIndex = 4;
            this.btnKategoriSil.Text = "Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = false;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKategoriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(281, 285);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(95, 67);
            this.btnKategoriGuncelle.TabIndex = 5;
            this.btnKategoriGuncelle.Text = "Güncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = false;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriEkle.ForeColor = System.Drawing.Color.White;
            this.btnKategoriEkle.Location = new System.Drawing.Point(24, 285);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(95, 67);
            this.btnKategoriEkle.TabIndex = 3;
            this.btnKategoriEkle.Text = "Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // txtKategoriSiraNo
            // 
            this.txtKategoriSiraNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKategoriSiraNo.Location = new System.Drawing.Point(24, 133);
            this.txtKategoriSiraNo.Name = "txtKategoriSiraNo";
            this.txtKategoriSiraNo.Size = new System.Drawing.Size(207, 25);
            this.txtKategoriSiraNo.TabIndex = 2;
            this.txtKategoriSiraNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKategoriSiraNo_KeyPress);
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKategoriAd.Location = new System.Drawing.Point(24, 67);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(207, 25);
            this.txtKategoriAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kategori Sıra Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kategori Adı";
            // 
            // tpUrunEkle
            // 
            this.tpUrunEkle.BackColor = System.Drawing.SystemColors.Control;
            this.tpUrunEkle.Controls.Add(this.cmbKategoriAdi);
            this.tpUrunEkle.Controls.Add(this.lstUrun);
            this.tpUrunEkle.Controls.Add(this.btnUrunSil);
            this.tpUrunEkle.Controls.Add(this.btnUrunGuncelle);
            this.tpUrunEkle.Controls.Add(this.btnUrunEkle);
            this.tpUrunEkle.Controls.Add(this.txtUrunFiyat);
            this.tpUrunEkle.Controls.Add(this.txtUrunAdi);
            this.tpUrunEkle.Controls.Add(this.label3);
            this.tpUrunEkle.Controls.Add(this.label9);
            this.tpUrunEkle.Controls.Add(this.label10);
            this.tpUrunEkle.Location = new System.Drawing.Point(4, 46);
            this.tpUrunEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUrunEkle.Name = "tpUrunEkle";
            this.tpUrunEkle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUrunEkle.Size = new System.Drawing.Size(869, 354);
            this.tpUrunEkle.TabIndex = 1;
            this.tpUrunEkle.Text = "Ürün Ekle";
            // 
            // cmbKategoriAdi
            // 
            this.cmbKategoriAdi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbKategoriAdi.FormattingEnabled = true;
            this.cmbKategoriAdi.Location = new System.Drawing.Point(24, 46);
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
            this.lstUrun.Location = new System.Drawing.Point(413, 8);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(437, 344);
            this.lstUrun.TabIndex = 23;
            this.lstUrun.UseCompatibleStateImageBehavior = false;
            this.lstUrun.SelectedIndexChanged += new System.EventHandler(this.lstUrun_SelectedIndexChanged);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUrunSil.ForeColor = System.Drawing.Color.White;
            this.btnUrunSil.Location = new System.Drawing.Point(153, 285);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(95, 67);
            this.btnUrunSil.TabIndex = 5;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUrunGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUrunGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(281, 285);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(95, 67);
            this.btnUrunGuncelle.TabIndex = 6;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = false;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUrunEkle.ForeColor = System.Drawing.Color.White;
            this.btnUrunEkle.Location = new System.Drawing.Point(24, 285);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(95, 67);
            this.btnUrunEkle.TabIndex = 4;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrunFiyat.Location = new System.Drawing.Point(24, 189);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(207, 25);
            this.txtUrunFiyat.TabIndex = 3;
            this.txtUrunFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunFiyat_KeyPress);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrunAdi.Location = new System.Drawing.Point(24, 118);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(207, 25);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(24, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ürün Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(24, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Kategori Adı";
            // 
            // FrmKategoriUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 404);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcKategoriEkle;
        private System.Windows.Forms.TabPage tpKategoriEkle;
        private System.Windows.Forms.TabPage tpUrunEkle;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.TextBox txtKategoriSiraNo;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstUrun;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbKategoriAdi;
        private System.Windows.Forms.ListView lstKategori;
    }
}