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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            FrmKatEkle frmKatEkle = new FrmKatEkle();
            frmKatEkle.Show();
            this.Hide();
        }
    }
    }

