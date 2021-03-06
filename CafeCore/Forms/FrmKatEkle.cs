using CafeCore.Data;
using CafeCore.Model;
using CafeCore.Repository;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CafeCore.Forms
{
    public partial class FrmKatEkle : Form
    {
        public FrmKatEkle()
        {
            InitializeComponent();
        }
        private KatRepo _katRepo = new KatRepo();
        private void KatEkle_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        #region Tablo Doldurma
        private void ListeyiDoldur()
        {
            lstKat.Columns.Clear();
            lstKat.Items.Clear();
            lstKat.MultiSelect = false;
            lstKat.View = View.Details;
            lstKat.FullRowSelect = true;
            lstKat.Columns.Add("Kat Adı");
            lstKat.Columns[0].Width = 100;
            lstKat.Columns.Add("Kısaltma Kodu");
            lstKat.Columns[1].Width = 100;
            lstKat.Columns.Add("Kat Sıra No");
            lstKat.Columns[2].Width = 100;
            lstKat.Columns.Add("Masa Sayısı");
            lstKat.Columns[3].Width = 100;

          

            var query = _katRepo.Get(x => x.IsDeleted == false).OrderBy(x => x.SiraNo).ToList();
            foreach (var item in query)
            {
                ListViewItem viewItem = new ListViewItem(item.Ad);
                viewItem.SubItems.Add(item.Kodu);
                viewItem.SubItems.Add(item.SiraNo.ToString());
                viewItem.SubItems.Add(item.MasaSayisi.ToString());
                viewItem.Tag = item;
                lstKat.Items.Add(viewItem);
            }
            //lstKat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion

        #region Liste index degisimi
        private void lstKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKat.SelectedItems.Count == 0) return;
            _seciliKat = lstKat.SelectedItems[0].Tag as Kat;

            txtAd.Text = _seciliKat.Ad;
            txtKod.Text = _seciliKat.Kodu;
            txtSiraNo.Text = _seciliKat.SiraNo.ToString();
            txtMasaSayisi.Text = _seciliKat.MasaSayisi.ToString();
        }
        #endregion

        #region Ekle, Sil, Güncelle

        private Kat _seciliKat;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (_katRepo.IsKatAdInDatabase(txtAd.Text))
            {
                txtAd.Text = "";
                txtKod.Text = "";
                txtSiraNo.Text = "";
                txtMasaSayisi.Text = "";
                MessageBox.Show("Farklı bir kat adı giriniz !!");
                return;
            }
            if (_katRepo.IsKatKoduInDatabase(txtKod.Text))
            {
                txtAd.Text = "";
                txtKod.Text = "";
                txtSiraNo.Text = "";
                txtMasaSayisi.Text = "";

                MessageBox.Show("Farklı bir kısaltma kodu giriniz !!");
                return;
            }
            if (_katRepo.IsKatSiraNoInDatabase(txtSiraNo.Text))
            {
                txtAd.Text = "";
                txtKod.Text = "";
                txtSiraNo.Text = "";
                txtMasaSayisi.Text = "";

                MessageBox.Show("Farklı bir sıra numarası giriniz !!");
                return;
            }
            try
            {
                var yeniKat = new Kat
                {
                    Ad = txtAd.Text,
                    Kodu = txtKod.Text,
                    SiraNo = int.Parse(txtSiraNo.Text),
                    MasaSayisi = int.Parse(txtMasaSayisi.Text)
                };

                for (int i = 0; i < yeniKat.MasaSayisi; i++)
                {
                    var yeniMasa = new Masa()
                    {
                        Durum = false,
                        No = i + 1,
                        Ad = $"{ yeniKat.Kodu } ⮞ M-{ i + 1 }"
                    };
                    yeniKat.Masalar.Add(yeniMasa);
                }
                _katRepo.Add(yeniKat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _katRepo = new KatRepo();
            }
            finally
            {
                ListeyiDoldur();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKat.SelectedItems.Count == 0) return;
            _seciliKat = lstKat.SelectedItems[0].Tag as Kat;

            try
            {
                var silinecekKat = _katRepo.GetById(_seciliKat.Id);
                silinecekKat.IsDeleted = true;
                _katRepo.Update(silinecekKat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _katRepo = new KatRepo();
            }
            finally
            {
                ListeyiDoldur();
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_katRepo.IsKatSiraNoInDatabase(txtSiraNo.Text))
            {
                txtSiraNo.Text = "";
                MessageBox.Show("Farklı bir sıra numarası giriniz !!");
                return;
            }

            try
            {
                _seciliKat.Ad = txtAd.Text;
                _seciliKat.Kodu = txtKod.Text;
                _seciliKat.SiraNo = int.Parse(txtSiraNo.Text);
                _seciliKat.MasaSayisi = int.Parse(txtMasaSayisi.Text);

                _katRepo.Update(_seciliKat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _katRepo = new KatRepo();
            }
            finally
            {
                ListeyiDoldur();
            }
        }
        #endregion

        #region Karakter girilen karakter duzenleme
        private void txtMasaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSiraNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        #region Text karakter boyut sınırlandırılması
        private string _eskiText = "";
        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            if (txtAd.Text.Length == 30)
            {
                _eskiText = txtAd.Text;
            }
            if (txtAd.Text.Length == 31)
            {
                txtAd.Text = _eskiText;
                MessageBox.Show("En fazla 30 karakter girişi yapılabilmektedir.Lütfen tekrar giriş yapınız.");
            }

        }
        private void txtKod_TextChanged(object sender, EventArgs e)
        {
            if (txtKod.Text.Length == 5)
            {
                _eskiText = txtKod.Text;
            }
            if (txtKod.Text.Length == 6)
            {
                txtKod.Text = _eskiText;
                MessageBox.Show("En fazla 5 karakter girişi yapılabilmektedir.Lütfen tekrar giriş yapınız.");
            }
        }
        private void txtSiraNo_TextChanged(object sender, EventArgs e)
        {
            if (txtSiraNo.Text.Length == 4)
            {
                _eskiText = txtSiraNo.Text;
            }
            if (txtSiraNo.Text.Length == 5)
            {
                txtSiraNo.Text = _eskiText;
                MessageBox.Show("En fazla 4 basamaklı sayı girişi yapılabilmektedir. Lütfen tekrar giriş yapınız.");
            }
        }
        private void txtMasaSayisi_TextChanged(object sender, EventArgs e)
        {
            if (txtMasaSayisi.Text.Length == 6)
            {
                _eskiText = txtMasaSayisi.Text;
            }
            if (txtMasaSayisi.Text.Length == 7)
            {
                txtMasaSayisi.Text = _eskiText;
                MessageBox.Show("En fazla 6 basamaklı sayı girişi yapılabilmektedir. Lütfen tekrar giriş yapınız.");
            }
        }
        #endregion

        private Giris _frmGiris;
        private void btnKatGeri_Click(object sender, EventArgs e)
        {
            if (_frmGiris == null)
            {
                _frmGiris = new Giris();
            }
            _frmGiris.Show();
            this.Hide();
        }

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            FrmKafeBilgi frmKafeBilgi = new FrmKafeBilgi();
            frmKafeBilgi.Show();
            this.Hide();
           
        }

        private void txtSiraNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
 }

