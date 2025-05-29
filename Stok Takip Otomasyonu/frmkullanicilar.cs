using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_Otomasyonu
{
    public partial class frmkullanicilar : Form 
    {
        public frmkullanicilar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=FERDI-TEKIK\\SQLEXPRESS;Initial Catalog=Stok_Takip1;Integrated Security=True;");
        DataSet daset = new DataSet();

        private void FormTemizle()
        {
            txtAdiSoyadi.Text = string.Empty;
            txtKullaniciAdi2.Text = string.Empty;
            txtTC.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            txtSifre2.Text = string.Empty;
            txtSifreTekrar.Text = string.Empty;
            txtPosta.Text = string.Empty;
            txtAdiSoyadi.Focus(); // İmleci ilk alana odakla
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TextBox değerlerini al ve boşlukları kırp
            string adSoyad = txtAdiSoyadi.Text.Trim();
            string kullaniciAdi = txtKullaniciAdi2.Text.Trim();
            string sifre = txtSifre2.Text.Trim();
            string sifreTekrar = txtSifreTekrar.Text.Trim();
            string tc = txtTC.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string ePosta = txtPosta.Text.Trim();

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(adSoyad) || string.IsNullOrEmpty(kullaniciAdi) ||
                string.IsNullOrEmpty(tc) || string.IsNullOrEmpty(telefon) ||
                string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(sifreTekrar) || string.IsNullOrEmpty(ePosta))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı");
                return;
            }

            // Şifre kontrolü
            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler eşleşmiyor.", "Hata");
                return;
            }

            // Veritabanına kaydet
            if (KullaniciKaydet(adSoyad, kullaniciAdi, sifre, sifreTekrar, tc, telefon, ePosta))
            {
                MessageBox.Show("Kayıt başarılı.", "Bilgi");

                // Form alanlarını temizle
                FormTemizle();
            }
            else
            {
                MessageBox.Show("Kayıt başarısız.", "Hata");
            }
        }

        private bool KullaniciKaydet(string adSoyad, string kullaniciAdi, string sifre, string sifreTekrar, string tc, string telefon, string ePosta)
        {
            try
            {
                // Bağlantıyı aç
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                // SQL sorgusu hazırla - Veritabanındaki sütun adlarına göre düzenlendi
                string query = "INSERT INTO kullanicilar1 (adSoyad, kullaniciAdi, sifre, sifreTekrar, tc, telefon, ePosta) " +
                               "VALUES (@adSoyad, @kullaniciAdi, @sifre, @sifreTekrar, @tc, @telefon, @ePosta)";

                using (SqlCommand command = new SqlCommand(query, baglanti))
                {
                    // Parametreleri ekle - Veritabanı sütun adlarına göre düzenlendi
                    command.Parameters.AddWithValue("@adSoyad", adSoyad);
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sifre);
                    command.Parameters.AddWithValue("@sifreTekrar", sifreTekrar);
                    command.Parameters.AddWithValue("@tc", tc);
                    command.Parameters.AddWithValue("@telefon", telefon);
                    command.Parameters.AddWithValue("@ePosta", ePosta);

                    // Sorguyu çalıştır
                    int result = command.ExecuteNonQuery();

                    // Bağlantıyı kapat
                    baglanti.Close();

                    // Etkilenen satır sayısı 1 ise başarılı
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                // Hatayı loglayabilir veya kullanıcıya gösterebilirsiniz
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata");

                // Bağlantı açıksa kapat
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }

                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi1.Text.Trim();
            string sifre = txtSifre1.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.", "Uyarı");
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string query = "SELECT COUNT(*) FROM kullanicilar1 WHERE kullaniciAdi = @kullaniciAdi AND sifre = @sifre";
                using (SqlCommand command = new SqlCommand(query, baglanti))
                {
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sifre);

                    int kullaniciSayisi = (int)command.ExecuteScalar();

                    if (kullaniciSayisi > 0)
                    {
                        Form1 listele = new Form1();
                        listele.ShowDialog();
                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSifreYenilemecs sifre = new frmSifreYenilemecs();
            sifre.ShowDialog();
        }

        private void frmkullanicilar_Load(object sender, EventArgs e)
        {

        }
    }
}