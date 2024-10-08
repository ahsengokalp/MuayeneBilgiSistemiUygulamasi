namespace MuayeneBilgiSistemiUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.AnaSayfatabPage = new System.Windows.Forms.TabPage();
            this.GoruntulemeButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GuncelleSayfasi = new System.Windows.Forms.Button();
            this.SilSayfasi = new System.Windows.Forms.Button();
            this.EkleSayfasi = new System.Windows.Forms.Button();
            this.KullaniciEkletabPage = new System.Windows.Forms.TabPage();
            this.DogumTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AnaSayfaDon = new System.Windows.Forms.Button();
            this.EkleButon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IlacBilgi = new System.Windows.Forms.TextBox();
            this.HastalıkTeshis = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.DogumYeri = new System.Windows.Forms.TextBox();
            this.TelefonNo = new System.Windows.Forms.TextBox();
            this.TcNo = new System.Windows.Forms.TextBox();
            this.AdSoyad = new System.Windows.Forms.TextBox();
            this.KullaniciSiltabPage = new System.Windows.Forms.TabPage();
            this.SilButon = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SilinecekKullanici = new System.Windows.Forms.TextBox();
            this.AnaSayfaDon2 = new System.Windows.Forms.Button();
            this.KullanıcıGüncelletabPage = new System.Windows.Forms.TabPage();
            this.AdSoyadlabel = new System.Windows.Forms.Label();
            this.SorgulaButon = new System.Windows.Forms.Button();
            this.GuncelleButon = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Guncellac = new System.Windows.Forms.TextBox();
            this.GuncelHastalik = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GuncelAdres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GuncelTelNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TcNoSorgu = new System.Windows.Forms.TextBox();
            this.AnaSayfayaDon3 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.AnaSayfatabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.KullaniciEkletabPage.SuspendLayout();
            this.KullaniciSiltabPage.SuspendLayout();
            this.KullanıcıGüncelletabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.AnaSayfatabPage);
            this.TabControl.Controls.Add(this.KullaniciEkletabPage);
            this.TabControl.Controls.Add(this.KullaniciSiltabPage);
            this.TabControl.Controls.Add(this.KullanıcıGüncelletabPage);
            this.TabControl.Location = new System.Drawing.Point(13, 13);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(775, 435);
            this.TabControl.TabIndex = 0;
            // 
            // AnaSayfatabPage
            // 
            this.AnaSayfatabPage.BackColor = System.Drawing.Color.LightCyan;
            this.AnaSayfatabPage.Controls.Add(this.GoruntulemeButton);
            this.AnaSayfatabPage.Controls.Add(this.dataGridView1);
            this.AnaSayfatabPage.Controls.Add(this.GuncelleSayfasi);
            this.AnaSayfatabPage.Controls.Add(this.SilSayfasi);
            this.AnaSayfatabPage.Controls.Add(this.EkleSayfasi);
            this.AnaSayfatabPage.Location = new System.Drawing.Point(4, 29);
            this.AnaSayfatabPage.Name = "AnaSayfatabPage";
            this.AnaSayfatabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AnaSayfatabPage.Size = new System.Drawing.Size(767, 402);
            this.AnaSayfatabPage.TabIndex = 0;
            this.AnaSayfatabPage.Text = "Ana Sayfa";
            // 
            // GoruntulemeButton
            // 
            this.GoruntulemeButton.Location = new System.Drawing.Point(290, 243);
            this.GoruntulemeButton.Name = "GoruntulemeButton";
            this.GoruntulemeButton.Size = new System.Drawing.Size(156, 42);
            this.GoruntulemeButton.TabIndex = 9;
            this.GoruntulemeButton.Text = "Listeyi Güncelle";
            this.GoruntulemeButton.UseVisualStyleBackColor = true;
            this.GoruntulemeButton.Click += new System.EventHandler(this.GoruntulemeButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(755, 211);
            this.dataGridView1.TabIndex = 8;
            // 
            // GuncelleSayfasi
            // 
            this.GuncelleSayfasi.Location = new System.Drawing.Point(442, 303);
            this.GuncelleSayfasi.Name = "GuncelleSayfasi";
            this.GuncelleSayfasi.Size = new System.Drawing.Size(138, 61);
            this.GuncelleSayfasi.TabIndex = 7;
            this.GuncelleSayfasi.Text = "Kullanici Guncelle";
            this.GuncelleSayfasi.UseVisualStyleBackColor = true;
            this.GuncelleSayfasi.Click += new System.EventHandler(this.GuncelleSayfasi_Click);
            // 
            // SilSayfasi
            // 
            this.SilSayfasi.Location = new System.Drawing.Point(290, 303);
            this.SilSayfasi.Name = "SilSayfasi";
            this.SilSayfasi.Size = new System.Drawing.Size(130, 61);
            this.SilSayfasi.TabIndex = 6;
            this.SilSayfasi.Text = "Kullanici Sil";
            this.SilSayfasi.UseVisualStyleBackColor = true;
            this.SilSayfasi.Click += new System.EventHandler(this.SilSayfasi_Click);
            // 
            // EkleSayfasi
            // 
            this.EkleSayfasi.Location = new System.Drawing.Point(130, 303);
            this.EkleSayfasi.Name = "EkleSayfasi";
            this.EkleSayfasi.Size = new System.Drawing.Size(135, 61);
            this.EkleSayfasi.TabIndex = 5;
            this.EkleSayfasi.Text = "Kullanıcı Ekle";
            this.EkleSayfasi.UseVisualStyleBackColor = true;
            this.EkleSayfasi.Click += new System.EventHandler(this.EkleSayfasi_Click);
            // 
            // KullaniciEkletabPage
            // 
            this.KullaniciEkletabPage.BackColor = System.Drawing.Color.LightCyan;
            this.KullaniciEkletabPage.Controls.Add(this.DogumTarihiDateTimePicker);
            this.KullaniciEkletabPage.Controls.Add(this.AnaSayfaDon);
            this.KullaniciEkletabPage.Controls.Add(this.EkleButon);
            this.KullaniciEkletabPage.Controls.Add(this.label5);
            this.KullaniciEkletabPage.Controls.Add(this.label6);
            this.KullaniciEkletabPage.Controls.Add(this.label7);
            this.KullaniciEkletabPage.Controls.Add(this.label8);
            this.KullaniciEkletabPage.Controls.Add(this.label3);
            this.KullaniciEkletabPage.Controls.Add(this.label4);
            this.KullaniciEkletabPage.Controls.Add(this.label2);
            this.KullaniciEkletabPage.Controls.Add(this.label1);
            this.KullaniciEkletabPage.Controls.Add(this.IlacBilgi);
            this.KullaniciEkletabPage.Controls.Add(this.HastalıkTeshis);
            this.KullaniciEkletabPage.Controls.Add(this.Adres);
            this.KullaniciEkletabPage.Controls.Add(this.DogumYeri);
            this.KullaniciEkletabPage.Controls.Add(this.TelefonNo);
            this.KullaniciEkletabPage.Controls.Add(this.TcNo);
            this.KullaniciEkletabPage.Controls.Add(this.AdSoyad);
            this.KullaniciEkletabPage.Location = new System.Drawing.Point(4, 29);
            this.KullaniciEkletabPage.Name = "KullaniciEkletabPage";
            this.KullaniciEkletabPage.Padding = new System.Windows.Forms.Padding(3);
            this.KullaniciEkletabPage.Size = new System.Drawing.Size(767, 402);
            this.KullaniciEkletabPage.TabIndex = 1;
            this.KullaniciEkletabPage.Text = "Kullanici Ekle";
            // 
            // DogumTarihiDateTimePicker
            // 
            this.DogumTarihiDateTimePicker.Location = new System.Drawing.Point(143, 166);
            this.DogumTarihiDateTimePicker.Name = "DogumTarihiDateTimePicker";
            this.DogumTarihiDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.DogumTarihiDateTimePicker.TabIndex = 53;
            // 
            // AnaSayfaDon
            // 
            this.AnaSayfaDon.Location = new System.Drawing.Point(588, 333);
            this.AnaSayfaDon.Name = "AnaSayfaDon";
            this.AnaSayfaDon.Size = new System.Drawing.Size(149, 43);
            this.AnaSayfaDon.TabIndex = 52;
            this.AnaSayfaDon.Text = "Ana Sayfaya Dön";
            this.AnaSayfaDon.UseVisualStyleBackColor = true;
            this.AnaSayfaDon.Click += new System.EventHandler(this.AnaSayfaDon_Click);
            // 
            // EkleButon
            // 
            this.EkleButon.Location = new System.Drawing.Point(167, 333);
            this.EkleButon.Name = "EkleButon";
            this.EkleButon.Size = new System.Drawing.Size(151, 43);
            this.EkleButon.TabIndex = 51;
            this.EkleButon.Text = "Ekle";
            this.EkleButon.UseVisualStyleBackColor = true;
            this.EkleButon.Click += new System.EventHandler(this.EkleButon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ilac:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Hastalık:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Adres:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Dogum Yeri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Dogum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Telefon No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tc No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ad Soyad:";
            // 
            // IlacBilgi
            // 
            this.IlacBilgi.Location = new System.Drawing.Point(520, 233);
            this.IlacBilgi.Name = "IlacBilgi";
            this.IlacBilgi.Size = new System.Drawing.Size(197, 26);
            this.IlacBilgi.TabIndex = 42;
            // 
            // HastalıkTeshis
            // 
            this.HastalıkTeshis.Location = new System.Drawing.Point(520, 183);
            this.HastalıkTeshis.Name = "HastalıkTeshis";
            this.HastalıkTeshis.Size = new System.Drawing.Size(197, 26);
            this.HastalıkTeshis.TabIndex = 41;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(143, 256);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(200, 26);
            this.Adres.TabIndex = 40;
            // 
            // DogumYeri
            // 
            this.DogumYeri.Location = new System.Drawing.Point(143, 203);
            this.DogumYeri.Name = "DogumYeri";
            this.DogumYeri.Size = new System.Drawing.Size(200, 26);
            this.DogumYeri.TabIndex = 39;
            // 
            // TelefonNo
            // 
            this.TelefonNo.Location = new System.Drawing.Point(143, 115);
            this.TelefonNo.Name = "TelefonNo";
            this.TelefonNo.Size = new System.Drawing.Size(200, 26);
            this.TelefonNo.TabIndex = 37;
            // 
            // TcNo
            // 
            this.TcNo.Location = new System.Drawing.Point(143, 74);
            this.TcNo.Name = "TcNo";
            this.TcNo.Size = new System.Drawing.Size(200, 26);
            this.TcNo.TabIndex = 36;
            // 
            // AdSoyad
            // 
            this.AdSoyad.Location = new System.Drawing.Point(143, 27);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(200, 26);
            this.AdSoyad.TabIndex = 35;
            // 
            // KullaniciSiltabPage
            // 
            this.KullaniciSiltabPage.BackColor = System.Drawing.Color.LightCyan;
            this.KullaniciSiltabPage.Controls.Add(this.SilButon);
            this.KullaniciSiltabPage.Controls.Add(this.label14);
            this.KullaniciSiltabPage.Controls.Add(this.SilinecekKullanici);
            this.KullaniciSiltabPage.Controls.Add(this.AnaSayfaDon2);
            this.KullaniciSiltabPage.Location = new System.Drawing.Point(4, 29);
            this.KullaniciSiltabPage.Name = "KullaniciSiltabPage";
            this.KullaniciSiltabPage.Padding = new System.Windows.Forms.Padding(3);
            this.KullaniciSiltabPage.Size = new System.Drawing.Size(767, 402);
            this.KullaniciSiltabPage.TabIndex = 2;
            this.KullaniciSiltabPage.Text = "Kullanıcı Sil";
            // 
            // SilButon
            // 
            this.SilButon.Location = new System.Drawing.Point(219, 196);
            this.SilButon.Name = "SilButon";
            this.SilButon.Size = new System.Drawing.Size(142, 55);
            this.SilButon.TabIndex = 42;
            this.SilButon.Text = "Kullanıcıyı Sil";
            this.SilButon.UseVisualStyleBackColor = true;
            this.SilButon.Click += new System.EventHandler(this.SilButon_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(105, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 41;
            this.label14.Text = "Tc No:";
            // 
            // SilinecekKullanici
            // 
            this.SilinecekKullanici.Location = new System.Drawing.Point(207, 76);
            this.SilinecekKullanici.Multiline = true;
            this.SilinecekKullanici.Name = "SilinecekKullanici";
            this.SilinecekKullanici.Size = new System.Drawing.Size(277, 84);
            this.SilinecekKullanici.TabIndex = 40;
            // 
            // AnaSayfaDon2
            // 
            this.AnaSayfaDon2.Location = new System.Drawing.Point(513, 284);
            this.AnaSayfaDon2.Name = "AnaSayfaDon2";
            this.AnaSayfaDon2.Size = new System.Drawing.Size(149, 43);
            this.AnaSayfaDon2.TabIndex = 39;
            this.AnaSayfaDon2.Text = "Ana Sayfaya Dön";
            this.AnaSayfaDon2.UseVisualStyleBackColor = true;
            this.AnaSayfaDon2.Click += new System.EventHandler(this.AnaSayfaDon2_Click);
            // 
            // KullanıcıGüncelletabPage
            // 
            this.KullanıcıGüncelletabPage.BackColor = System.Drawing.Color.LightCyan;
            this.KullanıcıGüncelletabPage.Controls.Add(this.label);
            this.KullanıcıGüncelletabPage.Controls.Add(this.AdSoyadlabel);
            this.KullanıcıGüncelletabPage.Controls.Add(this.SorgulaButon);
            this.KullanıcıGüncelletabPage.Controls.Add(this.GuncelleButon);
            this.KullanıcıGüncelletabPage.Controls.Add(this.label12);
            this.KullanıcıGüncelletabPage.Controls.Add(this.label13);
            this.KullanıcıGüncelletabPage.Controls.Add(this.Guncellac);
            this.KullanıcıGüncelletabPage.Controls.Add(this.GuncelHastalik);
            this.KullanıcıGüncelletabPage.Controls.Add(this.label11);
            this.KullanıcıGüncelletabPage.Controls.Add(this.GuncelAdres);
            this.KullanıcıGüncelletabPage.Controls.Add(this.label10);
            this.KullanıcıGüncelletabPage.Controls.Add(this.GuncelTelNo);
            this.KullanıcıGüncelletabPage.Controls.Add(this.label9);
            this.KullanıcıGüncelletabPage.Controls.Add(this.TcNoSorgu);
            this.KullanıcıGüncelletabPage.Controls.Add(this.AnaSayfayaDon3);
            this.KullanıcıGüncelletabPage.Location = new System.Drawing.Point(4, 29);
            this.KullanıcıGüncelletabPage.Name = "KullanıcıGüncelletabPage";
            this.KullanıcıGüncelletabPage.Padding = new System.Windows.Forms.Padding(3);
            this.KullanıcıGüncelletabPage.Size = new System.Drawing.Size(767, 402);
            this.KullanıcıGüncelletabPage.TabIndex = 3;
            this.KullanıcıGüncelletabPage.Text = "Kullanıcı Güncelle";
            // 
            // AdSoyadlabel
            // 
            this.AdSoyadlabel.AutoSize = true;
            this.AdSoyadlabel.Location = new System.Drawing.Point(317, 144);
            this.AdSoyadlabel.Name = "AdSoyadlabel";
            this.AdSoyadlabel.Size = new System.Drawing.Size(0, 20);
            this.AdSoyadlabel.TabIndex = 63;
            // 
            // SorgulaButon
            // 
            this.SorgulaButon.Location = new System.Drawing.Point(247, 91);
            this.SorgulaButon.Name = "SorgulaButon";
            this.SorgulaButon.Size = new System.Drawing.Size(115, 39);
            this.SorgulaButon.TabIndex = 62;
            this.SorgulaButon.Text = "Sorgula";
            this.SorgulaButon.UseVisualStyleBackColor = true;
            this.SorgulaButon.Click += new System.EventHandler(this.SorgulaButon_Click);
            // 
            // GuncelleButon
            // 
            this.GuncelleButon.Location = new System.Drawing.Point(313, 278);
            this.GuncelleButon.Name = "GuncelleButon";
            this.GuncelleButon.Size = new System.Drawing.Size(145, 35);
            this.GuncelleButon.TabIndex = 61;
            this.GuncelleButon.Text = "Güncelle";
            this.GuncelleButon.UseVisualStyleBackColor = true;
            this.GuncelleButon.Click += new System.EventHandler(this.GuncelleButon_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 60;
            this.label12.Text = "Ilac:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(388, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 59;
            this.label13.Text = "Hastalık:";
            // 
            // Guncellac
            // 
            this.Guncellac.Location = new System.Drawing.Point(479, 231);
            this.Guncellac.Name = "Guncellac";
            this.Guncellac.Size = new System.Drawing.Size(100, 26);
            this.Guncellac.TabIndex = 58;
            // 
            // GuncelHastalik
            // 
            this.GuncelHastalik.Location = new System.Drawing.Point(479, 196);
            this.GuncelHastalik.Name = "GuncelHastalik";
            this.GuncelHastalik.Size = new System.Drawing.Size(200, 26);
            this.GuncelHastalik.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 56;
            this.label11.Text = "Adres:";
            // 
            // GuncelAdres
            // 
            this.GuncelAdres.Location = new System.Drawing.Point(168, 228);
            this.GuncelAdres.Name = "GuncelAdres";
            this.GuncelAdres.Size = new System.Drawing.Size(182, 26);
            this.GuncelAdres.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Telefon No:";
            // 
            // GuncelTelNo
            // 
            this.GuncelTelNo.Location = new System.Drawing.Point(183, 196);
            this.GuncelTelNo.Name = "GuncelTelNo";
            this.GuncelTelNo.Size = new System.Drawing.Size(167, 26);
            this.GuncelTelNo.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Tc No:";
            // 
            // TcNoSorgu
            // 
            this.TcNoSorgu.Location = new System.Drawing.Point(247, 59);
            this.TcNoSorgu.Name = "TcNoSorgu";
            this.TcNoSorgu.Size = new System.Drawing.Size(198, 26);
            this.TcNoSorgu.TabIndex = 51;
            // 
            // AnaSayfayaDon3
            // 
            this.AnaSayfayaDon3.Location = new System.Drawing.Point(590, 334);
            this.AnaSayfayaDon3.Name = "AnaSayfayaDon3";
            this.AnaSayfayaDon3.Size = new System.Drawing.Size(149, 43);
            this.AnaSayfayaDon3.TabIndex = 50;
            this.AnaSayfayaDon3.Text = "Ana Sayfaya Dön";
            this.AnaSayfayaDon3.UseVisualStyleBackColor = true;
            this.AnaSayfayaDon3.Click += new System.EventHandler(this.AnaSayfayaDon3_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(228, 144);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(83, 20);
            this.label.TabIndex = 64;
            this.label.Text = "Hasta Adı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.AnaSayfatabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.KullaniciEkletabPage.ResumeLayout(false);
            this.KullaniciEkletabPage.PerformLayout();
            this.KullaniciSiltabPage.ResumeLayout(false);
            this.KullaniciSiltabPage.PerformLayout();
            this.KullanıcıGüncelletabPage.ResumeLayout(false);
            this.KullanıcıGüncelletabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage AnaSayfatabPage;
        private System.Windows.Forms.TabPage KullaniciEkletabPage;
        private System.Windows.Forms.TabPage KullaniciSiltabPage;
        private System.Windows.Forms.TabPage KullanıcıGüncelletabPage;
        private System.Windows.Forms.Button GoruntulemeButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GuncelleSayfasi;
        private System.Windows.Forms.Button SilSayfasi;
        private System.Windows.Forms.Button EkleSayfasi;
        private System.Windows.Forms.Button AnaSayfaDon;
        private System.Windows.Forms.Button EkleButon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IlacBilgi;
        private System.Windows.Forms.TextBox HastalıkTeshis;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.TextBox DogumYeri;
        private System.Windows.Forms.TextBox TelefonNo;
        private System.Windows.Forms.TextBox TcNo;
        private System.Windows.Forms.TextBox AdSoyad;
        private System.Windows.Forms.Button SilButon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SilinecekKullanici;
        private System.Windows.Forms.Button AnaSayfaDon2;
        private System.Windows.Forms.Button SorgulaButon;
        private System.Windows.Forms.Button GuncelleButon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Guncellac;
        private System.Windows.Forms.TextBox GuncelHastalik;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox GuncelAdres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox GuncelTelNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TcNoSorgu;
        private System.Windows.Forms.Button AnaSayfayaDon3;
        private System.Windows.Forms.DateTimePicker DogumTarihiDateTimePicker;
        private System.Windows.Forms.Label AdSoyadlabel;
        private System.Windows.Forms.Label label;
    }
}

