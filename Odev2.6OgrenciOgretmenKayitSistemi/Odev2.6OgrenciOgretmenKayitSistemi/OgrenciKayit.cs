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
    public partial class OgrenciKayit : Form
    {
        public OgrenciKayit()
        {
            InitializeComponent();
        }

        private void OgrenciKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btn_ogrencikaydet_Click(object sender, EventArgs e)
        {
            string ogrencibilgileri = tb_isim.Text + "\n" +
                          tb_soyisim.Text + "\n" +
                          mtb_kimlik.Text + "\n" +
                          dtp_dogumtarihi.Value.ToString() + "\n" +
                          cb_kanGrubu.Text + "\n" +
                          mtb_telefon.Text + "\n" +
                          tb_mail.Text + "\n" +
                          tb_adres.Text + "\n" +
                          cb_sinif.Text + "\n" +
                          cb_sube.Text + "\n" +
                          cb_ogrencino.Text + "\n" +
                          tb_mezunokul.Text + "\n" +
                          dtp_kayittarihi.Value.ToString() + "\n";

            string path = "/Öğrenci Kayıtları";

            DirectoryInfo di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                di.Create();
            }
            string dosyadi = $"{tb_isim.Text}_{tb_soyisim.Text}_{mtb_kimlik.Text}.txt";
            string dosyayolu = path + "\\" + dosyadi;


            File.WriteAllText(dosyayolu, ogrencibilgileri);
            MessageBox.Show("Öğrenci Kaydedildi", "Kayıt", MessageBoxButtons.OK);
        }
        private void btn_bilgileriyazdir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Öğrenci Kayıt Dosyasını Seçin"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] ogrenciBilgileri = File.ReadAllLines(openFileDialog.FileName);
                    if (ogrenciBilgileri.Length >= 12)
                    {
                        tb_isim.Text = ogrenciBilgileri[0];
                        tb_soyisim.Text = ogrenciBilgileri[1];
                        mtb_kimlik.Text = ogrenciBilgileri[2];
                        dtp_dogumtarihi.Value = DateTime.Parse(ogrenciBilgileri[3]);
                        cb_kanGrubu.Text = ogrenciBilgileri[4];
                        mtb_telefon.Text = ogrenciBilgileri[5];
                        tb_mail.Text = ogrenciBilgileri[6];
                        tb_adres.Text = ogrenciBilgileri[7];
                        cb_sinif.Text = ogrenciBilgileri[8];
                        cb_sube.Text = ogrenciBilgileri[9];
                        cb_ogrencino.Text = ogrenciBilgileri[10];
                        tb_mezunokul.Text = ogrenciBilgileri[11];
                        dtp_kayittarihi.Value = DateTime.Parse(ogrenciBilgileri[12]);
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bilgileri eksik!", "Hata", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK);
                }
            }
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
                cb_sinif.Text = "";
                cb_sube.Text = "";
                cb_ogrencino.Text = "";
                tb_mezunokul.Text = "";
                dtp_kayittarihi.Value = DateTime.Now;

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

        private void btn_sınıf_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Sınıflar.txt dosyasını seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string filePath = openFileDialog.FileName;

                    if (File.Exists(filePath))
                    {
                        try
                        {
                            string[] siniflar = File.ReadAllLines(filePath, Encoding.UTF8);
                            cb_sinif.Items.Clear();
                            cb_sinif.Items.AddRange(siniflar);

                            if (cb_sinif.Items.Count > 0)
                                cb_sinif.SelectedIndex = 0;
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

        private void btn_ogrencinosec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "OgrenciNumaralari.txt dosyasını seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    if (File.Exists(filePath))
                    {
                        try
                        {
                            string[] ogrenciNumaralari = File.ReadAllLines(filePath, Encoding.UTF8);
                            cb_ogrencino.Items.Clear();
                            cb_ogrencino.Items.AddRange(ogrenciNumaralari);

                            if (cb_ogrencino.Items.Count > 0)
                                cb_ogrencino.SelectedIndex = 0;
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

        private void btn_ogretmensec_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Öğretmen Kayıtları Klasörünü Seçin";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] dosyalar = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.txt");
                    cb_ogretmen.Items.Clear();

                    foreach (var dosya in dosyalar)
                    {
                        try
                        {
                            string[] bilgiler = File.ReadAllLines(dosya);
                            if (bilgiler.Length >= 2) 
                            {
                                cb_ogretmen.Items.Add(bilgiler[0] + " " + bilgiler[1]); 
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK);
                        }
                    }

                    if (cb_ogretmen.Items.Count > 0)
                        cb_ogretmen.SelectedIndex = 0;
                }
            }
        }

        private void btn_ogrencibilgi_Click(object sender, EventArgs e)
        {
            string path = "/Öğrenci Kayıtları";

            lb_ogrenciler.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] dosyalar = di.GetFiles();

            int index = 1;
            foreach (FileInfo dosya in dosyalar)
            {
                string dosyaadi = Path.GetFileNameWithoutExtension(dosya.Name);
                lb_ogrenciler.Items.Add($"{index}. {dosyaadi}");
                index++;
            }
        }

        private void lb_ogrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOgrenciAdi;
            if (lb_ogrenciler.SelectedItem != null)
            {
                string selectedogrenci = lb_ogrenciler.SelectedItem.ToString();
                selectedOgrenciAdi = selectedogrenci.Split('.')[1].Trim();

            }
        }


    }
}

