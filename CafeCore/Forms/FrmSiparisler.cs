using CafeCore.Data;
using CafeCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
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


        Color defaultColor = Color.LightGray, seciliColor = Color.RoyalBlue;


        private void FrmSiparisler_Load(object sender, EventArgs e)
        {
            txtMasaIsmi.Text = $"{_seciliMasa.Ad}";
            KategoriDoldur();
            SepetiDoldur();
        }


        private void KategoriDoldur()
        {
            flpKategoriler.Controls.Clear();
            int kategoriButonYukseklik = 100;
            int kategoriButonGenislik = 100;

            var kategoriler = _dbContext.Kategoriler
                .Include(x => x.Urunler)
                .Where(x => x.Urunler.Count > 0 && x.IsDeleted == false)
                .OrderBy(x => x.SiraNo)
                .ToList();
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
            _seciliKategori = btnKategori.Tag as Kategori;

            int urunButonYukseklik = 100;
            int urunButonGenislik = 100;

            var urunler = _dbContext.Urunler.Where(x => x.KategoriId == _seciliKategori.Id && x.IsDeleted == false).ToList();

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
            foreach (Button button in flpKategoriler.Controls)
            {
                button.BackColor = defaultColor;
                if (button.Text == btnKategori.Text)
                {
                    button.BackColor = seciliColor;
                }
            }
        }
        private decimal _toplamFiyat;
        private void SepetiDoldur()
        {
            _toplamFiyat = _dbContext.Siparisler.Where(x => x.MasaId == _seciliMasa.Id && x.IsDeleted == false).Sum(x => x.AraToplam);
            txtToplam.Text = $"{_toplamFiyat:c2}";

            lstSepet.Columns.Clear();
            lstSepet.Items.Clear();
            lstSepet.MultiSelect = false;
            lstSepet.View = View.Details;
            lstSepet.FullRowSelect = true;
            lstSepet.Columns.Add("Adet");
            lstSepet.Columns[0].Width = 70;
            lstSepet.Columns.Add("Ürün");
            lstSepet.Columns[1].Width = 307;
            lstSepet.Columns.Add("Ara Toplam");
            lstSepet.Columns[2].Width = 178;

            var siparisView = _dbContext.Siparisler.Where(x => x.MasaId == _seciliMasa.Id && x.IsDeleted == false).ToList();
            foreach (var item in siparisView)
            {
                ListViewItem viewItem = new ListViewItem(item.Adet.ToString());
                viewItem.Tag = item;
                viewItem.SubItems.Add(item.Urun.Ad);
                viewItem.SubItems.Add($"{item.AraToplam:c2}");
                lstSepet.Items.Add(viewItem);
            }
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            Button btnUrun = sender as Button;
            _seciliUrun = btnUrun.Tag as Urun;

            var sepetUrun = _dbContext.Siparisler.FirstOrDefault(x => x.Urun.Id == _seciliUrun.Id && x.MasaId == _seciliMasa.Id && x.IsDeleted == false); // bu compositle oluyo olabilir

            if (sepetUrun == null)
            {
                var yeni = new Siparis()
                {
                    Adet = 1,
                    Fiyat = _seciliUrun.Fiyat,
                    AraToplam = _seciliUrun.Fiyat * 1,
                    UrunId = _seciliUrun.Id,
                    MasaId = _seciliMasa.Id,
                };
                _dbContext.Masalar.FirstOrDefault(x => x.Id == yeni.MasaId).Durum = true;
                _dbContext.Siparisler.Add(yeni);
            }
            else
            {
                sepetUrun.Adet++;
                sepetUrun.AraToplam = sepetUrun.Adet * sepetUrun.Fiyat;
                _dbContext.Siparisler.Update(sepetUrun);
            }
            _dbContext.SaveChanges();
            SepetiDoldur();
        }

        private FrmMasalar _frmMasalar;
        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (_frmMasalar == null || _frmMasalar.IsDisposed)
            {
                _frmMasalar = new FrmMasalar();
            }
            _frmMasalar.Show();
            this.Hide();
        }

        private void btnHesapIptal_Click(object sender, EventArgs e)
        {
            if (lstSepet.Items.Count == 0) return;
            try
            {
                int i = 0;
                while (i < lstSepet.Items.Count)
                {
                    Siparis sepetSiparis = lstSepet.Items[i].Tag as Siparis;
                    _dbContext.Siparisler.Remove(sepetSiparis);
                    lstSepet.Items.Remove(lstSepet.Items[i]);
                }
                var iptalMasa = _dbContext.Masalar.FirstOrDefault(x => x.Id == _seciliMasa.Id);
                iptalMasa.Durum = false; // masa bos
                _dbContext.SaveChanges();
                MessageBox.Show($"Masa {_seciliMasa.No} iptal edilmiştir. Ücret tahsil edilmeyecektir.");

                if (_frmMasalar == null || _frmMasalar.IsDisposed)
                {
                    _frmMasalar = new FrmMasalar();
                }
                _frmMasalar.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş iptal işleminizde bir hata oluştu " + ex.Message);
                _dbContext = new();
            }
        }
        private void btnHesapYazdir_Click(object sender, EventArgs e)
        {
            if (lstSepet.Items.Count == 0) return;
            try
            {
                int i = 0;
                while (i < lstSepet.Items.Count)
                {
                    Siparis sepetSiparis = lstSepet.Items[i].Tag as Siparis;
                    sepetSiparis.IsDeleted = true;
                    sepetSiparis.DeletedDate = DateTime.Now;
                    _dbContext.Siparisler.Update(sepetSiparis);
                    lstSepet.Items.Remove(lstSepet.Items[i]);
                }
                var iptalMasa = _dbContext.Masalar.FirstOrDefault(x => x.Id == _seciliMasa.Id);
                iptalMasa.Durum = false;
                _dbContext.SaveChanges();

                MessageBox.Show($"{_toplamFiyat} tutarındaki siparişiniz başarıyla oluşturulmuştur");

                if (_frmMasalar == null || _frmMasalar.IsDisposed)
                {
                    _frmMasalar = new FrmMasalar();
                }
                _frmMasalar.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş iptal işleminizde bir hata oluştu " + ex.Message);
                _dbContext = new();
            }
        }
    }
}
