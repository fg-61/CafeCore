
namespace CafeCore.Forms
{
    partial class FrmRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlar));
            this.lblToplam = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.Label();
            this.rbGunluk = new System.Windows.Forms.RadioButton();
            this.RbAylik = new System.Windows.Forms.RadioButton();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DgRaporlar = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.rbTarihSec = new System.Windows.Forms.RadioButton();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.yuvarlakButon1 = new ShapedButton.YuvarlakButon();
            ((System.ComponentModel.ISupportInitialize)(this.DgRaporlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.Location = new System.Drawing.Point(473, 290);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(112, 21);
            this.lblToplam.TabIndex = 1;
            this.lblToplam.Text = "Toplam Tutar :";
            this.lblToplam.Visible = false;
            // 
            // txtToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamTutar.Location = new System.Drawing.Point(544, 310);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(62, 21);
            this.lblToplamTutar.TabIndex = 2;
            this.lblToplamTutar.Text = "toplam";
            // 
            // rbGunluk
            // 
            this.rbGunluk.AutoSize = true;
            this.rbGunluk.Location = new System.Drawing.Point(474, 28);
            this.rbGunluk.Name = "rbGunluk";
            this.rbGunluk.Size = new System.Drawing.Size(131, 19);
            this.rbGunluk.TabIndex = 4;
            this.rbGunluk.Text = "Günlük Satış Raporu";
            this.rbGunluk.UseVisualStyleBackColor = true;
            this.rbGunluk.CheckedChanged += new System.EventHandler(this.rbGunluk_CheckedChanged);
            // 
            // RbAylik
            // 
            this.RbAylik.AutoSize = true;
            this.RbAylik.Location = new System.Drawing.Point(474, 66);
            this.RbAylik.Name = "RbAylik";
            this.RbAylik.Size = new System.Drawing.Size(119, 19);
            this.RbAylik.TabIndex = 4;
            this.RbAylik.Text = "Aylık Satış Raporu";
            this.RbAylik.UseVisualStyleBackColor = true;
            this.RbAylik.CheckedChanged += new System.EventHandler(this.RbAylik_CheckedChanged);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.White;
            this.btnYazdir.FlatAppearance.BorderSize = 0;
            this.btnYazdir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYazdir.ImageIndex = 1;
            this.btnYazdir.ImageList = this.ımageList1;
            this.btnYazdir.Location = new System.Drawing.Point(756, 274);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(96, 97);
            this.btnYazdir.TabIndex = 5;
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ana.jpg");
            this.ımageList1.Images.SetKeyName(1, "hggh.png");
            // 
            // DgRaporlar
            // 
            this.DgRaporlar.AllowUserToDeleteRows = false;
            this.DgRaporlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgRaporlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DgRaporlar.BackgroundColor = System.Drawing.Color.White;
            this.DgRaporlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgRaporlar.Enabled = false;
            this.DgRaporlar.Location = new System.Drawing.Point(12, 12);
            this.DgRaporlar.Name = "DgRaporlar";
            this.DgRaporlar.RowHeadersWidth = 51;
            this.DgRaporlar.RowTemplate.Height = 25;
            this.DgRaporlar.Size = new System.Drawing.Size(393, 359);
            this.DgRaporlar.TabIndex = 6;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // rbTarihSec
            // 
            this.rbTarihSec.AutoSize = true;
            this.rbTarihSec.Location = new System.Drawing.Point(474, 104);
            this.rbTarihSec.Name = "rbTarihSec";
            this.rbTarihSec.Size = new System.Drawing.Size(108, 19);
            this.rbTarihSec.TabIndex = 4;
            this.rbTarihSec.Text = "Tarih Aralığı Seç";
            this.rbTarihSec.UseVisualStyleBackColor = true;
            this.rbTarihSec.CheckedChanged += new System.EventHandler(this.rbTarihSec_CheckedChanged);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(474, 177);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(108, 23);
            this.dtpBaslangic.TabIndex = 7;
            this.dtpBaslangic.Visible = false;
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(474, 219);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(108, 23);
            this.dtpBitis.TabIndex = 7;
            this.dtpBitis.Visible = false;
            this.dtpBitis.ValueChanged += new System.EventHandler(this.dtpBitis_ValueChanged);
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(404, 183);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(63, 15);
            this.lblBaslangic.TabIndex = 8;
            this.lblBaslangic.Text = "Başlangıç :";
            this.lblBaslangic.Visible = false;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(432, 225);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(35, 15);
            this.lblBitis.TabIndex = 8;
            this.lblBitis.Text = "Bitiş :";
            this.lblBitis.Visible = false;
            // 
            // yuvarlakButon1
            // 
            this.yuvarlakButon1.FlatAppearance.BorderSize = 0;
            this.yuvarlakButon1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.yuvarlakButon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakButon1.ForeColor = System.Drawing.Color.White;
            this.yuvarlakButon1.ImageIndex = 0;
            this.yuvarlakButon1.ImageList = this.ımageList1;
            this.yuvarlakButon1.Location = new System.Drawing.Point(762, 12);
            this.yuvarlakButon1.Name = "yuvarlakButon1";
            this.yuvarlakButon1.Size = new System.Drawing.Size(90, 90);
            this.yuvarlakButon1.TabIndex = 9;
            this.yuvarlakButon1.UseVisualStyleBackColor = true;
            this.yuvarlakButon1.Click += new System.EventHandler(this.yuvarlakButon1_Click);
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 404);
            this.Controls.Add(this.yuvarlakButon1);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.DgRaporlar);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.rbTarihSec);
            this.Controls.Add(this.RbAylik);
            this.Controls.Add(this.rbGunluk);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.lblToplam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRaporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            ((System.ComponentModel.ISupportInitialize)(this.DgRaporlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label txtToplamTutar;
        private System.Windows.Forms.RadioButton rbGunluk;
        private System.Windows.Forms.RadioButton RbAylik;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.DataGridView DgRaporlar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.RadioButton rbTarihSec;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.ImageList ımageList1;
        private ShapedButton.YuvarlakButon yuvarlakButon1;
    }
}