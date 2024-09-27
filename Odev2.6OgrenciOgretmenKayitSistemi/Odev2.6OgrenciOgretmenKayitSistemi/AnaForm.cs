using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2._6OgrenciOgretmenKayitSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            KullaniciGiris frm = new KullaniciGiris();
            frm.ShowDialog();
            if (Kullanici.kullaniciAdi != "")
            {
                tssl_kullanici.Text = "Kullanıcı=" + Kullanici.kullaniciAdi;
            }
        }

        private void TSMI_OgretmenKayit_Click(object sender, EventArgs e)
        {
          
            bool isActive = false;
            Form[] ogretmenform = this.MdiChildren;
            foreach (Form item in ogretmenform)
            {
                if (item.GetType() == typeof(OgretmenKayit ))
                {
                    isActive = true;
                    item.Activate();
                }
            }
            if (!isActive)
            {
                OgretmenKayit  frm = new OgretmenKayit ();
                frm.Show();
            }
        }

        private void TSMI_OgrenciKayit_Click(object sender, EventArgs e)
        {
            bool isActive = false;
            Form[] ogrenciform = this.MdiChildren;
            foreach (Form item in ogrenciform)
            {
                if (item.GetType() == typeof(OgrenciKayit ))
                {
                    isActive = true;
                    item.Activate();
                }
            }
            if (!isActive)
            {
                OgrenciKayit frm = new OgrenciKayit();
                frm.Show();
            }
        }
     
        bool giris; 
        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }
        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!giris)
            {
                DialogResult result = MessageBox.Show("Çıkış Yapmak İstiyor musun?", "Çıkış Onay", MessageBoxButtons.OKCancel);
                if (result != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }
        private void TSMI_hangiogrenci_Click(object sender, EventArgs e)
        {
            bool isActive = false;
            Form[] ogr2form = this.MdiChildren;

            foreach (Form item in ogr2form)
            {
                if (item.GetType() == typeof(OgrenciOgretmen))
                {
                    isActive = true;
                    item.Activate();
                    break;
                }
            }

            if (!isActive)
            {
                OgrenciOgretmen frm = new OgrenciOgretmen();
                frm.Show();
            }
        }

    }
}
