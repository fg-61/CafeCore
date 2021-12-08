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
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
        }

        private void Masalar_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            KatDoldur();
            MasaDoldur();
        }

        private void MasaDoldur()
        {
            throw new NotImplementedException();
        }

        private void KatDoldur()
        {
            throw new NotImplementedException();
        }
    }
}
