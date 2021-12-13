using CafeCore.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeCore
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        
        private FrmKatEkle _frmKatEkle;

        private void btnfrmKatEkle_Click(object sender, EventArgs e)
        {
            if (_frmKatEkle == null)
            {
                _frmKatEkle = new FrmKatEkle();
            }
            _frmKatEkle.Show();
            this.Hide();
        }

        private FrmKategoriUrunEkle _frmKategoriUrunEkle;
        private void btnfrmMenuEkle_Click(object sender, EventArgs e)
        {
            if (_frmKategoriUrunEkle == null)
            {
                _frmKategoriUrunEkle = new FrmKategoriUrunEkle();
            }
            _frmKategoriUrunEkle.Show();
            this.Hide();
        }

        private FrmMasalar _frmMasalar;
        private void btnfrmMasaEkle_Click(object sender, EventArgs e)
        {
            if (_frmMasalar == null)
            {
                _frmMasalar = new FrmMasalar();
            }
            _frmMasalar.Show();
            this.Hide();
        }

        private FrmRaporlar _frmRaporlar;
        private void btnFrmRaporEkle_Click(object sender, EventArgs e)
        {
            if (_frmRaporlar == null)
            {
                _frmRaporlar = new FrmRaporlar();
            }
            _frmRaporlar.Show();
            this.Hide();
        }

        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
