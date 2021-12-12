using CafeCore.Data;
using CafeCore.Model;
using CafeCore.Repository;
using Microsoft.EntityFrameworkCore;
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

        private CafeContext _dbContext = new CafeContext();
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
            lstKat.Columns.Add("Kısaltma Kodu");
            lstKat.Columns.Add("Kat Sıra No");
            lstKat.Columns.Add("Masa Sayısı");

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
            lstKat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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


        private void btnEkle1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dbContext.Katlar.Any(x => x.Ad.ToLower() == txtAd.Text.ToLower()))
                {
                    throw new Exception("Farklı bir kat adı ismi giriniz !!");
                }
                if (_dbContext.Katlar.Any(x => x.Kodu == txtKod.Text.ToLower()))
                {
                    throw new Exception("Farklı bir kısaltma kodu giriniz !!");
                }
                if(_dbContext.Katlar.Any(x => x.SiraNo.ToString() == txtSiraNo.Text))
                {
                    throw new Exception("Farklı bir kat sıra numarası giriniz !!");
                }



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
                        Ad = $"{ yeniKat.Kodu } - Masa { i + 1 }"
                    };
                    yeniKat.Masalar.Add(yeniMasa);
                }
                _katRepo.Add(yeniKat);
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
        private Kat _seciliKat1;
        private void btnSil1_Click(object sender, EventArgs e)

        {
            if (lstKat.SelectedItems.Count == 0) return;
            _seciliKat1 = lstKat.SelectedItems[0].Tag as Kat;
            try
            {
                var Kat = _dbContext.Katlar.Find(_seciliKat1.Id);
                _dbContext.Katlar.Remove(Kat);

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


        private void btnGuncelle1_Click(object sender, EventArgs e)

        {
            if (lstKat.SelectedItems.Count == 0) return;
            _seciliKat1 = lstKat.SelectedItems[0].Tag as Kat;

            try
            {
                _seciliKat1.Ad = txtAd.Text;
                _seciliKat1.Kodu = txtKod.Text;
                _seciliKat1.SiraNo = int.Parse(txtSiraNo.Text);
                _seciliKat1.MasaSayisi = int.Parse(txtMasaSayisi.Text);

                _dbContext.Katlar.Update(_seciliKat1);
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

        private void btnKattGeri_Click(object sender, EventArgs e)
        {
            Giris frmGiris = new Giris();
            frmGiris.Show();
            this.Hide();
        }
        
    }
}
