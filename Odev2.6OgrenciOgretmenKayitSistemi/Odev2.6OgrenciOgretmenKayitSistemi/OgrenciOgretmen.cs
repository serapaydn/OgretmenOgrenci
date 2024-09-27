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

    public partial class OgrenciOgretmen : Form
    {
        string path;

        public OgrenciOgretmen()
        {
            InitializeComponent();
        }
       
        private void ogretmenogrenci_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderbrowser = new FolderBrowserDialog())
            {
                if (folderbrowser.ShowDialog() == DialogResult.OK)
                {
                    string secilenYol = folderbrowser.SelectedPath;
                    OgretmenKayitlariniYukle(secilenYol);
                }
            }
        }

        private void OgretmenKayitlariniYukle(string yol)
        {
            flowLayoutPanel1.Controls.Clear(); 

            string[] dosyalar = Directory.GetFiles(yol);
            foreach (string dosya in dosyalar)
            {
                string dosyaAdi = Path.GetFileName(dosya);

                Label etiket = new Label
                {
                    Text = dosyaAdi,
                    AutoSize = true,
                    Margin = new Padding(10),
                    Tag = dosya 
                };

                etiket.Click += OgretmenEtiketi_Click;
                flowLayoutPanel1.Controls.Add(etiket);
            }
        }

        private void OgretmenEtiketi_Click(object sender, EventArgs e)
        {
            Label tıklananEtiket = sender as Label;
            if (tıklananEtiket != null)
            {
                string dosyaYolu = tıklananEtiket.Tag.ToString();
                OgrencileriYukle(dosyaYolu);
            }
        }

        private void OgrencileriYukle(string ogretmenDosyaYolu)
        {
            lb_ogrenciler.Items.Clear();

            string[] ogretmenDetaylari;
            try
            {
                ogretmenDetaylari = File.ReadAllLines(ogretmenDosyaYolu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğretmen dosyası okunamadı: " + ex.Message);
                return;
            }

            if (ogretmenDetaylari.Length > 11) 
            {
                string ogretmenSube = ogretmenDetaylari[11]; 

                string ogrenciYolu = @"/Öğrenci Kayıtları"; 
                string[] ogrenciDosyaları;

                try
                {
                    ogrenciDosyaları = Directory.GetFiles(ogrenciYolu, "*.txt");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğrenci kayıtları yolu okunamadı: " + ex.Message);
                    return;
                }

                bool ogrenciVarMi = false; 

                foreach (string ogrenciDosyası in ogrenciDosyaları)
                {
                    string[] ogrenciDetaylari;
                    try
                    {
                        ogrenciDetaylari = File.ReadAllLines(ogrenciDosyası);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Öğrenci dosyası okunamadı: " + ex.Message);
                        continue;
                    }

                    if (ogrenciDetaylari.Length > 9) 
                    {
                        string ogrenciSube = ogrenciDetaylari[9]; 
                        if (ogrenciSube.Equals(ogretmenSube, StringComparison.OrdinalIgnoreCase))
                        {
                            string ogrenciSinif = ogrenciDetaylari[8];
                            lb_ogrenciler.Items.Add($"{ogrenciDetaylari[0]} {ogrenciDetaylari[1]} - Sınıf: {ogrenciSinif}, Şube: {ogrenciSube}");
                            ogrenciVarMi = true; 
                        }
                    }
                }

                if (!ogrenciVarMi)
                {
                    MessageBox.Show("Henüz öğrenci yok.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Öğretmen dosyası beklenen formatta değil.");
            }
        }

    }
}
    



    
    






