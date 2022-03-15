using CafeCore.Data;
using CafeCore.Model;
using CafeCore.Repository;
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
        private UrunRepo _urunRepo = new UrunRepo();
        private SiparisRepo _siparisRepo = new SiparisRepo();
        private KategoriRepo _kategoriRepo = new KategoriRepo();
        private MasaRepo _masaRepo = new MasaRepo();


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

            var kategoriler = _kategoriRepo.GetWithUrun().ToList();
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

            var urunler = _urunRepo.GetUrunWithKategoriId(_seciliKategori.Id).ToList();

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
            _toplamFiyat = _siparisRepo.AraToplam(_seciliMasa.Id);
            txtToplam.Text = $"{_toplamFiyat:c2}";

            lstSepet.Columns.Clear();
            lstSepet.Items.Clear();
            lstSepet.MultiSelect = false;
            lstSepet.View = View.Details;
            lstSepet.FullRowSelect = true;
            lstSepet.Columns.Add("Adet");
            lstSepet.Columns[0].Width = 70;
            lstSepet.Columns.Add("Ürün");
            lstSepet.Columns[1].Width = 284;
            lstSepet.Columns.Add("Ara Toplam");
            lstSepet.Columns[2].Width = 120;

            var siparisView = _siparisRepo.Get(x => x.MasaId == _seciliMasa.Id && x.IsDeleted == false).ToList();
            foreach (var item in siparisView)
            {
                var urun = _urunRepo.GetById(item.UrunId);
                ListViewItem viewItem = new ListViewItem(item.Adet.ToString());
                viewItem.Tag = item;
                viewItem.SubItems.Add(urun.Ad);
                viewItem.SubItems.Add($"{item.AraToplam:c2}");
                lstSepet.Items.Add(viewItem);
            }
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            Button btnUrun = sender as Button;
            _seciliUrun = btnUrun.Tag as Urun;

            var sepetUrun = _siparisRepo.GetSepetUrun(_seciliUrun.Id, _seciliMasa.Id);

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
                _masaRepo.GetById(yeni.MasaId).Durum = true;
                _masaRepo.Save();
                _siparisRepo.Add(yeni);
            }
            else
            {
                sepetUrun.Adet++;
                sepetUrun.AraToplam = sepetUrun.Adet * sepetUrun.Fiyat;
                _siparisRepo.Update(sepetUrun);
            }
            //_dbContext.SaveChanges(); çalışmazsa geri al
            SepetiDoldur();
        }
        private void lstSepet_DoubleClick(object sender, EventArgs e)
        {
            if (lstSepet.SelectedItems.Count == 0) return;
            var secili = lstSepet.SelectedItems[0].Tag as Siparis;
            if (secili.Adet == 1)
            {
                _siparisRepo.Remove(secili);
            }
            else
            {
                secili.Adet--;
                secili.AraToplam = secili.Adet * secili.Fiyat;
                _siparisRepo.Update(secili);
            }
            //_dbContext.SaveChanges(); çalışmassa geri al

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
                    _siparisRepo.Remove(sepetSiparis);
                    lstSepet.Items.Remove(lstSepet.Items[i]);
                }
                var iptalMasa = _masaRepo.GetById(_seciliMasa.Id);
                iptalMasa.Durum = false; // masa bos
                _masaRepo.Save();
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
                _siparisRepo = new();
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
                    _siparisRepo.Update(sepetSiparis);
                    lstSepet.Items.Remove(lstSepet.Items[i]);
                }
                var iptalMasa = _masaRepo.GetById(_seciliMasa.Id);
                iptalMasa.Durum = false;
                _masaRepo.Save();

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
