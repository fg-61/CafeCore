using CafeCore.Data;
using CafeCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CafeCore.Forms
{
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
        }
        CafeContext _dbContext = new CafeContext();
        private void Masalar_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            KatDoldur();
            MasaDoldur();
        }
        Color defaultKatColor = Color.LightGray, seciliKatColor = Color.RoyalBlue;
        private void KatDoldur()
        {
            flpKatlar.Controls.Clear();
            int katButonYukseklik = flpKatlar.Height - 10;
            int katButonGenislik = 120;

            var katlar = _dbContext.Katlar.Include(x => x.Masalar).OrderBy(x => x.SiraNo).ToList();

            for (int i = 0; i < katlar.Count; i++)
            {
                Kat yeni = katlar[i];
                Button btn = new Button()
                {
                    Text = yeni.Ad,
                    Size = new Size(katButonGenislik, katButonYukseklik),
                    BackColor = defaultKatColor,
                    Tag = yeni
                };
                btn.Click += BtnKat_Click;
                flpKatlar.Controls.Add(btn);
            }


        }

        private void BtnKat_Click(object sender, EventArgs e)
        {
            MasaDoldur();
        }

        private void MasaDoldur()
        {
            flpMasalar.Controls.Clear();
            int masaButonYukseklik = 150;
            int masaButonGenislik = 120;

            var masalar = _dbContext.Masalar.OrderBy(x => x.SiraNo).ToList();

            for (int i = 0; i < katlar.Count; i++)
            {
                Kat yeni = katlar[i];
                Button btn = new Button()
                {
                    Text = yeni.Ad,
                    Size = new Size(katButonGenislik, katButonYukseklik),
                    BackColor = defaultKatColor,
                    Tag = yeni
                };
                btn.Click += BtnKat_Click;
                flpKatlar.Controls.Add(btn);
            }


    }
}
