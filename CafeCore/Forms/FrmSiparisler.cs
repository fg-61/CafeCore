﻿using CafeCore.Data;
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
            txtMasaIsmi.Text = $"{_seciliMasa.Ad}";
            KategoriDoldur();
            SepetiDoldur();
        }


        private void KategoriDoldur()
        {
            flpKategoriler.Controls.Clear();
            int kategoriButonYukseklik = 100;
            int kategoriButonGenislik = 100;

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
        private void SepetiDoldur()
        {
            var toplamFiyat = _siparis.Sum(x => x.AraToplam);
            txtToplam.Text = $"{toplamFiyat:c2}";


            lstSepet.Columns.Clear();
            lstSepet.Items.Clear();
            lstSepet.MultiSelect = false;
            lstSepet.View = View.Details;
            lstSepet.FullRowSelect = true;
            lstSepet.Columns.Add("Adet");
            lstSepet.Columns[0].Width = 60;
            lstSepet.Columns.Add("Ürün");
            lstSepet.Columns[1].Width = 280;
            lstSepet.Columns.Add("Ara Toplam");
            lstSepet.Columns[2].Width = 147;

            var siparisView = _dbContext.Siparisler.Where(x => x.MasaId == _seciliMasa.Id).ToList();
            foreach (var item in _siparis)
            {
                ListViewItem viewItem = new ListViewItem(item.Adet.ToString());
                viewItem.Tag = item;
                viewItem.SubItems.Add(item.Urun.Ad);
                viewItem.SubItems.Add($"{item.AraToplam:c2}");
                lstSepet.Items.Add(viewItem);
            }
        }


        private List<Siparis> _siparis = new List<Siparis>();
        private void BtnUrun_Click(object sender, EventArgs e)
        {
            Button btnUrun = sender as Button;
            _seciliUrun = btnUrun.Tag as Urun;

            var sepetUrun = _siparis.FirstOrDefault(x => x.Urun.Id == _seciliUrun.Id);

            if (sepetUrun == null)
            {
                var yeni = new Siparis()
                {
                    Adet = 1,
                    Urun = _seciliUrun,
                    Masa = _seciliMasa,
                    MasaId = _seciliMasa.Id
                };
                _siparis.Add(yeni);
                _dbContext.Siparisler.Add(yeni);
            }
            else
            {
                sepetUrun.Adet++;
                _dbContext = new CafeContext();
            }

            _dbContext.SaveChanges();
            SepetiDoldur();
        }




        private void SepetiKaydet()
        {
            if (!_siparis.Any()) return;
            using (var tran = _dbContext.Database.BeginTransaction())
            {
                try
                {

                    tran.Commit();
                    MessageBox.Show($"{_siparis.Sum(x => x.AraToplam):c2} tutarındaki siparişiniz {_seciliMasa.No} nolu masadaki siparişiniz başarıyla kaydedilmiştir");
                    _siparis = new List<Siparis>();
                    SepetiDoldur();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Sipariş işleminizde bir hata oluştu " + ex.Message);
                    _dbContext = new();
                }
            }
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
    }
}
