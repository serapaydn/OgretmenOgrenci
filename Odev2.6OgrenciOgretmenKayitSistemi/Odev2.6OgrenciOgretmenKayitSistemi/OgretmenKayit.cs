using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2._6OgrenciOgretmenKayitSistemi
{
    public partial class OgretmenKayit : Form
    {
        public OgretmenKayit()
        {
            InitializeComponent();
        }

        private void OgretmenKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btn_ogretmenkaydet_Click(object sender, EventArgs e)
        {
            string ogretmenbilgileri = tb_isim.Text + "\n" +
                    tb_soyisim.Text + "\n" +
                    mtb_kimlik.Text + "\n" +
                    dtp_dogumtarihi.Value.ToString() + "\n" +
                    cb_kanGrubu.Text + "\n" +
                    mtb_telefon.Text + "\n" +
                    tb_mail.Text + "\n" +
                    tb_adres.Text + "\n" +
                    cb_mezun.Text + "\n" +
                    cb_bolum.Text + "\n" +
                    cb_egitim.Text + "\n" +
                    cb_sube.Text + "\n";

            string path = "/Öğretmen Kayıtları";

            DirectoryInfo di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                di.Create();
            }
            string dosyadi = $"{tb_isim.Text}_{tb_soyisim.Text}_{mtb_kimlik.Text}.txt";
            string dosyayolu = path + "\\" + dosyadi;


            File.WriteAllText(dosyayolu, ogretmenbilgileri );
            MessageBox.Show("Öğretmen Kaydedildi", "Kayıt", MessageBoxButtons.OK);

        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıt işlemine devam etmek istiyor musun?", "İptal", MessageBoxButtons.YesNo);

            if (sonuc == DialogResult.No)
            {
                tb_isim.Text = "";
                tb_soyisim.Text = "";
                mtb_kimlik.Text = "";
                dtp_dogumtarihi.Value = DateTime.Now; 
                cb_kanGrubu.SelectedIndex = -1;
                mtb_telefon.Text = "";
                tb_mail.Text = "";
                tb_adres.Text = "";
                cb_mezun.SelectedIndex = -1; 
                cb_bolum.SelectedIndex = -1; 
                cb_egitim.SelectedIndex = -1; 
                cb_sube.SelectedIndex = -1; 
            }
        }
        private void btn_bilgileriyazdir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                openFileDialog.Title = "Öğretmen Kayıt Dosyasını Seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                       
                        string[] bilgiler = File.ReadAllLines(openFileDialog.FileName);

                        
                        if (bilgiler.Length >= 12) 
                        {
                           
                            tb_isim.Text = bilgiler[0];
                            tb_soyisim.Text = bilgiler[1]; 
                            mtb_kimlik.Text = bilgiler[2]; 
                            dtp_dogumtarihi.Value = DateTime.Parse(bilgiler[3]); 
                            cb_kanGrubu.Text = bilgiler[4]; 
                            mtb_telefon.Text = bilgiler[5]; 
                            tb_mail.Text = bilgiler[6]; 
                            tb_adres.Text = bilgiler[7]; 
                            cb_mezun.Text = bilgiler[8]; 
                            cb_bolum.Text = bilgiler[9]; 
                            cb_egitim.Text = bilgiler[10]; 
                            cb_sube.Text = bilgiler[11]; 
                        }
                        else
                        {
                            MessageBox.Show("Dosyada yeterli bilgi yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null)
            {
                this.MdiParent.Activate();

            }
            this.Hide();
        }
        private void btn_ogretmenbilgi_Click(object sender, EventArgs e)
        {
            string path = "/Öğretmen Kayıtları";

            lb_ogretmenler.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] dosyalar = di.GetFiles();

            int index = 1;
            foreach (FileInfo dosya in dosyalar)
            {
                string dosyaadi = Path.GetFileNameWithoutExtension(dosya.Name);
                lb_ogretmenler.Items.Add($"{index}. {dosyaadi}");
                index++;
            }
        }
        private void lb_ogretmenler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOgretmenAdi;
            if (lb_ogretmenler.SelectedItem != null)
            {
                string selectedogretmen = lb_ogretmenler.SelectedItem.ToString();
                selectedOgretmenAdi = selectedogretmen.Split('.')[1].Trim();

            }
        }

        private void btn_subesec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Subeler.txt dosyasını seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    if (File.Exists(filePath))
                    {
                        try
                        {
                            string[] subeler = File.ReadAllLines(filePath, Encoding.UTF8);
                            cb_sube.Items.Clear();
                            cb_sube.Items.AddRange(subeler);

                            if (cb_sube.Items.Count > 0)
                                cb_sube.SelectedIndex = 0;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seçilen dosya bulunamadı.", "Hata", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
