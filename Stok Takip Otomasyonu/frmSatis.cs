using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stok_Takip_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=FERDI-TEKIK\\SQLEXPRESS;Initial Catalog=Stok_Takip1;Integrated Security=True; ");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet ", baglanti);
            adtr.Fill(daset,"sepet");
            dataGridView2.DataSource = daset.Tables["sepet"];
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].Visible = false;

            baglanti.Close();
            lblGenelToplam.Text = " 00 TL";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from sepet ", baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + " TL ";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stok_Takip1DataSet3.sepet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sepetTableAdapter.Fill(this.stok_Takip1DataSet3.sepet);
            sepetlistele();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        public void button9_Click(object sender, EventArgs e)
        {
            frmSatışListele listele = new frmSatışListele();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmÜrünLisele listele = new frmÜrünLisele();
            listele.ShowDialog();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from müşteri where tc like '" + txtTc.Text + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Önceki verileri temizliyoruz
                temizle();

                // Veritabanı bağlantısını açıyoruz
                baglanti.Open();

                // Parametreli sorgu kullanarak veriyi çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno = @barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text); // Kullanıcı girişini parametre olarak ekliyoruz

                SqlDataReader read = komut.ExecuteReader();
                if (read.Read()) // Eğer veri bulunduysa
                {
                    // Ürün bilgilerini alıyoruz
                    txtUrunAdi.Text = read["urunadi"].ToString();
                    txtSatisFiyati.Text = read["satisfiyati"].ToString();

                    // Toplam fiyatı hesaplıyoruz (örneğin miktarı varsayalım 1)
                    int miktar = 1; // Miktar 1 olarak varsayıldı, eğer başka bir yere bağlıysa burayı güncellemeniz gerekebilir
                    double satisFiyati = double.Parse(read["satisfiyati"].ToString());
                    txtToplamFiyati.Text = (miktar * satisFiyati).ToString("F2"); // Toplam fiyatı hesaplıyoruz ve iki ondalıklı formatta gösteriyoruz
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi veriyoruz
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı güvenli bir şekilde kapatıyoruz
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
            if (txtBarkodNo != null) 
            {
                txtMitkari.Text = "1";
            }
        }

        private void temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMitkari)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Miktar doğrulaması
                if (!int.TryParse(txtMitkari.Text, out int miktar) || miktar <= 0)
                {
                    MessageBox.Show("Geçerli bir miktar giriniz.");
                    return; // Hatalı giriş yapılırsa, işlem sonlandırılır
                }

                barkodkontrol();
                if (durum == true)
                {
                    // Bağlantıyı açıyoruz
                    baglanti.Open();

                    // Parametreli sorgu ile veri ekliyoruz
                    SqlCommand komut = new SqlCommand("INSERT INTO sepet (tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyat, tarih) " +
                                                      "VALUES (@tc, @adsoyad, @telefon, @barkodno, @urunadi, @miktari, @satisfiyati, @toplamfiyat, @tarih)", baglanti);

                    komut.Parameters.AddWithValue("@tc", txtTc.Text);
                    komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                    komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                    komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
                    komut.Parameters.AddWithValue("@miktari", int.Parse(txtMitkari.Text));
                    komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyati.Text));
                    komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(txtToplamFiyati.Text));
                    komut.Parameters.AddWithValue("@tarih", DateTime.Now);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {
                    // Ürün zaten sepette var, miktarını güncelliyoruz
                    baglanti.Open();

                    // Parametreli sorgu ile miktar güncelleme işlemi
                    SqlCommand komut2 = new SqlCommand("UPDATE sepet SET miktari = miktari + @miktari WHERE barkodno = @barkodno", baglanti);
                    komut2.Parameters.AddWithValue("@miktari", int.Parse(txtMitkari.Text));
                    komut2.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                    komut2.ExecuteNonQuery();

                    // Toplam fiyatı güncelleme
                    SqlCommand komut3 = new SqlCommand("UPDATE sepet SET toplamfiyat = miktari * satisfiyati WHERE barkodno = @barkodno", baglanti);
                    komut3.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                    komut3.ExecuteNonQuery();

                    baglanti.Close();
                }

                // Sepet güncelleniyor
                daset.Tables["sepet"].Clear();
                sepetlistele();
                hesapla();

                // Formdaki kontrolleri temizliyoruz
                txtMitkari.Text = "1"; // Miktar 1 olarak sıfırlanır
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMitkari)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya mesaj gösteriyoruz
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı güvenli bir şekilde kapatıyoruz
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }


        }

        private void txtMitkari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyati.Text = (double.Parse(txtMitkari.Text) * double.Parse(txtSatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            //string kolonlar = "";
            //foreach (DataGridViewColumn kolon in dataGridView2.Columns)
            //{
            //    kolonlar += kolon.Name + ", ";
            //}
            //MessageBox.Show("Mevcut sütunlar: " + kolonlar);

            if (dataGridView2.CurrentRow != null)
            {
                try
                {
                    
                    baglanti.Open();
                    string sorgu = "DELETE FROM sepet WHERE barkodno=@barkodno";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@barkodno", dataGridView2.CurrentRow.Cells["barkodnoDataGridViewTextBoxColumn"].Value.ToString());
                    komut.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }

                daset.Tables["sepet"].Clear();
                sepetlistele();
                hesapla();
                MessageBox.Show("Ürün sepetten çıkarıldı");
            }
            else
            {
                MessageBox.Show("Lütfen önce silinecek bir satır seçin.");
            }


        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritabanı bağlantısını açıyoruz
                baglanti.Open();

                // Sepetteki tüm ürünleri silme işlemi
                SqlCommand komut = new SqlCommand("DELETE FROM sepet", baglanti);

                // Komutu çalıştırıyoruz
                komut.ExecuteNonQuery();

                // Veritabanı bağlantısını kapatıyoruz
                baglanti.Close();

                // Kullanıcıya bilgi mesajı gösteriyoruz
                MessageBox.Show("Ürünler sepetten çıkarıldı");

                // Veritabanındaki 'sepet' tablosunu temizliyoruz
                daset.Tables["sepet"].Clear();

                // Sepeti tekrar listelemek için fonksiyonu çağırıyoruz
                sepetlistele();

                // Genel toplamı sıfırlıyoruz
                hesapla();
                lblGenelToplam.Text = "00 TL";
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi veriyoruz
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }


        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyat,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyat,@tarih) ", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView2.Rows[i].Cells["barkodnoDataGridViewTextBoxColumn"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView2.Rows[i].Cells["urunadiDataGridViewTextBoxColumn"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView2.Rows[i].Cells["miktariDataGridViewTextBoxColumn"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView2.Rows[i].Cells["satisfiyatiDataGridViewTextBoxColumn"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView2.Rows[i].Cells["toplamfiyatDataGridViewTextBoxColumn"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'" + int.Parse(dataGridView2.Rows[i].Cells["miktariDataGridViewTextBoxColumn"].Value.ToString()) + " ' where barkodno='" + dataGridView2.Rows[i].Cells["barkodnoDataGridViewTextBoxColumn"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();


            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            lblGenelToplam.Text = " 00 TL";

            frmBitti ekle = new frmBitti();
            ekle.ShowDialog();

        }

        private void txtToplamFiyati_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}