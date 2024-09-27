namespace Odev2._6OgrenciOgretmenKayitSistemi
{
    partial class OgretmenKayit
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
            this.btn_bilgileriyazdir = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_ogretmenkaydet = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_kisisel = new System.Windows.Forms.TabPage();
            this.cb_kanGrubu = new System.Windows.Forms.ComboBox();
            this.lbl_kangrubu = new System.Windows.Forms.Label();
            this.dtp_dogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.mtb_kimlik = new System.Windows.Forms.MaskedTextBox();
            this.tb_soyisim = new System.Windows.Forms.TextBox();
            this.tb_isim = new System.Windows.Forms.TextBox();
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
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.tp_egitim = new System.Windows.Forms.TabPage();
            this.btn_subesec = new System.Windows.Forms.Button();
            this.cb_sube = new System.Windows.Forms.ComboBox();
            this.lbl_sube = new System.Windows.Forms.Label();
            this.cb_egitim = new System.Windows.Forms.ComboBox();
            this.cb_bolum = new System.Windows.Forms.ComboBox();
            this.cb_mezun = new System.Windows.Forms.ComboBox();
            this.lbl_egitim = new System.Windows.Forms.Label();
            this.lbl_bolum = new System.Windows.Forms.Label();
            this.lbl_mezun = new System.Windows.Forms.Label();
            this.lb_ogretmenler = new System.Windows.Forms.ListBox();
            this.btn_ogretmenbilgi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_kisisel.SuspendLayout();
            this.tp_iletisim.SuspendLayout();
            this.tp_egitim.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_bilgileriyazdir);
            this.splitContainer1.Panel1.Controls.Add(this.btn_iptal);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ogretmenkaydet);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lb_ogretmenler);
            this.splitContainer1.Panel2.Controls.Add(this.btn_ogretmenbilgi);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 565;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_geri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_geri.Location = new System.Drawing.Point(457, 391);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(96, 34);
            this.btn_geri.TabIndex = 15;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_bilgileriyazdir
            // 
            this.btn_bilgileriyazdir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_bilgileriyazdir.Location = new System.Drawing.Point(341, 391);
            this.btn_bilgileriyazdir.Name = "btn_bilgileriyazdir";
            this.btn_bilgileriyazdir.Size = new System.Drawing.Size(110, 34);
            this.btn_bilgileriyazdir.TabIndex = 7;
            this.btn_bilgileriyazdir.Text = "Bilgileri Yazdır";
            this.btn_bilgileriyazdir.UseVisualStyleBackColor = false;
            this.btn_bilgileriyazdir.Click += new System.EventHandler(this.btn_bilgileriyazdir_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_iptal.Location = new System.Drawing.Point(260, 391);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 34);
            this.btn_iptal.TabIndex = 6;
            this.btn_iptal.Text = "İptal ";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_ogretmenkaydet
            // 
            this.btn_ogretmenkaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ogretmenkaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ogretmenkaydet.Location = new System.Drawing.Point(158, 391);
            this.btn_ogretmenkaydet.Name = "btn_ogretmenkaydet";
            this.btn_ogretmenkaydet.Size = new System.Drawing.Size(96, 34);
            this.btn_ogretmenkaydet.TabIndex = 5;
            this.btn_ogretmenkaydet.Text = "Kaydet";
            this.btn_ogretmenkaydet.UseVisualStyleBackColor = false;
            this.btn_ogretmenkaydet.Click += new System.EventHandler(this.btn_ogretmenkaydet_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_kisisel);
            this.tabControl1.Controls.Add(this.tp_iletisim);
            this.tabControl1.Controls.Add(this.tp_egitim);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 382);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_kisisel
            // 
            this.tp_kisisel.Controls.Add(this.cb_kanGrubu);
            this.tp_kisisel.Controls.Add(this.lbl_kangrubu);
            this.tp_kisisel.Controls.Add(this.dtp_dogumtarihi);
            this.tp_kisisel.Controls.Add(this.mtb_kimlik);
            this.tp_kisisel.Controls.Add(this.tb_soyisim);
            this.tp_kisisel.Controls.Add(this.tb_isim);
            this.tp_kisisel.Controls.Add(this.lbl_dogumtarihi);
            this.tp_kisisel.Controls.Add(this.lbl_kimlik);
            this.tp_kisisel.Controls.Add(this.lbl_soyisim);
            this.tp_kisisel.Controls.Add(this.lbl_isim);
            this.tp_kisisel.Location = new System.Drawing.Point(4, 25);
            this.tp_kisisel.Name = "tp_kisisel";
            this.tp_kisisel.Padding = new System.Windows.Forms.Padding(3);
            this.tp_kisisel.Size = new System.Drawing.Size(551, 353);
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
            this.cb_kanGrubu.Location = new System.Drawing.Point(24, 290);
            this.cb_kanGrubu.Name = "cb_kanGrubu";
            this.cb_kanGrubu.Size = new System.Drawing.Size(173, 24);
            this.cb_kanGrubu.TabIndex = 5;
            // 
            // lbl_kangrubu
            // 
            this.lbl_kangrubu.AutoSize = true;
            this.lbl_kangrubu.Location = new System.Drawing.Point(24, 270);
            this.lbl_kangrubu.Name = "lbl_kangrubu";
            this.lbl_kangrubu.Size = new System.Drawing.Size(72, 16);
            this.lbl_kangrubu.TabIndex = 9;
            this.lbl_kangrubu.Text = "Kan Grubu:";
            // 
            // dtp_dogumtarihi
            // 
            this.dtp_dogumtarihi.Location = new System.Drawing.Point(24, 229);
            this.dtp_dogumtarihi.Name = "dtp_dogumtarihi";
            this.dtp_dogumtarihi.Size = new System.Drawing.Size(195, 22);
            this.dtp_dogumtarihi.TabIndex = 4;
            // 
            // mtb_kimlik
            // 
            this.mtb_kimlik.Location = new System.Drawing.Point(24, 156);
            this.mtb_kimlik.Mask = "00000000000";
            this.mtb_kimlik.Name = "mtb_kimlik";
            this.mtb_kimlik.Size = new System.Drawing.Size(173, 22);
            this.mtb_kimlik.TabIndex = 3;
            // 
            // tb_soyisim
            // 
            this.tb_soyisim.Location = new System.Drawing.Point(24, 94);
            this.tb_soyisim.Name = "tb_soyisim";
            this.tb_soyisim.Size = new System.Drawing.Size(173, 22);
            this.tb_soyisim.TabIndex = 2;
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(24, 36);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(173, 22);
            this.tb_isim.TabIndex = 1;
            // 
            // lbl_dogumtarihi
            // 
            this.lbl_dogumtarihi.AutoSize = true;
            this.lbl_dogumtarihi.Location = new System.Drawing.Point(21, 197);
            this.lbl_dogumtarihi.Name = "lbl_dogumtarihi";
            this.lbl_dogumtarihi.Size = new System.Drawing.Size(91, 16);
            this.lbl_dogumtarihi.TabIndex = 3;
            this.lbl_dogumtarihi.Text = "Doğum Tarihi:";
            // 
            // lbl_kimlik
            // 
            this.lbl_kimlik.AutoSize = true;
            this.lbl_kimlik.Location = new System.Drawing.Point(21, 136);
            this.lbl_kimlik.Name = "lbl_kimlik";
            this.lbl_kimlik.Size = new System.Drawing.Size(133, 16);
            this.lbl_kimlik.TabIndex = 2;
            this.lbl_kimlik.Text = "T.C. Kimlik Numarası:";
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(21, 74);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(58, 16);
            this.lbl_soyisim.TabIndex = 1;
            this.lbl_soyisim.Text = "Soyisim:";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(21, 16);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(34, 16);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "İsim:";
            // 
            // tp_iletisim
            // 
            this.tp_iletisim.Controls.Add(this.tb_adres);
            this.tp_iletisim.Controls.Add(this.tb_mail);
            this.tp_iletisim.Controls.Add(this.mtb_telefon);
            this.tp_iletisim.Controls.Add(this.lbl_adres);
            this.tp_iletisim.Controls.Add(this.lbl_email);
            this.tp_iletisim.Controls.Add(this.lbl_telefon);
            this.tp_iletisim.Location = new System.Drawing.Point(4, 25);
            this.tp_iletisim.Name = "tp_iletisim";
            this.tp_iletisim.Padding = new System.Windows.Forms.Padding(3);
            this.tp_iletisim.Size = new System.Drawing.Size(551, 353);
            this.tp_iletisim.TabIndex = 1;
            this.tp_iletisim.Text = "İletişim Bilgileri";
            this.tp_iletisim.UseVisualStyleBackColor = true;
            // 
            // tb_adres
            // 
            this.tb_adres.Location = new System.Drawing.Point(26, 186);
            this.tb_adres.Multiline = true;
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_adres.Size = new System.Drawing.Size(191, 80);
            this.tb_adres.TabIndex = 8;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(23, 108);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(194, 22);
            this.tb_mail.TabIndex = 7;
            // 
            // mtb_telefon
            // 
            this.mtb_telefon.Location = new System.Drawing.Point(26, 40);
            this.mtb_telefon.Mask = "(999) 000-0000";
            this.mtb_telefon.Name = "mtb_telefon";
            this.mtb_telefon.Size = new System.Drawing.Size(191, 22);
            this.mtb_telefon.TabIndex = 6;
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Location = new System.Drawing.Point(23, 153);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(46, 16);
            this.lbl_adres.TabIndex = 2;
            this.lbl_adres.Text = "Adres:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(20, 88);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(48, 16);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(17, 20);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(117, 16);
            this.lbl_telefon.TabIndex = 0;
            this.lbl_telefon.Text = "Telefon Numarası:";
            // 
            // tp_egitim
            // 
            this.tp_egitim.Controls.Add(this.btn_subesec);
            this.tp_egitim.Controls.Add(this.cb_sube);
            this.tp_egitim.Controls.Add(this.lbl_sube);
            this.tp_egitim.Controls.Add(this.cb_egitim);
            this.tp_egitim.Controls.Add(this.cb_bolum);
            this.tp_egitim.Controls.Add(this.cb_mezun);
            this.tp_egitim.Controls.Add(this.lbl_egitim);
            this.tp_egitim.Controls.Add(this.lbl_bolum);
            this.tp_egitim.Controls.Add(this.lbl_mezun);
            this.tp_egitim.Location = new System.Drawing.Point(4, 25);
            this.tp_egitim.Name = "tp_egitim";
            this.tp_egitim.Size = new System.Drawing.Size(551, 353);
            this.tp_egitim.TabIndex = 2;
            this.tp_egitim.Text = "Eğitim Bilgileri";
            this.tp_egitim.UseVisualStyleBackColor = true;
            // 
            // btn_subesec
            // 
            this.btn_subesec.Location = new System.Drawing.Point(237, 255);
            this.btn_subesec.Name = "btn_subesec";
            this.btn_subesec.Size = new System.Drawing.Size(108, 23);
            this.btn_subesec.TabIndex = 8;
            this.btn_subesec.Text = "Seç";
            this.btn_subesec.UseVisualStyleBackColor = true;
            this.btn_subesec.Click += new System.EventHandler(this.btn_subesec_Click);
            // 
            // cb_sube
            // 
            this.cb_sube.FormattingEnabled = true;
            this.cb_sube.Location = new System.Drawing.Point(34, 254);
            this.cb_sube.Name = "cb_sube";
            this.cb_sube.Size = new System.Drawing.Size(183, 24);
            this.cb_sube.TabIndex = 12;
            // 
            // lbl_sube
            // 
            this.lbl_sube.AutoSize = true;
            this.lbl_sube.Location = new System.Drawing.Point(31, 224);
            this.lbl_sube.Name = "lbl_sube";
            this.lbl_sube.Size = new System.Drawing.Size(140, 16);
            this.lbl_sube.TabIndex = 6;
            this.lbl_sube.Text = "Eğitim Vereceği Şube:";
            // 
            // cb_egitim
            // 
            this.cb_egitim.FormattingEnabled = true;
            this.cb_egitim.Items.AddRange(new object[] {
            "Lisans",
            "Yüksek Lisans",
            "Doktora (PhD)"});
            this.cb_egitim.Location = new System.Drawing.Point(31, 178);
            this.cb_egitim.Name = "cb_egitim";
            this.cb_egitim.Size = new System.Drawing.Size(186, 24);
            this.cb_egitim.TabIndex = 11;
            // 
            // cb_bolum
            // 
            this.cb_bolum.FormattingEnabled = true;
            this.cb_bolum.Items.AddRange(new object[] {
            "Sınıf Öğretmenliği",
            "İlköğretim Matematik Öğretmenliği",
            "Türkçe Öğretmenliği",
            "Fen Bilgisi Öğretmenliği",
            "Sosyal Bilgiler Öğretmenliği",
            "Kimya Öğretmenliği",
            "Fizik Öğretmenliği",
            "Biyoloji Öğretmenliği",
            "Matematik Öğretmenliği",
            "Resim Öğretmenliği",
            "Müzik Öğretmenliği",
            "Rehberlik ve Psikolojik Danışmanlık",
            "Özel Eğitim Öğretmenliği",
            "Yabancı Diller Eğitimi (İngilizce, Almanca, Fransızca vb.)",
            "Eğitim Bilimleri",
            "Eğitim Yönetimi ve Denetimi",
            "Din Kültürü ve Ahlak Bilgisi Öğretmenliği",
            "Güzel Sanatlar Eğitimi",
            "Spor Eğitimi",
            "Teknoloji ve Tasarım Öğretmenliği",
            "Bilgisayar Öğretmenliği",
            "Anadolu ve Fen Lisesi Öğretmenliği (birleşik programlar)",
            "Çocuk Gelişimi ve Eğitimi"});
            this.cb_bolum.Location = new System.Drawing.Point(31, 108);
            this.cb_bolum.Name = "cb_bolum";
            this.cb_bolum.Size = new System.Drawing.Size(186, 24);
            this.cb_bolum.TabIndex = 10;
            // 
            // cb_mezun
            // 
            this.cb_mezun.FormattingEnabled = true;
            this.cb_mezun.Items.AddRange(new object[] {
            "Aksaray Üniversitesi",
            "Adana Bilim ve Teknoloji Üniversitesi",
            "Adnan Menderes Üniversitesi",
            "Afyon Kocatepe Üniversitesi",
            "Ağrı İbrahim Çeçen Üniversitesi",
            "Aksaray Üniversitesi",
            "Akdeniz Üniversitesi",
            "Anadolu Üniversitesi",
            "Ankara Üniversitesi",
            "Artvin Çoruh Üniversitesi",
            "Atatürk Üniversitesi",
            "Balıkesir Üniversitesi",
            "Bartın Üniversitesi",
            "Bayburt Üniversitesi",
            "Bilecik Şeyh Edebali Üniversitesi",
            "Bingöl Üniversitesi",
            "Boğaziçi Üniversitesi",
            "Bolu Abant İzzet Baysal Üniversitesi",
            "Burdur Mehmet Akif Ersoy Üniversitesi",
            "Bursa Teknik Üniversitesi",
            "Çanakkale Onsekiz Mart Üniversitesi",
            "Çukurova Üniversitesi",
            "Dicle Üniversitesi",
            "Dokuz Eylül Üniversitesi",
            "Düzce Üniversitesi",
            "Ege Üniversitesi",
            "Erzincan Binali Yıldırım Üniversitesi",
            "Erzurum Teknik Üniversitesi",
            "Eskişehir Osmangazi Üniversitesi",
            "Eskişehir Teknik Üniversitesi",
            "Fırat Üniversitesi",
            "Gazi Üniversitesi",
            "Gaziantep Üniversitesi",
            "Gümüşhane Üniversitesi",
            "Hacettepe Üniversitesi",
            "Hakkari Üniversitesi",
            "Hitit Üniversitesi",
            "Istanbul Üniversitesi",
            "Istanbul Teknik Üniversitesi (İTÜ)",
            "İzmir Katip Çelebi Üniversitesi",
            "İzmir Yüksek Teknoloji Enstitüsü",
            "Kahramanmaraş Sütçü İmam Üniversitesi",
            "Karadeniz Teknik Üniversitesi",
            "Kastamonu Üniversitesi",
            "Kırıkkale Üniversitesi",
            "Kırklareli Üniversitesi",
            "Kocaeli Üniversitesi",
            "Konya Teknik Üniversitesi",
            "Mardin Artuklu Üniversitesi",
            "Marmara Üniversitesi",
            "Muğla Sıtkı Koçman Üniversitesi",
            "Mustafa Kemal Üniversitesi",
            "Nevşehir Hacı Bektaş Veli Üniversitesi",
            "Niğde Ömer Halisdemir Üniversitesi",
            "Ondokuz Mayıs Üniversitesi",
            "Orta Doğu Teknik Üniversitesi (ODTÜ)",
            "Pamukkale Üniversitesi",
            "Sakarya Üniversitesi",
            "Selçuk Üniversitesi",
            "Siirt Üniversitesi",
            "Sinop Üniversitesi",
            "Süleyman Demirel Üniversitesi",
            "Trakya Üniversitesi",
            "Türk Hava Kurumu Üniversitesi",
            "Yalova Üniversitesi",
            "Yıldız Teknik Üniversitesi",
            "Abant İzzet Baysal Üniversitesi",
            "Acıbadem Mehmet Ali Aydınlar Üniversitesi",
            "Bilkent Üniversitesi",
            "Boğaziçi Üniversitesi",
            "Koç Üniversitesi",
            "Sabancı Üniversitesi",
            "İstanbul Şehir Üniversitesi",
            "İstanbul Bilgi Üniversitesi",
            "İstanbul Teknik Üniversitesi (İTÜ)",
            "Özyeğin Üniversitesi",
            "TOBB Ekonomi ve Teknoloji Üniversitesi",
            "İstanbul Medipol Üniversitesi",
            "Bahçeşehir Üniversitesi"});
            this.cb_mezun.Location = new System.Drawing.Point(31, 45);
            this.cb_mezun.Name = "cb_mezun";
            this.cb_mezun.Size = new System.Drawing.Size(186, 24);
            this.cb_mezun.TabIndex = 9;
            // 
            // lbl_egitim
            // 
            this.lbl_egitim.AutoSize = true;
            this.lbl_egitim.Location = new System.Drawing.Point(28, 146);
            this.lbl_egitim.Name = "lbl_egitim";
            this.lbl_egitim.Size = new System.Drawing.Size(91, 16);
            this.lbl_egitim.TabIndex = 2;
            this.lbl_egitim.Text = "Eğitim Düzeyi:";
            // 
            // lbl_bolum
            // 
            this.lbl_bolum.AutoSize = true;
            this.lbl_bolum.Location = new System.Drawing.Point(28, 88);
            this.lbl_bolum.Name = "lbl_bolum";
            this.lbl_bolum.Size = new System.Drawing.Size(136, 16);
            this.lbl_bolum.TabIndex = 1;
            this.lbl_bolum.Text = "Mezun Olduğu Bölüm:";
            // 
            // lbl_mezun
            // 
            this.lbl_mezun.AutoSize = true;
            this.lbl_mezun.Location = new System.Drawing.Point(28, 25);
            this.lbl_mezun.Name = "lbl_mezun";
            this.lbl_mezun.Size = new System.Drawing.Size(158, 16);
            this.lbl_mezun.TabIndex = 0;
            this.lbl_mezun.Text = "Mezun Olduğu Üniversite:";
            // 
            // lb_ogretmenler
            // 
            this.lb_ogretmenler.FormattingEnabled = true;
            this.lb_ogretmenler.ItemHeight = 16;
            this.lb_ogretmenler.Location = new System.Drawing.Point(3, 28);
            this.lb_ogretmenler.Name = "lb_ogretmenler";
            this.lb_ogretmenler.Size = new System.Drawing.Size(216, 356);
            this.lb_ogretmenler.TabIndex = 3;
            // 
            // btn_ogretmenbilgi
            // 
            this.btn_ogretmenbilgi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ogretmenbilgi.Location = new System.Drawing.Point(24, 391);
            this.btn_ogretmenbilgi.Name = "btn_ogretmenbilgi";
            this.btn_ogretmenbilgi.Size = new System.Drawing.Size(176, 34);
            this.btn_ogretmenbilgi.TabIndex = 2;
            this.btn_ogretmenbilgi.Text = "Öğretmen Kadrosu";
            this.btn_ogretmenbilgi.UseVisualStyleBackColor = false;
            this.btn_ogretmenbilgi.Click += new System.EventHandler(this.btn_ogretmenbilgi_Click);
            // 
            // OgretmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OgretmenKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Kayıt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OgretmenKayit_FormClosed);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_kisisel;
        private System.Windows.Forms.TabPage tp_iletisim;
        private System.Windows.Forms.TabPage tp_egitim;
        private System.Windows.Forms.Button btn_bilgileriyazdir;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_ogretmenkaydet;
        private System.Windows.Forms.Button btn_ogretmenbilgi;
        private System.Windows.Forms.Label lbl_dogumtarihi;
        private System.Windows.Forms.Label lbl_kimlik;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_egitim;
        private System.Windows.Forms.Label lbl_bolum;
        private System.Windows.Forms.Label lbl_mezun;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.DateTimePicker dtp_dogumtarihi;
        private System.Windows.Forms.MaskedTextBox mtb_kimlik;
        private System.Windows.Forms.TextBox tb_soyisim;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.MaskedTextBox mtb_telefon;
        private System.Windows.Forms.TextBox tb_adres;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.ComboBox cb_egitim;
        private System.Windows.Forms.ComboBox cb_bolum;
        private System.Windows.Forms.ComboBox cb_mezun;
        private System.Windows.Forms.ComboBox cb_kanGrubu;
        private System.Windows.Forms.Label lbl_kangrubu;
        private System.Windows.Forms.ComboBox cb_sube;
        private System.Windows.Forms.Label lbl_sube;
        private System.Windows.Forms.ListBox lb_ogretmenler;
        private System.Windows.Forms.Button btn_subesec;
    }
}