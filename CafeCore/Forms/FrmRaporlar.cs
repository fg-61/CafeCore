using CafeCore.Data;
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
        CafeContext _dbContext = new CafeContext();
        private void rbGunluk_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGunluk.Checked == true)
            {

            }
        }

        private void RbAylik_CheckedChanged(object sender, EventArgs e)
        {
            if (RbAylik.Checked==true)
            {
                DgRaporlarDoldur();
            }
        }

        private void DgRaporlarDoldur()
        {
            var query = _dbContext.Urunler.Select(x => new { x.Ad, x.Fiyat }).ToList();
            DgRaporlar.DataSource = query;
            
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
                //Pen kalem = new Pen(Color.Black);
                e.Graphics.DrawString($"Tarih={DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}", font, firca, 50, 25);
                font = new Font("Arial", 20, FontStyle.Bold);
                e.Graphics.DrawString("Satış Raporu", font, firca, 320, 75);
                e.Graphics.DrawString("**************************", font, firca, 320, 115);

                font = new Font("Arial", 14,FontStyle.Bold);

                e.Graphics.DrawString("Ürün Adi", font, firca, 60, 170); 
                e.Graphics.DrawString("Birim Fiyatı", font, firca, 280, 170); 
                e.Graphics.DrawString("Adeti", font, firca, 420, 170); 
                e.Graphics.DrawString("Tutarı", font, firca, 550, 170);

                int i = 0;
                int y = 210;
                font = new Font("Arial", 14);
                while (i <= DgRaporlar.Rows.Count - 2)
                {
                    e.Graphics.DrawString(DgRaporlar.Rows[i].Cells[0].Value.ToString(), font, firca, 60, y);
                    e.Graphics.DrawString(DgRaporlar.Rows[i].Cells[1].Value.ToString(), font, firca, 280, y);
                    //e.Graphics.DrawString(DgRaporlar.Rows[i].Cells[2].Value.ToString(), font, firca, 420, y);
                    //e.Graphics.DrawString(DgRaporlar.Rows[i].Cells[3].Value.ToString(), font, firca, 550, y);
                    y = y + 40;
                    i = i + 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
