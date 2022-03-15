using CafeCore.Data;
using CafeCore.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeCore.Forms
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }
        private SiparisRepo _siparisRepo = new SiparisRepo();
        string rapor = "";
        int secim = 0;
        private void rbGunluk_CheckedChanged(object sender, EventArgs e)
        {
            lblToplam.Visible = true;
            txtToplamTutar.Visible = true;
            if (rbGunluk.Checked == true)
            {
                rapor = "Günlük";
                secim = 1;
                DgRaporlarDoldur();
                DgRaporlar.Columns[0].HeaderText = "Sipariş Tarihi";
            }
        }

        private void RbAylik_CheckedChanged(object sender, EventArgs e)
        {

            lblToplam.Visible = true;
            txtToplamTutar.Visible = true;
            if (RbAylik.Checked == true)
            {
                rapor = "Aylik";
                secim = 2;
                DgRaporlarDoldur();
                DgRaporlar.Columns[0].HeaderText = "Sipariş Tarihi";
            }
        }

        private void DgRaporlarDoldur()
        {

            switch (secim)
            {
                case 1:
                    {
                        var query = _siparisRepo.GetDay();
                        DgRaporlar.DataSource = query;
                        DgRaporlar.Columns["IsDeleted"].Visible = false;
                    }
                    break;
                case 2:
                    {
                        var query = _siparisRepo.GetMonth();
                        DgRaporlar.DataSource = query;
                        DgRaporlar.Columns["IsDeleted"].Visible = false;
                    }
                    break;
                case 3:
                    {
                        var query = _siparisRepo.GetByDtp(dtpBitis, dtpBaslangic);
                        DgRaporlar.DataSource = query;
                        DgRaporlar.Columns["IsDeleted"].Visible = false;
                    }
                    break;
                default:
                    break;

            }
            var total = DgRaporlar.Rows.Cast<DataGridViewRow>().Sum(row => Convert.ToDecimal(row.Cells[4].Value)).ToString();
            lblToplamTutar.Text = $"{total}₺";
            lblToplamTutar.Visible = true;
            lblToplam.Visible = true;
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("Arial", 14);
                SolidBrush firca = new SolidBrush(Color.Black);
                Pen kalem = new Pen(Color.Black);
                e.Graphics.DrawString($"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}", font, firca, 50, 25);
                font = new Font("Arial", 20, FontStyle.Bold);
                e.Graphics.DrawString($"{rapor} Satış Raporu", font, firca, 290, 75);
                e.Graphics.DrawLine(kalem, 50, 70, 780, 70);
                e.Graphics.DrawLine(kalem, 50, 110, 780, 110);
                e.Graphics.DrawLine(kalem, 50, 70, 50, 110);
                e.Graphics.DrawLine(kalem, 780, 70, 780, 110);

                font = new Font("Arial", 14, FontStyle.Bold);

                e.Graphics.DrawString("Sipariş Tarihi", font, firca, 60, 140);
                e.Graphics.DrawString("Ürün Adi", font, firca, 280, 140);
                e.Graphics.DrawString("Adeti", font, firca, 420, 140);
                e.Graphics.DrawString("Birim Fiyatı", font, firca, 550, 140);
                e.Graphics.DrawString("Tutarı", font, firca, 680, 140);

                int i = 0;
                int y = 170;
                font = new Font("Arial", 14);
                while (i <= DgRaporlar.Rows.Count - 1)
                {
                    e.Graphics.DrawString(DgRaporlar.Rows[i].Cells[0].Value.ToString(), font, firca, 60, y);
                    e.Graphics.DrawString(DgRaporlar.Rows[i].Cells[1].Value.ToString(), font, firca, 280, y);
                    e.Graphics.DrawString(DgRaporlar.Rows[i].Cells[2].Value.ToString(), font, firca, 420, y);
                    e.Graphics.DrawString($"{ DgRaporlar.Rows[i].Cells[3].Value:c2}".ToString(), font, firca, 550, y);
                    e.Graphics.DrawString($"{ DgRaporlar.Rows[i].Cells[4].Value:c2}".ToString(), font, firca, 680, y);
                    y = y + 40;
                    i = i + 1;
                }
                e.Graphics.DrawString($"Toplam Tutar: {DgRaporlar.Rows.Cast<DataGridViewRow>().Sum(row => Convert.ToDecimal(row.Cells[4].Value)):c2}".ToString(), font, firca, 550, y + 40);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void rbTarihSec_CheckedChanged(object sender, EventArgs e)
        {

            lblToplam.Visible = true;
            txtToplamTutar.Visible = true;
            if (rbTarihSec.Checked == true)
            {
                dtpBaslangic.Visible = true;
                dtpBitis.Visible = true;
                lblBaslangic.Visible = true;
                lblBitis.Visible = true;

                rapor = "";
                secim = 3;

            }
            else
            {
                dtpBitis.Visible = false;
                dtpBaslangic.Visible = false;
                lblBitis.Visible = false;
                lblBaslangic.Visible = false;
                dtpBaslangic.Value = DateTime.Now;
                dtpBitis.Value = DateTime.Now;
            }
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBaslangic.Value > dtpBitis.Value)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden sonraki bir tarih olamaz!");
                return;
            }
            DgRaporlarDoldur();
            DgRaporlar.Columns[0].HeaderText = "Sipariş Tarihi";
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBaslangic.Value > dtpBitis.Value)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden önceki bir tarih olamaz!");
                return;
            }
            DgRaporlarDoldur();
            DgRaporlar.Columns[0].HeaderText = "Sipariş Tarihi";

        }

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            Giris frmGirisRapor = new Giris();
            frmGirisRapor.Show();
            this.Hide();
        }
    }
}
