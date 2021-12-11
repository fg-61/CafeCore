﻿
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
            this.rbGunluk = new System.Windows.Forms.RadioButton();
            this.RbAylik = new System.Windows.Forms.RadioButton();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.DgRaporlar = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.rbTarihSec = new System.Windows.Forms.RadioButton();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgRaporlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Tutar:";
            this.label1.Visible = false;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamTutar.Location = new System.Drawing.Point(353, 389);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 21);
            this.lblToplamTutar.TabIndex = 2;
            // 
            // rbGunluk
            // 
            this.rbGunluk.AutoSize = true;
            this.rbGunluk.Location = new System.Drawing.Point(430, 36);
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
            this.RbAylik.Location = new System.Drawing.Point(430, 74);
            this.RbAylik.Name = "RbAylik";
            this.RbAylik.Size = new System.Drawing.Size(119, 19);
            this.RbAylik.TabIndex = 4;
            this.RbAylik.Text = "Aylık Satış Raporu";
            this.RbAylik.UseVisualStyleBackColor = true;
            this.RbAylik.CheckedChanged += new System.EventHandler(this.RbAylik_CheckedChanged);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(430, 239);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(174, 132);
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
            this.rbTarihSec.Location = new System.Drawing.Point(430, 112);
            this.rbTarihSec.Name = "rbTarihSec";
            this.rbTarihSec.Size = new System.Drawing.Size(108, 19);
            this.rbTarihSec.TabIndex = 4;
            this.rbTarihSec.Text = "Tarih Aralığı Seç";
            this.rbTarihSec.UseVisualStyleBackColor = true;
            this.rbTarihSec.CheckedChanged += new System.EventHandler(this.rbTarihSec_CheckedChanged);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(496, 150);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(108, 23);
            this.dtpBaslangic.TabIndex = 7;
            this.dtpBaslangic.Visible = false;
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(496, 192);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(108, 23);
            this.dtpBitis.TabIndex = 7;
            this.dtpBitis.Visible = false;
            this.dtpBitis.ValueChanged += new System.EventHandler(this.dtpBitis_ValueChanged);
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(430, 156);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(57, 15);
            this.lblBaslangic.TabIndex = 8;
            this.lblBaslangic.Text = "Başlangıç";
            this.lblBaslangic.Visible = false;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(446, 198);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(29, 15);
            this.lblBitis.TabIndex = 8;
            this.lblBitis.Text = "Bitiş";
            this.lblBitis.Visible = false;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(616, 422);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.DgRaporlar);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.rbTarihSec);
            this.Controls.Add(this.RbAylik);
            this.Controls.Add(this.rbGunluk);
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
    }
}