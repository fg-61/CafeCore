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

        private void btnfrmKatEkle_Click(object sender, EventArgs e)
        {
            FrmKatEkle frmKatEkle = new FrmKatEkle();
            this.Hide();
            frmKatEkle.Show();
        }

        private void btnfrmMenuEkle_Click(object sender, EventArgs e)
        {
            FrmKategoriUrunEkle frmKategoriUrunEkle = new FrmKategoriUrunEkle();
            this.Hide();
            frmKategoriUrunEkle.Show();
        }

        private void btnfrmMasaEkle_Click(object sender, EventArgs e)
        {
            FrmMasalar frmMasalar = new FrmMasalar();
            this.Hide();
            frmMasalar.Show();
        }
    }
}
