namespace Odev2._6OgrenciOgretmenKayitSistemi
{
    partial class OgrenciKayit
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_geri = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_kisisel = new System.Windows.Forms.TabPage();
            this.cb_kanGrubu = new System.Windows.Forms.ComboBox();
            this.dtp_dogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.mtb_kimlik = new System.Windows.Forms.MaskedTextBox();
            this.tb_soyisim = new System.Windows.Forms.TextBox();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.lbl_kangrubu = new System.Windows.Forms.Label();
            this.lbl_dogumtarihi = new System.Windows.Forms.Label();
            this.lbl_kimlik = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.tp_iletisim = new System.Windows.Forms.TabPage();
            this.tb_adres = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.mtb_telefon = new System.Windows.Forms.MaskedTextBox();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telefonno = new System.Windows.Forms.Label();
            this.tp_egitim = new System.Windows.Forms.TabPage();
            this.btn_ogretmensec = new System.Windows.Forms.Button();
            this.btn_ogrencinosec = new System.Windows.Forms.Button();
            this.btn_subesec = new System.Windows.Forms.Button();
            this.btn_sınıf = new System.Windows.Forms.Button();
            this.cb_sinif = new System.Windows.Forms.ComboBox();
            this.cb_sube = new System.Windows.Forms.ComboBox();
            this.cb_ogretmen = new System.Windows.Forms.ComboBox();
            this.cb_ogrencino = new System.Windows.Forms.ComboBox();
            this.tb_mezunokul = new System.Windows.Forms.TextBox();
            this.lbl_ogretmen = new System.Windows.Forms.Label();
            this.lbl_ogrencino = new System.Windows.Forms.Label();
            this.lbl_mezunokul = new System.Windows.Forms.Label();
            this.lbl_sube = new System.Windows.Forms.Label();
            this.lbl_sınıf = new System.Windows.Forms.Label();
            this.tp_kayit = new System.Windows.Forms.TabPage();
            this.dtp_kayittarihi = new System.Windows.Forms.DateTimePicker();
            this.lbl_kayittarihi = new System.Windows.Forms.Label();
            this.btn_ogrencikaydet = new System.Windows.Forms.Button();
            this.btn_bilgileriyazdir = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.lb_ogrenciler = new System.Windows.Forms.ListBox();
            this.btn_ogrencibilgi = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_kisisel.SuspendLayout();
            this.tp_iletisim.SuspendLayout();
            this.tp_egitim.SuspendLayout();
            this.tp_kayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_geri);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ogrencikaydet);
            this.splitContainer1.Panel1.Controls.Add(this.btn_bilgileriyazdir);
            this.splitContainer1.Panel1.Controls.Add(this.btn_iptal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lb_ogrenciler);
            this.splitContainer1.Panel2.Controls.Add(this.btn_ogrencibilgi);
            this.splitContainer1.Size = new System.Drawing.Size(800, 456);
            this.splitContainer1.SplitterDistance = 573;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_geri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_geri.Location = new System.Drawing.Point(472, 395);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(96, 34);
            this.btn_geri.TabIndex = 14;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_kisisel);
            this.tabControl1.Controls.Add(this.tp_iletisim);
            this.tabControl1.Controls.Add(this.tp_egitim);
            this.tabControl1.Controls.Add(this.tp_kayit);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 377);
            this.tabControl1.TabIndex = 6;
            // 
            // tp_kisisel
            // 
            this.tp_kisisel.Controls.Add(this.cb_kanGrubu);
            this.tp_kisisel.Controls.Add(this.dtp_dogumtarihi);
            this.tp_kisisel.Controls.Add(this.mtb_kimlik);
            this.tp_kisisel.Controls.Add(this.tb_soyisim);
            this.tp_kisisel.Controls.Add(this.tb_isim);
            this.tp_kisisel.Controls.Add(this.lbl_kangrubu);
            this.tp_kisisel.Controls.Add(this.lbl_dogumtarihi);
            this.tp_kisisel.Controls.Add(this.lbl_kimlik);
            this.tp_kisisel.Controls.Add(this.lbl_soyisim);
            this.tp_kisisel.Controls.Add(this.lbl_isim);
            this.tp_kisisel.Location = new System.Drawing.Point(4, 25);
            this.tp_kisisel.Name = "tp_kisisel";
            this.tp_kisisel.Padding = new System.Windows.Forms.Padding(3);
            this.tp_kisisel.Size = new System.Drawing.Size(548, 348);
            this.tp_kisisel.TabIndex = 0;
            this.tp_kisisel.Text = "Kişisel Bilgiler";
            this.tp_kisisel.UseVisualStyleBackColor = true;
            // 
            // cb_kanGrubu
            // 
            this.cb_kanGrubu.FormattingEnabled = true;
            this.cb_kanGrubu.Items.AddRange(new object[] {
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "AB Rh+",
            "AB Rh-",
            "O Rh+",
            "O Rh-"});
            this.cb_kanGrubu.Location = new System.Drawing.Point(36, 296);
            this.cb_kanGrubu.Name = "cb_kanGrubu";
            this.cb_kanGrubu.Size = new System.Drawing.Size(173, 24);
            this.cb_kanGrubu.TabIndex = 5;
            // 
            // dtp_dogumtarihi
            // 
            this.dtp_dogumtarihi.Location = new System.Drawing.Point(36, 231);
            this.dtp_dogumtarihi.Name = "dtp_dogumtarihi";
            this.dtp_dogumtarihi.Size = new System.Drawing.Size(195, 22);
            this.dtp_dogumtarihi.TabIndex = 4;
            // 
            // mtb_kimlik
            // 
            this.mtb_kimlik.Location = new System.Drawing.Point(36, 161);
            this.mtb_kimlik.Mask = "00000000000";
            this.mtb_kimlik.Name = "mtb_kimlik";
            this.mtb_kimlik.Size = new System.Drawing.Size(173, 22);
            this.mtb_kimlik.TabIndex = 3;
            // 
            // tb_soyisim
            // 
            this.tb_soyisim.Location = new System.Drawing.Point(36, 104);
            this.tb_soyisim.Name = "tb_soyisim";
            this.tb_soyisim.Size = new System.Drawing.Size(173, 22);
            this.tb_soyisim.TabIndex = 2;
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(36, 46);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(173, 22);
            this.tb_isim.TabIndex = 1;
            // 
            // lbl_kangrubu
            // 
            this.lbl_kangrubu.AutoSize = true;
            this.lbl_kangrubu.Location = new System.Drawing.Point(36, 267);
            this.lbl_kangrubu.Name = "lbl_kangrubu";
            this.lbl_kangrubu.Size = new System.Drawing.Size(72, 16);
            this.lbl_kangrubu.TabIndex = 9;
            this.lbl_kangrubu.Text = "Kan Grubu:";
            // 
            // lbl_dogumtarihi
            // 
            this.lbl_dogumtarihi.AutoSize = true;
            this.lbl_dogumtarihi.Location = new System.Drawing.Point(36, 201);
            this.lbl_dogumtarihi.Name = "lbl_dogumtarihi";
            this.lbl_dogumtarihi.Size = new System.Drawing.Size(91, 16);
            this.lbl_dogumtarihi.TabIndex = 8;
            this.lbl_dogumtarihi.Text = "Doğum Tarihi:";
            // 
            // lbl_kimlik
            // 
            this.lbl_kimlik.AutoSize = true;
            this.lbl_kimlik.Location = new System.Drawing.Point(33, 142);
            this.lbl_kimlik.Name = "lbl_kimlik";
            this.lbl_kimlik.Size = new System.Drawing.Size(133, 16);
            this.lbl_kimlik.TabIndex = 7;
            this.lbl_kimlik.Text = "T.C. Kimlik Numarası:";
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(36, 85);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(58, 16);
            this.lbl_soyisim.TabIndex = 6;
            this.lbl_soyisim.Text = "Soyisim:";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(33, 27);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(34, 16);
            this.lbl_isim.TabIndex = 5;
            this.lbl_isim.Text = "İsim:";
            // 
            // tp_iletisim
            // 
            this.tp_iletisim.Controls.Add(this.tb_adres);
            this.tp_iletisim.Controls.Add(this.tb_mail);
            this.tp_iletisim.Controls.Add(this.mtb_telefon);
            this.tp_iletisim.Controls.Add(this.lbl_adres);
            this.tp_iletisim.Controls.Add(this.lbl_email);
            this.tp_iletisim.Controls.Add(this.lbl_telefonno);
            this.tp_iletisim.Location = new System.Drawing.Point(4, 25);
            this.tp_iletisim.Name = "tp_iletisim";
            this.tp_iletisim.Padding = new System.Windows.Forms.Padding(3);
            this.tp_iletisim.Size = new System.Drawing.Size(548, 348);
            this.tp_iletisim.TabIndex = 1;
            this.tp_iletisim.Text = "İletişim Bilgileri";
            this.tp_iletisim.UseVisualStyleBackColor = true;
            // 
            // tb_adres
            // 
            this.tb_adres.Location = new System.Drawing.Point(30, 192);
            this.tb_adres.Multiline = true;
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_adres.Size = new System.Drawing.Size(191, 80);
            this.tb_adres.TabIndex = 8;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(27, 114);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(194, 22);
            this.tb_mail.TabIndex = 7;
            // 
            // mtb_telefon
            // 
            this.mtb_telefon.Location = new System.Drawing.Point(30, 46);
            this.mtb_telefon.Mask = "(999) 000-0000";
            this.mtb_telefon.Name = "mtb_telefon";
            this.mtb_telefon.Size = new System.Drawing.Size(191, 22);
            this.mtb_telefon.TabIndex = 6;
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Location = new System.Drawing.Point(30, 160);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(46, 16);
            this.lbl_adres.TabIndex = 5;
            this.lbl_adres.Text = "Adres:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(27, 95);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(48, 16);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_telefonno
            // 
            this.lbl_telefonno.AutoSize = true;
            this.lbl_telefonno.Location = new System.Drawing.Point(24, 27);
            this.lbl_telefonno.Name = "lbl_telefonno";
            this.lbl_telefonno.Size = new System.Drawing.Size(117, 16);
            this.lbl_telefonno.TabIndex = 3;
            this.lbl_telefonno.Text = "Telefon Numarası:";
            // 
            // tp_egitim
            // 
            this.tp_egitim.Controls.Add(this.btn_ogretmensec);
            this.tp_egitim.Controls.Add(this.btn_ogrencinosec);
            this.tp_egitim.Controls.Add(this.btn_subesec);
            this.tp_egitim.Controls.Add(this.btn_sınıf);
            this.tp_egitim.Controls.Add(this.cb_sinif);
            this.tp_egitim.Controls.Add(this.cb_sube);
            this.tp_egitim.Controls.Add(this.cb_ogretmen);
            this.tp_egitim.Controls.Add(this.cb_ogrencino);
            this.tp_egitim.Controls.Add(this.tb_mezunokul);
            this.tp_egitim.Controls.Add(this.lbl_ogretmen);
            this.tp_egitim.Controls.Add(this.lbl_ogrencino);
            this.tp_egitim.Controls.Add(this.lbl_mezunokul);
            this.tp_egitim.Controls.Add(this.lbl_sube);
            this.tp_egitim.Controls.Add(this.lbl_sınıf);
            this.tp_egitim.Location = new System.Drawing.Point(4, 25);
            this.tp_egitim.Name = "tp_egitim";
            this.tp_egitim.Size = new System.Drawing.Size(548, 348);
            this.tp_egitim.TabIndex = 2;
            this.tp_egitim.Text = "Eğitim Bilgileri";
            this.tp_egitim.UseVisualStyleBackColor = true;
            // 
            // btn_ogretmensec
            // 
            this.btn_ogretmensec.Location = new System.Drawing.Point(231, 283);
            this.btn_ogretmensec.Name = "btn_ogretmensec";
            this.btn_ogretmensec.Size = new System.Drawing.Size(181, 24);
            this.btn_ogretmensec.TabIndex = 16;
            this.btn_ogretmensec.Text = "Öğretmen Seç";
            this.btn_ogretmensec.UseVisualStyleBackColor = true;
            this.btn_ogretmensec.Click += new System.EventHandler(this.btn_ogretmensec_Click);
            // 
            // btn_ogrencinosec
            // 
            this.btn_ogrencinosec.Location = new System.Drawing.Point(231, 227);
            this.btn_ogrencinosec.Name = "btn_ogrencinosec";
            this.btn_ogrencinosec.Size = new System.Drawing.Size(181, 24);
            this.btn_ogrencinosec.TabIndex = 16;
            this.btn_ogrencinosec.Text = "Öğrenci Numarası Seç";
            this.btn_ogrencinosec.UseVisualStyleBackColor = true;
            this.btn_ogrencinosec.Click += new System.EventHandler(this.btn_ogrencinosec_Click);
            // 
            // btn_subesec
            // 
            this.btn_subesec.Location = new System.Drawing.Point(231, 173);
            this.btn_subesec.Name = "btn_subesec";
            this.btn_subesec.Size = new System.Drawing.Size(101, 23);
            this.btn_subesec.TabIndex = 16;
            this.btn_subesec.Text = "Şube Seç";
            this.btn_subesec.UseVisualStyleBackColor = true;
            this.btn_subesec.Click += new System.EventHandler(this.btn_subesec_Click);
            // 
            // btn_sınıf
            // 
            this.btn_sınıf.Location = new System.Drawing.Point(231, 115);
            this.btn_sınıf.Name = "btn_sınıf";
            this.btn_sınıf.Size = new System.Drawing.Size(101, 23);
            this.btn_sınıf.TabIndex = 16;
            this.btn_sınıf.Text = "Sınıf Seç";
            this.btn_sınıf.UseVisualStyleBackColor = true;
            this.btn_sınıf.Click += new System.EventHandler(this.btn_sınıf_Click);
            // 
            // cb_sinif
            // 
            this.cb_sinif.FormattingEnabled = true;
            this.cb_sinif.Location = new System.Drawing.Point(38, 115);
            this.cb_sinif.Name = "cb_sinif";
            this.cb_sinif.Size = new System.Drawing.Size(178, 24);
            this.cb_sinif.TabIndex = 10;
            // 
            // cb_sube
            // 
            this.cb_sube.FormattingEnabled = true;
            this.cb_sube.Location = new System.Drawing.Point(42, 172);
            this.cb_sube.Name = "cb_sube";
            this.cb_sube.Size = new System.Drawing.Size(174, 24);
            this.cb_sube.TabIndex = 11;
            // 
            // cb_ogretmen
            // 
            this.cb_ogretmen.FormattingEnabled = true;
            this.cb_ogretmen.Location = new System.Drawing.Point(42, 283);
            this.cb_ogretmen.Name = "cb_ogretmen";
            this.cb_ogretmen.Size = new System.Drawing.Size(174, 24);
            this.cb_ogretmen.TabIndex = 13;
            // 
            // cb_ogrencino
            // 
            this.cb_ogrencino.FormattingEnabled = true;
            this.cb_ogrencino.Location = new System.Drawing.Point(42, 227);
            this.cb_ogrencino.Name = "cb_ogrencino";
            this.cb_ogrencino.Size = new System.Drawing.Size(174, 24);
            this.cb_ogrencino.TabIndex = 12;
            // 
            // tb_mezunokul
            // 
            this.tb_mezunokul.Location = new System.Drawing.Point(38, 48);
            this.tb_mezunokul.Name = "tb_mezunokul";
            this.tb_mezunokul.Size = new System.Drawing.Size(174, 22);
            this.tb_mezunokul.TabIndex = 9;
            // 
            // lbl_ogretmen
            // 
            this.lbl_ogretmen.AutoSize = true;
            this.lbl_ogretmen.Location = new System.Drawing.Point(35, 263);
            this.lbl_ogretmen.Name = "lbl_ogretmen";
            this.lbl_ogretmen.Size = new System.Drawing.Size(69, 16);
            this.lbl_ogretmen.TabIndex = 3;
            this.lbl_ogretmen.Text = "Öğretmen:\r\n";
            // 
            // lbl_ogrencino
            // 
            this.lbl_ogrencino.AutoSize = true;
            this.lbl_ogrencino.Location = new System.Drawing.Point(35, 207);
            this.lbl_ogrencino.Name = "lbl_ogrencino";
            this.lbl_ogrencino.Size = new System.Drawing.Size(118, 16);
            this.lbl_ogrencino.TabIndex = 3;
            this.lbl_ogrencino.Text = "Öğrenci Numarası:";
            // 
            // lbl_mezunokul
            // 
            this.lbl_mezunokul.AutoSize = true;
            this.lbl_mezunokul.Location = new System.Drawing.Point(35, 20);
            this.lbl_mezunokul.Name = "lbl_mezunokul";
            this.lbl_mezunokul.Size = new System.Drawing.Size(125, 16);
            this.lbl_mezunokul.TabIndex = 2;
            this.lbl_mezunokul.Text = "Mezun Olduğu Okul:";
            // 
            // lbl_sube
            // 
            this.lbl_sube.AutoSize = true;
            this.lbl_sube.Location = new System.Drawing.Point(35, 152);
            this.lbl_sube.Name = "lbl_sube";
            this.lbl_sube.Size = new System.Drawing.Size(42, 16);
            this.lbl_sube.TabIndex = 1;
            this.lbl_sube.Text = "Şube:";
            // 
            // lbl_sınıf
            // 
            this.lbl_sınıf.AutoSize = true;
            this.lbl_sınıf.Location = new System.Drawing.Point(35, 95);
            this.lbl_sınıf.Name = "lbl_sınıf";
            this.lbl_sınıf.Size = new System.Drawing.Size(35, 16);
            this.lbl_sınıf.TabIndex = 0;
            this.lbl_sınıf.Text = "Sınıf:";
            // 
            // tp_kayit
            // 
            this.tp_kayit.Controls.Add(this.dtp_kayittarihi);
            this.tp_kayit.Controls.Add(this.lbl_kayittarihi);
            this.tp_kayit.Location = new System.Drawing.Point(4, 25);
            this.tp_kayit.Name = "tp_kayit";
            this.tp_kayit.Size = new System.Drawing.Size(548, 348);
            this.tp_kayit.TabIndex = 4;
            this.tp_kayit.Text = "Kayıt Bilgileri";
            this.tp_kayit.UseVisualStyleBackColor = true;
            // 
            // dtp_kayittarihi
            // 
            this.dtp_kayittarihi.Location = new System.Drawing.Point(28, 55);
            this.dtp_kayittarihi.Name = "dtp_kayittarihi";
            this.dtp_kayittarihi.Size = new System.Drawing.Size(200, 22);
            this.dtp_kayittarihi.TabIndex = 14;
            // 
            // lbl_kayittarihi
            // 
            this.lbl_kayittarihi.AutoSize = true;
            this.lbl_kayittarihi.Location = new System.Drawing.Point(25, 26);
            this.lbl_kayittarihi.Name = "lbl_kayittarihi";
            this.lbl_kayittarihi.Size = new System.Drawing.Size(76, 16);
            this.lbl_kayittarihi.TabIndex = 0;
            this.lbl_kayittarihi.Text = "Kayıt Tarihi:";
            // 
            // btn_ogrencikaydet
            // 
            this.btn_ogrencikaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ogrencikaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ogrencikaydet.Location = new System.Drawing.Point(170, 395);
            this.btn_ogrencikaydet.Name = "btn_ogrencikaydet";
            this.btn_ogrencikaydet.Size = new System.Drawing.Size(96, 34);
            this.btn_ogrencikaydet.TabIndex = 10;
            this.btn_ogrencikaydet.Text = "Kaydet";
            this.btn_ogrencikaydet.UseVisualStyleBackColor = false;
            this.btn_ogrencikaydet.Click += new System.EventHandler(this.btn_ogrencikaydet_Click);
            // 
            // btn_bilgileriyazdir
            // 
            this.btn_bilgileriyazdir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_bilgileriyazdir.Location = new System.Drawing.Point(353, 395);
            this.btn_bilgileriyazdir.Name = "btn_bilgileriyazdir";
            this.btn_bilgileriyazdir.Size = new System.Drawing.Size(110, 34);
            this.btn_bilgileriyazdir.TabIndex = 12;
            this.btn_bilgileriyazdir.Text = "Bilgileri Yazdır";
            this.btn_bilgileriyazdir.UseVisualStyleBackColor = false;
            this.btn_bilgileriyazdir.Click += new System.EventHandler(this.btn_bilgileriyazdir_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_iptal.Location = new System.Drawing.Point(272, 395);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 34);
            this.btn_iptal.TabIndex = 11;
            this.btn_iptal.Text = "İptal ";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // lb_ogrenciler
            // 
            this.lb_ogrenciler.FormattingEnabled = true;
            this.lb_ogrenciler.ItemHeight = 16;
            this.lb_ogrenciler.Location = new System.Drawing.Point(3, 33);
            this.lb_ogrenciler.Name = "lb_ogrenciler";
            this.lb_ogrenciler.Size = new System.Drawing.Size(217, 356);
            this.lb_ogrenciler.TabIndex = 10;
            this.lb_ogrenciler.SelectedIndexChanged += new System.EventHandler(this.lb_ogrenciler_SelectedIndexChanged);
            // 
            // btn_ogrencibilgi
            // 
            this.btn_ogrencibilgi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ogrencibilgi.Location = new System.Drawing.Point(3, 395);
            this.btn_ogrencibilgi.Name = "btn_ogrencibilgi";
            this.btn_ogrencibilgi.Size = new System.Drawing.Size(217, 34);
            this.btn_ogrencibilgi.TabIndex = 9;
            this.btn_ogrencibilgi.Text = "Öğrenciler\r\n\r\n";
            this.btn_ogrencibilgi.UseVisualStyleBackColor = false;
            this.btn_ogrencibilgi.Click += new System.EventHandler(this.btn_ogrencibilgi_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OgrenciKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OgrenciKayit_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tp_kisisel.ResumeLayout(false);
            this.tp_kisisel.PerformLayout();
            this.tp_iletisim.ResumeLayout(false);
            this.tp_iletisim.PerformLayout();
            this.tp_egitim.ResumeLayout(false);
            this.tp_egitim.PerformLayout();
            this.tp_kayit.ResumeLayout(false);
            this.tp_kayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_ogrencikaydet;
        private System.Windows.Forms.Button btn_bilgileriyazdir;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_ogrencibilgi;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_kisisel;
        private System.Windows.Forms.Label lbl_kangrubu;
        private System.Windows.Forms.Label lbl_dogumtarihi;
        private System.Windows.Forms.Label lbl_kimlik;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TabPage tp_iletisim;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telefonno;
        private System.Windows.Forms.TabPage tp_egitim;
        private System.Windows.Forms.Label lbl_ogrencino;
        private System.Windows.Forms.Label lbl_mezunokul;
        private System.Windows.Forms.Label lbl_sube;
        private System.Windows.Forms.Label lbl_sınıf;
        private System.Windows.Forms.TabPage tp_kayit;
        private System.Windows.Forms.Label lbl_kayittarihi;
        private System.Windows.Forms.ComboBox cb_kanGrubu;
        private System.Windows.Forms.DateTimePicker dtp_dogumtarihi;
        private System.Windows.Forms.MaskedTextBox mtb_kimlik;
        private System.Windows.Forms.TextBox tb_soyisim;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.TextBox tb_adres;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.MaskedTextBox mtb_telefon;
        private System.Windows.Forms.ComboBox cb_sinif;
        private System.Windows.Forms.ComboBox cb_sube;
        private System.Windows.Forms.ComboBox cb_ogrencino;
        private System.Windows.Forms.TextBox tb_mezunokul;
        private System.Windows.Forms.DateTimePicker dtp_kayittarihi;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_sınıf;
        private System.Windows.Forms.Button btn_ogrencinosec;
        private System.Windows.Forms.Button btn_subesec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_ogretmensec;
        private System.Windows.Forms.ComboBox cb_ogretmen;
        private System.Windows.Forms.Label lbl_ogretmen;
        private System.Windows.Forms.ListBox lb_ogrenciler;
    }
}