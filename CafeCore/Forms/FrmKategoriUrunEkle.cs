using CafeCore.Data;
using CafeCore.Model;
using CafeCore.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CafeCore.Forms
{
    public partial class FrmKategoriUrunEkle : Form
    {
        public FrmKategoriUrunEkle()
        {
            InitializeComponent();
        }
        private CafeContext _dbContext = new CafeContext();
        private void KategoriUrunEkle_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }
        private void ListeyiDoldur()
        {
            KategoriListeDoldur();
            UrunListeDoldur();
        }


        #region Kategori Kismi

        #region Kategori liste doldur
        private void KategoriListeDoldur()
        {
            lstKategori.Columns.Clear();
            lstKategori.Items.Clear();
            lstKategori.MultiSelect = false;
            lstKategori.View = View.Details;
            lstKategori.FullRowSelect = true;
            lstKategori.Columns.Add("Kategori Adı");
            lstKategori.Columns[0].Width = 150;
            lstKategori.Columns.Add("Sıra No");
            lstKategori.Columns[1].Width = 150;
            lstKategori.Columns.Add("Ürün Sayısı");
            lstKategori.Columns[2].Width = 100;
            var kategoriView = _dbContext.Kategoriler
                .Where(x => x.IsDeleted == false)
                .Include(x => x.Urunler.Where(x => x.IsDeleted == false))
                .OrderBy(x => x.SiraNo).ToList();
            foreach (var item in kategoriView)
            {
                ListViewItem viewItem = new ListViewItem(item.Ad);
                viewItem.SubItems.Add(item.SiraNo.ToString());
                viewItem.SubItems.Add(item.Urunler.Count.ToString());
                viewItem.Tag = item;
                lstKategori.Items.Add(viewItem);
            }
        }
        #endregion
        #region Kategori Ekle,Sil,Guncelle

        private Kategori _seciliKategori;
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (_dbContext.Kategoriler.Where(x => x.IsDeleted == false).Any(x => x.Ad.ToLower() == txtKategoriAd.Text.ToLower()))
            {
                txtKategoriAd.Text = "";
                txtKategoriSiraNo.Text = "";
                MessageBox.Show("Farklı bir kategori adı giriniz !!");
                return;
            }
            if (_dbContext.Kategoriler.Where(x => x.IsDeleted == false).Any(x => x.SiraNo.ToString() == txtKategoriSiraNo.Text))
            {
                txtKategoriAd.Text = "";
                txtKategoriSiraNo.Text = "";
                MessageBox.Show("Farklı bir sıra numarası giriniz !!");
                return;
            }
            try
            {
                var yeni = new Kategori
                {
                    Ad = txtKategoriAd.Text,
                    SiraNo = int.Parse(txtKategoriSiraNo.Text)
                };

                _dbContext.Kategoriler.Add(yeni);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _dbContext = new CafeContext();
            }
            finally
            {
                ListeyiDoldur();
            }
        }
        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItems.Count == 0) return;
            _seciliKategori = lstKategori.SelectedItems[0].Tag as Kategori;
            try
            {
                var silinenKategori = _dbContext.Kategoriler.Find(_seciliKategori.Id);
                silinenKategori.IsDeleted = true;
                silinenKategori.DeletedDate = DateTime.Now;
                _dbContext.Kategoriler.Update(silinenKategori);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _dbContext = new CafeContext();
            }
            finally
            {
                ListeyiDoldur();
            }
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItems.Count == 0) return;
            _seciliKategori = lstKategori.SelectedItems[0].Tag as Kategori;

            try
            {
                _seciliKategori.Ad = txtKategoriAd.Text;
                _seciliKategori.SiraNo = int.Parse(txtKategoriSiraNo.Text);

                _dbContext.Kategoriler.Update(_seciliKategori);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _dbContext = new CafeContext();
            }
            finally
            {
                ListeyiDoldur();
            }
        }
        #endregion
        #region Kategori urun degisim eventi
        private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItems.Count == 0) return;
            _seciliKategori = lstKategori.SelectedItems[0].Tag as Kategori;

            txtKategoriAd.Text = _seciliKategori.Ad;
            txtKategoriSiraNo.Text = _seciliKategori.SiraNo.ToString();
        }
        #endregion 
        #region Kategori karakter sayısı kontrolu
        private string _eskiText;
        private void txtKategoriAd_TextChanged(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text.Length == 30)
            {
                _eskiText = txtKategoriAd.Text;
            }
            if (txtKategoriAd.Text.Length == 31)
            {
                txtKategoriAd.Text = _eskiText;
                MessageBox.Show("En fazla 30 karakter girişi yapılabilmektedir.Lütfen tekrar giriş yapınız.");
            }
        }
        private void txtKategoriSiraNo_TextChanged(object sender, EventArgs e)
        {
            if (txtKategoriSiraNo.Text.Length == 4)
            {
                _eskiText = txtKategoriSiraNo.Text;
            }
            if (txtKategoriSiraNo.Text.Length == 5)
            {
                txtKategoriSiraNo.Text = _eskiText;
                MessageBox.Show("En fazla 4 basamaklı sayı girişi yapılabilmektedir. Lütfen tekrar giriş yapınız.");
            }
        }
        #endregion
        #region Kategori tus kontrol
        private void txtKategoriSiraNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        #endregion

        #region Urun Kismi

        #region Urun liste doldur
        private void UrunListeDoldur()
        {
            // combobox a kategori doldurma
            cmbKategoriAdi.DataSource = _dbContext.Kategoriler
                .Where(x => x.IsDeleted == false)
                .OrderBy(x => x.SiraNo)
                .ToList();
            cmbKategoriAdi.DisplayMember = "Ad";

            // list view doldurma
            lstUrun.Columns.Clear();
            lstUrun.Items.Clear();
            lstUrun.MultiSelect = false;
            lstUrun.View = View.Details;
            lstUrun.FullRowSelect = true;
            lstUrun.Columns.Add("Kategori");
            lstUrun.Columns[0].Width = 150;
            lstUrun.Columns.Add("Ürün Adı");
            lstUrun.Columns[1].Width = 150;
            lstUrun.Columns.Add("Fiyat");
            lstUrun.Columns[2].Width = 100;



   

            var urunView = _dbContext.Urunler
                .Where(x => x.IsDeleted == false)
                .Include(x => x.Kategori)
                .Where(x => x.Kategori.IsDeleted == false)
                .OrderBy(x => x.Kategori.Ad)
                .ToList();
            foreach (var item in urunView)
            {
                ListViewItem viewItem = new ListViewItem(item.Kategori.Ad);
                viewItem.SubItems.Add(item.Ad.ToString());
                viewItem.SubItems.Add($"{item.Fiyat:c2}");
                viewItem.Tag = item;
                lstUrun.Items.Add(viewItem);
            }
        }
        #endregion
        #region Urun Ekle,Sil,Guncelle
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (_dbContext.Urunler.Where(x => x.IsDeleted == false).Any(x => x.Ad.ToLower() == txtUrunAdi.Text.ToLower()))
            {
                txtUrunAdi.Text = "";
                txtUrunFiyat.Text = "";
                MessageBox.Show("Farklı bir kategori adı giriniz !!");
                return;
            }
            try
            {
                var yeni = new Urun
                {
                    Kategori = (cmbKategoriAdi.SelectedItem as Kategori),
                    Ad = txtUrunAdi.Text,
                    Fiyat = Decimal.Parse(txtUrunFiyat.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture)
                };
                _dbContext.Urunler.Add(yeni);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _dbContext = new CafeContext();
            }
            finally
            {
                ListeyiDoldur();
            }
        }
        private Urun _seciliUrun;
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItems.Count == 0) return;
            _seciliUrun = lstUrun.SelectedItems[0].Tag as Urun;
            try
            {
                var silinenUrun = _dbContext.Urunler.Find(_seciliUrun.Id);
                silinenUrun.IsDeleted = true;
                silinenUrun.DeletedDate = DateTime.Now;
                _dbContext.Urunler.Update(silinenUrun);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _dbContext = new CafeContext();
            }
            finally
            {
                ListeyiDoldur();
            }
        }
        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItems.Count == 0) return;
            _seciliUrun = lstUrun.SelectedItems[0].Tag as Urun;

            try
            {
                _seciliUrun.Kategori = (cmbKategoriAdi.SelectedItem as Kategori);
                _seciliUrun.Ad = txtUrunAdi.Text;
                _seciliUrun.Fiyat = Decimal.Parse(txtUrunFiyat.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

                _dbContext.Urunler.Update(_seciliUrun);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _dbContext = new CafeContext();
            }
            finally
            {
                ListeyiDoldur();
            }
        }
        #endregion
        #region Urun index degisim eventleri
        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItems.Count == 0) return;
            _seciliUrun = lstUrun.SelectedItems[0].Tag as Urun;

            txtUrunAdi.Text = _seciliUrun.Ad;
            txtUrunFiyat.Text = _seciliUrun.Fiyat.ToString(CultureInfo.InvariantCulture);
            cmbKategoriAdi.SelectedItem = _seciliUrun.Kategori;

        }
        private void cmbKategoriAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategoriAdi.SelectedItem != null) return;
            _seciliKategori = cmbKategoriAdi.SelectedItem as Kategori;

        }
        #endregion
        #region Urun karakter sayısı kontrolu
        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text.Length == 50)
            {
                _eskiText = txtUrunAdi.Text;
            }
            if (txtUrunAdi.Text.Length == 51)
            {
                txtUrunAdi.Text = _eskiText;
                MessageBox.Show("En fazla 50 karakter girişi yapılabilmektedir.Lütfen tekrar giriş yapınız.");
            }
        }
        private void txtUrunFiyat_TextChanged(object sender, EventArgs e)
        {
            if (txtKategoriSiraNo.Text.Length == 6)
            {
                _eskiText = txtKategoriSiraNo.Text;
            }
            if (txtKategoriSiraNo.Text.Length == 7)
            {
                txtKategoriSiraNo.Text = _eskiText;
                MessageBox.Show("En fazla 6 basamaklı sayı girişi yapılabilmektedir. Lütfen tekrar giriş yapınız.");
            }
        }
        #endregion
        #region Urun tus kontrol
        private void txtUrunFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }
        #endregion

        #endregion

        #region Menu Butonu
        private Giris _frmgiris;
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            if (_frmgiris == null)
            {
                _frmgiris = new Giris();
            }
            _frmgiris.Show();
            this.Hide();
        }
        #endregion
    }
}