namespace Odev2._6OgrenciOgretmenKayitSistemi
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_ogretmen = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_OgretmenKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_OgrenciKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.tssl_kullanici = new System.Windows.Forms.StatusStrip();
            this.TSMI_hangiogrenci = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ogretmen,
            this.öğrencilerToolStripMenuItem,
            this.TSMI_hangiogrenci});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_ogretmen
            // 
            this.TSMI_ogretmen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_OgretmenKayit});
            this.TSMI_ogretmen.Name = "TSMI_ogretmen";
            this.TSMI_ogretmen.Size = new System.Drawing.Size(107, 24);
            this.TSMI_ogretmen.Text = "Öğretmenler";
            // 
            // TSMI_OgretmenKayit
            // 
            this.TSMI_OgretmenKayit.Name = "TSMI_OgretmenKayit";
            this.TSMI_OgretmenKayit.Size = new System.Drawing.Size(196, 26);
            this.TSMI_OgretmenKayit.Text = "Öğretmen Kayıt";
            this.TSMI_OgretmenKayit.Click += new System.EventHandler(this.TSMI_OgretmenKayit_Click);
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_OgrenciKayit});
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            // 
            // TSMI_OgrenciKayit
            // 
            this.TSMI_OgrenciKayit.Name = "TSMI_OgrenciKayit";
            this.TSMI_OgrenciKayit.Size = new System.Drawing.Size(224, 26);
            this.TSMI_OgrenciKayit.Text = "Öğrenci Kayıt";
            this.TSMI_OgrenciKayit.Click += new System.EventHandler(this.TSMI_OgrenciKayit_Click);
            // 
            // tssl_kullanici
            // 
            this.tssl_kullanici.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tssl_kullanici.Location = new System.Drawing.Point(0, 428);
            this.tssl_kullanici.Name = "tssl_kullanici";
            this.tssl_kullanici.Size = new System.Drawing.Size(800, 22);
            this.tssl_kullanici.TabIndex = 3;
            // 
            // TSMI_hangiogrenci
            // 
            this.TSMI_hangiogrenci.Name = "TSMI_hangiogrenci";
            this.TSMI_hangiogrenci.Size = new System.Drawing.Size(351, 24);
            this.TSMI_hangiogrenci.Text = "Hangi Öğretmen Hangi Öğrenciye Eğitim Verecek";
            this.TSMI_hangiogrenci.Click += new System.EventHandler(this.TSMI_hangiogrenci_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tssl_kullanici);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ogretmen;
        private System.Windows.Forms.ToolStripMenuItem TSMI_OgretmenKayit;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_OgrenciKayit;
        private System.Windows.Forms.StatusStrip tssl_kullanici;
        private System.Windows.Forms.ToolStripMenuItem TSMI_hangiogrenci;
    }
}