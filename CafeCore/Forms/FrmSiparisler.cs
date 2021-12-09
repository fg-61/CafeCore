using CafeCore.Data;
using CafeCore.Model;
using CafeCore.Repository;
using Microsoft.EntityFrameworkCore;
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
    public partial class FrmSiparisler : Form
    {
        public FrmSiparisler()
        {
            InitializeComponent();
        }
        public Masa _seciliMasa;
        private CafeContext _dbContext = new CafeContext();
        Color defaultColor = Color.LightGray;
        private void FrmSiparisler_Load(object sender, EventArgs e)
        {
            KategoriDoldur();
            //SepetiDoldur();
        }
        private void KategoriDoldur()
        {
            flpKategoriler.Controls.Clear();
            int kategoriButonYukseklik = 120;
            int kategoriButonGenislik = 120;

            var kategoriler = _dbContext.Kategoriler.Include(x => x.Urunler).Where(x => x.Urunler.Count > 0).OrderBy(x => x.SiraNo).ToList();
            for (int i = 0; i < kategoriler.Count; i++)
            {
                Kategori yeni = kategoriler[i];
                Button btn = new Button()
                {
                    Text = yeni.Ad,
                    Size = new Size(kategoriButonGenislik, kategoriButonYukseklik),
                    BackColor = defaultColor,
                    Tag = yeni
                };
                btn.Click += BtnKategori_Click;
                flpKategoriler.Controls.Add(btn);
            }

        }

        private Kategori _seciliKategori;
        private Urun _seciliUrun;
        private void BtnKategori_Click(object sender, EventArgs e)
        {
            flpUrunler.Controls.Clear();
            Button btnKategori = sender as Button;
            //btnKategori.BackColor = defaultColor; en son
            _seciliKategori = btnKategori.Tag as Kategori;

            int urunButonYukseklik = 100;
            int urunButonGenislik = 100;

            var urunler = _dbContext.Urunler.Where(x => x.KategoriId == _seciliKategori.Id).ToList();

            for (int i = 0; i < urunler.Count; i++)
            {
                Urun yeni = urunler[i];
                Button btnUrun = new Button()
                {
                    Text = yeni.Ad,
                    Size = new Size(urunButonGenislik, urunButonYukseklik),
                    BackColor = defaultColor,
                    Tag = yeni
                };
                btnUrun.Click += BtnUrun_Click;
                flpUrunler.Controls.Add(btnUrun);
            }

        }
        private List<Siparis> _sepet = new List<Siparis>();
        private void BtnUrun_Click(object sender, EventArgs e)
        {
            Button btnUrun = sender as Button;
            _seciliUrun = btnUrun.Tag as Urun;
            // composit olabilir
            var sepetUrun = _sepet.FirstOrDefault(x => x.Urun.Id == _seciliUrun.Id);

            if (sepetUrun == null)
            {
                _sepet.Add(new Siparis
                {
                    Adet = 1,
                    Urun = _seciliUrun,
                    Masa = _seciliMasa
                });
            }
            else
            {
                sepetUrun.Adet++;
            }
            SepetiDoldur();
        }

        private void SepetiDoldur()
        {
            var toplamFiyat = _sepet.Sum(x => x.AraToplam);
            txtToplam.Text = $"{toplamFiyat:c2}";


            lstSepet.Columns.Clear();
            lstSepet.Items.Clear();
            lstSepet.MultiSelect = false;
            lstSepet.View = View.Details;
            lstSepet.FullRowSelect = true;
            lstSepet.Columns.Add("Adet");
            lstSepet.Columns.Add("Ürün");
            lstSepet.Columns.Add("Ara Toplam");

            foreach (var item in _sepet)
            {
                ListViewItem viewItem = new ListViewItem(item.Adet.ToString());
                viewItem.Tag = item;
                viewItem.SubItems.Add(item.Urun.Ad);
                viewItem.SubItems.Add($"{item.AraToplam:c2}");
                lstSepet.Items.Add(viewItem);
            }

            lstSepet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

    }
}
