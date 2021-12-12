﻿using CafeCore.Data;
using CafeCore.Model;
using CafeCore.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CafeCore.Forms
{
    public partial class FrmMasalar : Form
    {
        public FrmMasalar()
        {
            InitializeComponent();
        }
        CafeContext _dbContext = new CafeContext();
        Color defaultKatColor = Color.LightGray, seciliKatColor = Color.RoyalBlue, seciliMasaColor = Color.OrangeRed;

        private void Masalar_Load(object sender, EventArgs e)
        {
            KatDoldur();
        }

        private void KatDoldur()
        {
            flpKatlar.Controls.Clear();
            int katButonYukseklik = 100;
            int katButonGenislik = 100;

            var katlar = _dbContext.Katlar.Include(x => x.Masalar).Where(x => x.Masalar.Count > 0 && x.IsDeleted == false).OrderBy(x => x.SiraNo).ToList();
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

        private Kat _seciliKat;
        private void BtnKat_Click(object sender, EventArgs e)
        {
            Button btnKat = sender as Button;
            _seciliKat = (Kat)(btnKat.Tag);

            flpMasalar.Controls.Clear();
            int masaButonYukseklik = 100;
            int masaButonGenislik = 100;

            var masalar = _dbContext.Masalar.Where(x => x.KatId == _seciliKat.Id).OrderBy(x => x.No).ToList();
            for (int i = 0; i < _seciliKat.MasaSayisi; i++)
            {
                Masa yeni = masalar[i];
                Button btnMasa = new Button()
                {
                    Text = yeni.Ad,
                    Size = new Size(masaButonGenislik, masaButonYukseklik),
                    BackColor = defaultKatColor,
                    Tag = yeni
                };
                Renklendir(btnMasa);
                btnMasa.Click += BtnMasa_Click;
                flpMasalar.Controls.Add(btnMasa);

            }
            foreach (Button button in flpKatlar.Controls)
            {
                button.BackColor = defaultKatColor;
                if (button.Text == btnKat.Text)
                {
                    button.BackColor = seciliKatColor;
                }
            }
        }

        private void Renklendir(Button seciliButon)
        {
            var seciliMasa = (Masa)(seciliButon.Tag);
            if (seciliMasa.Durum == true)
            {
                seciliButon.BackColor = seciliMasaColor;
            }

        }
        private Giris _frmGiris = new Giris();
        private void button1_Click(object sender, EventArgs e)
        {
            if (_frmGiris == null || _frmGiris.IsDisposed)
            {
                _frmGiris = new Giris();
            }
            _frmGiris.Show();
            this.Hide();
        }

        private FrmSiparisler _frmSiparisler;
        private void BtnMasa_Click(object sender, EventArgs e)
        {
            Button btnMasa = sender as Button;

            if (_frmSiparisler == null || _frmSiparisler.IsDisposed)
            {
                _frmSiparisler = new FrmSiparisler();
            }

            _frmSiparisler._seciliMasa = btnMasa.Tag as Masa;
            _frmSiparisler.ShowDialog();
            this.Hide();
        }
    }
}
