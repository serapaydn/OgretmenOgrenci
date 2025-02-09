﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2._6OgrenciOgretmenKayitSistemi
{
    public partial class KullaniciGiris : Form
    {
        bool giris;
        public KullaniciGiris()
        {
            InitializeComponent();
            giris = false;
            
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty (tb_kullaniciadi .Text))
            {
                if(!string .IsNullOrEmpty (tb_sifre .Text))
                {
                    if(tb_kullaniciadi .Text =="admin"&& tb_sifre .Text == "123")
                    {
                        giris = true;
                        Kullanici.kullaniciAdi = "Yazılım Koleji";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Şifre boş bırakılamaz");
                }
            }
            else
            {
                MessageBox.Show("Kuallanıcı Adı boş bırakılamaz");
            }
        }

        private void KullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!giris)
            {
                Application.Exit();
            }
        }

        private void KullaniciGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!giris )
            {
                DialogResult result = MessageBox.Show("Çıkış Yapmak İstiyor musun?", "Çıkış Onay", MessageBoxButtons.OKCancel);
                if (result != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
