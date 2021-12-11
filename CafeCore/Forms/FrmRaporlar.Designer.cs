
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlar));
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.BtnIlk = new System.Windows.Forms.Button();
            this.btnSon = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.rbGunluk = new System.Windows.Forms.RadioButton();
            this.RbAylik = new System.Windows.Forms.RadioButton();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.DgRaporlar = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.rbTarihSec = new System.Windows.Forms.RadioButton();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DgRaporlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(418, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Tutar";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamTutar.Location = new System.Drawing.Point(548, 350);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 21);
            this.lblToplamTutar.TabIndex = 2;
            // 
            // btnOnceki
            // 
            this.btnOnceki.Location = new System.Drawing.Point(91, 377);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(73, 56);
            this.btnOnceki.TabIndex = 3;
            this.btnOnceki.Text = "Önceki";
            this.btnOnceki.UseVisualStyleBackColor = true;
            // 
            // BtnIlk
            // 
            this.BtnIlk.Location = new System.Drawing.Point(12, 376);
            this.BtnIlk.Name = "BtnIlk";
            this.BtnIlk.Size = new System.Drawing.Size(73, 56);
            this.BtnIlk.TabIndex = 3;
            this.BtnIlk.Text = "İlk";
            this.BtnIlk.UseVisualStyleBackColor = true;
            // 
            // btnSon
            // 
            this.btnSon.Location = new System.Drawing.Point(339, 376);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(73, 56);
            this.btnSon.TabIndex = 3;
            this.btnSon.Text = "Son";
            this.btnSon.UseVisualStyleBackColor = true;
            // 
            // btnSonraki
            // 
            this.btnSonraki.Location = new System.Drawing.Point(260, 376);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(73, 56);
            this.btnSonraki.TabIndex = 3;
            this.btnSonraki.Text = "Sonraki";
            this.btnSonraki.UseVisualStyleBackColor = true;
            // 
            // rbGunluk
            // 
            this.rbGunluk.AutoSize = true;
            this.rbGunluk.Location = new System.Drawing.Point(462, 38);
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
            this.RbAylik.Location = new System.Drawing.Point(462, 77);
            this.RbAylik.Name = "RbAylik";
            this.RbAylik.Size = new System.Drawing.Size(119, 19);
            this.RbAylik.TabIndex = 4;
            this.RbAylik.Text = "Aylık Satış Raporu";
            this.RbAylik.UseVisualStyleBackColor = true;
            this.RbAylik.CheckedChanged += new System.EventHandler(this.RbAylik_CheckedChanged);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(430, 249);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(228, 81);
            this.btnYazdir.TabIndex = 5;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // DgRaporlar
            // 
            this.DgRaporlar.AllowUserToDeleteRows = false;
            this.DgRaporlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgRaporlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DgRaporlar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgRaporlar.Enabled = false;
            this.DgRaporlar.Location = new System.Drawing.Point(12, 12);
            this.DgRaporlar.Name = "DgRaporlar";
            this.DgRaporlar.RowTemplate.Height = 25;
            this.DgRaporlar.Size = new System.Drawing.Size(400, 359);
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
            this.rbTarihSec.Location = new System.Drawing.Point(462, 112);
            this.rbTarihSec.Name = "rbTarihSec";
            this.rbTarihSec.Size = new System.Drawing.Size(108, 19);
            this.rbTarihSec.TabIndex = 4;
            this.rbTarihSec.Text = "Tarih Aralığı Seç";
            this.rbTarihSec.UseVisualStyleBackColor = true;
            this.rbTarihSec.CheckedChanged += new System.EventHandler(this.rbTarihSec_CheckedChanged);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(430, 146);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 23);
            this.dtpBaslangic.TabIndex = 7;
            this.dtpBaslangic.Visible = false;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(430, 194);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 23);
            this.dtpBitis.TabIndex = 7;
            this.dtpBitis.Visible = false;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.DgRaporlar);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.rbTarihSec);
            this.Controls.Add(this.RbAylik);
            this.Controls.Add(this.rbGunluk);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.btnSon);
            this.Controls.Add(this.BtnIlk);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label1);
            this.Name = "FrmRaporlar";
            this.Text = "Raporlar";
            ((System.ComponentModel.ISupportInitialize)(this.DgRaporlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnOnceki;
        private System.Windows.Forms.Button BtnIlk;
        private System.Windows.Forms.Button btnSon;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.RadioButton rbGunluk;
        private System.Windows.Forms.RadioButton RbAylik;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.DataGridView DgRaporlar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.RadioButton rbTarihSec;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
    }
}