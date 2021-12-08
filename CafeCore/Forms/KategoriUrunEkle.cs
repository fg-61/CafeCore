using CafeCore.Data;
using CafeCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CafeCore.Forms
{
    public partial class KategoriUrunEkle : Form
    {
        public KategoriUrunEkle()
        {
            InitializeComponent();
        }
        CafeContext _dbContext = new CafeContext();
        private void KategoriUrunEkle_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }
        private void KategoriListeDoldur()
        {
            lstKategori.Columns.Clear();
            lstKategori.Items.Clear();
            lstKategori.MultiSelect = false;
            lstKategori.View = View.Details;
            lstKategori.FullRowSelect = true;
            lstKategori.Columns.Add("Kategori Adı");
            lstKategori.Columns.Add("Kategori Sıra No");
            lstKategori.Columns.Add("Ürün Sayısı");

            var kategoriView = _dbContext.Kategoriler.Include(x => x.Urunler).OrderBy(x => x.SiraNo).ToList();
            foreach (var item in kategoriView)
            {
                ListViewItem viewItem = new ListViewItem(item.Ad);
                viewItem.SubItems.Add(item.SiraNo.ToString());
                viewItem.SubItems.Add(item.Urunler.Count.ToString());
                viewItem.Tag = item;
                lstKategori.Items.Add(viewItem);
            }
            lstKategori.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void UrunListeDoldur()
        {
            // combobox a kategori doldurma
            cmbKategoriAdi.DataSource = _dbContext.Kategoriler.OrderBy(x => x.SiraNo).ToList();
            cmbKategoriAdi.DisplayMember = "Ad";

            // list view doldurma
            lstUrun.Columns.Clear();
            lstUrun.Items.Clear();
            lstUrun.MultiSelect = false;
            lstUrun.View = View.Details;
            lstUrun.FullRowSelect = true;
            lstUrun.Columns.Add("Kategori");
            lstUrun.Columns.Add("Ürün Adı");
            lstUrun.Columns.Add("Fiyat");

            var urunView = _dbContext.Urunler.OrderBy(x => x.Kategori.Ad).ToList();
            foreach (var item in urunView)
            {
                ListViewItem viewItem = new ListViewItem(item.Kategori.Ad);
                viewItem.SubItems.Add(item.Ad.ToString());
                viewItem.SubItems.Add($"{item.Fiyat:c2}");
                viewItem.Tag = item;
                lstUrun.Items.Add(viewItem);
            }
            lstUrun.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ListeyiDoldur()
        {
            KategoriListeDoldur();
            UrunListeDoldur();
        }
        private void txtKategoriSiraNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUrunFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }
        // KATEGORİ KISMI //
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
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
        private Kategori _seciliKategori;
        // Sil kısında altındaki ürünlere ne olacak ?
        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItems.Count == 0) return;
            _seciliKategori = lstKategori.SelectedItems[0].Tag as Kategori;
            try
            {
                var Kategori = _dbContext.Kategoriler.Find(_seciliKategori.Id);
                _dbContext.Kategoriler.Remove(Kategori);

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
        // KATEGORİ KISMI BİTTİ //


        // ÜRÜN KISMI //
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
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
        {// bağlantılı ürünler ne olacak ??
            if (lstUrun.SelectedItems.Count == 0) return;
            _seciliUrun = lstUrun.SelectedItems[0].Tag as Urun;
            try
            {
                var Urun = _dbContext.Urunler.Find(_seciliUrun.Id);
                _dbContext.Urunler.Remove(Urun);

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

        private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItems.Count == 0) return;
            _seciliKategori = lstKategori.SelectedItems[0].Tag as Kategori;

            txtKategoriAd.Text = _seciliKategori.Ad;
            txtKategoriSiraNo.Text = _seciliKategori.SiraNo.ToString();

        }

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


        // ÜRÜN KISMI BİTTİ //
    }
}
//string moneyFormat = money.ToString("#,##0.00");