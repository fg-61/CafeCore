using CafeCore.Data;
using CafeCore.Model;
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
    public partial class FrmKafeBilgi : Form
    {
        public FrmKafeBilgi()
        {
            InitializeComponent();
        }
        CafeContext _dbContext = new CafeContext();
        KafeBilgiRepo repo = new KafeBilgiRepo();
        bool kayitli = true;
       

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            FrmKatEkle frmKatEkle = new FrmKatEkle();
            frmKatEkle.Show();
            this.Hide();
        }

        private void FrmKafeBilgi_Load(object sender, EventArgs e)
        {
            try
            {
                var result = repo.Get().FirstOrDefault();
                if (result != null)
                {
                    txtKafeAdi.Text = result.Ad;
                    txtTelefon.Text = result.Telefon;
                    txtAdres.Text = result.Adres;
                }
                else
                {
                    kayitli = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                KafeBilgi kafeBilgi = new KafeBilgi();
                string ad = txtKafeAdi.Text;
                string telefon = txtTelefon.Text;
                string adres = txtAdres.Text;
                if (ad != null && telefon != null && adres != null)
                {
                    kafeBilgi.Ad = ad;
                    kafeBilgi.Telefon = telefon;
                    kafeBilgi.Adres = adres;
                }
                if (kayitli)
                {
                    repo.Update(kafeBilgi);
                    MessageBox.Show("Güncelleme işlemi başarılı bir şekilde tamamlandı.");
                }
                else
                {
                    repo.Add(kafeBilgi);
                    MessageBox.Show("Ekleme işlemi başarılı bir şekilde tamamlandı.");
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    }

