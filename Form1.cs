using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace MuayeneBilgiSistemiUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // veritabanına bağlanma
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=9999;User Id=postgres; Password=1234; Database=dbkullanici");
        private readonly string connectionString = "Server=localhost; Port=9999; Database=dbkullanici; User Id=postgres; Password=1234;";
        private void GoruntulemeButton_Click(object sender, EventArgs e)
        {
            //veritabanındaki kullanıcıları ekranda görmek için işlemler
            string sorgu = "select * from hasta";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        //Anasayfadaki, yapılmak istenen işleme gitme butonları
        private void EkleSayfasi_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 1;
        }

        private void SilSayfasi_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 2;

        }

        private void GuncelleSayfasi_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 3;

        }

        private void AnaSayfaDon_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;

        }

        private void AnaSayfaDon2_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;

        }

        private void AnaSayfayaDon3_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;
        }

        //kullanıcı ekleme
        private void EkleButon_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                baglanti.Open();

                string eklemeSorgusu = "INSERT INTO hasta(\"AdSoyad\",\"TcNo\",\"TelNo\",\"DogumTarihi\",\"DogumYeri\",\"Adres\",\"Hastalik\",\"Ilac\") " +
                                        "VALUES(@AdSoyad, @TcNo, @TelNo, @DogumTarihi, @DogumYeri, @Adres, @Hastalik, @Ilac)";

                using (NpgsqlCommand komut = new NpgsqlCommand(eklemeSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@AdSoyad", AdSoyad.Text);
                    komut.Parameters.AddWithValue("@TcNo", NpgsqlTypes.NpgsqlDbType.Bigint);
                    komut.Parameters["@TcNo"].Value = Convert.ToInt64(TcNo.Text);
                    komut.Parameters.AddWithValue("@TelNo", NpgsqlTypes.NpgsqlDbType.Bigint);
                    komut.Parameters["@TelNo"].Value = Convert.ToInt64(TelefonNo.Text);
                    komut.Parameters.Add(new NpgsqlParameter("@DogumTarihi", NpgsqlTypes.NpgsqlDbType.Date));
                    komut.Parameters["@DogumTarihi"].Value = DogumTarihiDateTimePicker.Value;
                    komut.Parameters.AddWithValue("@DogumYeri", DogumYeri.Text);
                    komut.Parameters.AddWithValue("@Adres", Adres.Text);
                    komut.Parameters.AddWithValue("@Hastalik", HastalıkTeshis.Text);
                    komut.Parameters.AddWithValue("@Ilac", IlacBilgi.Text);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdSoyad.Text = "";
                    TcNo.Text = "";
                    TelefonNo.Text = "";
                    DogumTarihiDateTimePicker.Value = DateTime.Now;
                    DogumYeri.Text = "";
                    Adres.Text = "";
                    HastalıkTeshis.Text = "";
                    IlacBilgi.Text = "";
                }
            }
        }

        //kullanıcı silme
        private void SilButon_Click(object sender, EventArgs e)
        {
            
            string tcNo = SilinecekKullanici.Text;

            

            if (string.IsNullOrEmpty(tcNo))
            {
                MessageBox.Show("Lütfen bir TC kimlik numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                baglanti.Open();

                string silmeSorgusu = "DELETE FROM hasta WHERE \"TcNo\" = @TcNo::bigint";

                using (NpgsqlCommand komut = new NpgsqlCommand(silmeSorgusu, baglanti))
                {
                    
                    komut.Parameters.AddWithValue("@TcNo", tcNo);

                    
                    int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                    if (etkilenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla silindi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SilinecekKullanici.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen TC kimlik numarasına sahip kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        //kullanıcı sorgulama
        private void SorgulaButon_Click(object sender, EventArgs e)
        {
            
            string tcNo = TcNoSorgu.Text;

          
            if (string.IsNullOrEmpty(tcNo))
            {
                MessageBox.Show("Lütfen bir TC kimlik numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                baglanti.Open();

                string sorgulaSorgusu = "SELECT \"AdSoyad\", \"TelNo\", \"Hastalik\", \"Adres\", \"Ilac\" FROM hasta WHERE \"TcNo\" = @TcNo::bigint";

                using (NpgsqlCommand komut = new NpgsqlCommand(sorgulaSorgusu, baglanti))
                {
                    
                    komut.Parameters.AddWithValue("@TcNo", tcNo);

                    using (NpgsqlDataReader reader = komut.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            AdSoyadlabel.Text = reader["AdSoyad"].ToString();
                            GuncelTelNo.Text = reader["TelNo"].ToString();
                            GuncelHastalik.Text = reader["Hastalik"].ToString();
                            GuncelAdres.Text = reader["Adres"].ToString();
                            Guncellac.Text = reader["Ilac"].ToString();
                        }
                    }
                }
            }
        }

        //sorgulanan kullanıcının bilgilerini güncelleme
        private void GuncelleButon_Click(object sender, EventArgs e)
        {
            string tcNo = TcNoSorgu.Text;

            if (string.IsNullOrEmpty(tcNo))
            {
                MessageBox.Show("Lütfen bir TC kimlik numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                baglanti.Open();

                string guncelleSorgusu = "UPDATE hasta SET \"TelNo\" = @TelNo::bigint, \"Hastalik\" = @Hastalik, \"Adres\" = @Adres, \"Ilac\" = @Ilac WHERE \"TcNo\" = @TcNo::bigint";

                using (NpgsqlCommand komut = new NpgsqlCommand(guncelleSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@TcNo", tcNo);
                    komut.Parameters.AddWithValue("@TelNo", GuncelTelNo.Text);
                    komut.Parameters.AddWithValue("@Hastalik", GuncelHastalik.Text);
                    komut.Parameters.AddWithValue("@Adres", GuncelAdres.Text);
                    komut.Parameters.AddWithValue("@Ilac", Guncellac.Text);

                    
                    int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                    if (etkilenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        AdSoyad.Text = "";
                        TcNoSorgu.Text = "";
                        GuncelTelNo.Text = "";
                        GuncelAdres.Text = "";
                        GuncelHastalik.Text = "";
                        Guncellac.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen TC kimlik numarasına sahip kullanıcı bulunamadı veya güncelleme yapılmadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
