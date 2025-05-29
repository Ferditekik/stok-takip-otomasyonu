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
    public partial class frmÜrünLisele : Form
    {
        public frmÜrünLisele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=FERDI-TEKIK\\SQLEXPRESS;Initial Catalog=Stok_Takip1;Integrated Security=True; ");
        DataSet daset= new DataSet();

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void frmÜrünLisele_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            kategorigetir();
        }

        private void ÜrünListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BakodNotxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            UrunAditxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            Miktaritxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            AlisFiyatitxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            SatisFiyatitxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritabanı bağlantısını açıyoruz
                baglanti.Open();

                // Parametreli sorgu ile güncelleme yapıyoruz
                SqlCommand komut = new SqlCommand("UPDATE urun SET urunadi = @urunadi, miktari = @miktari, alisfiyati = @alisfiyati, satisfiyati = @satisfiyati WHERE barkodno = @barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", BakodNotxt.Text);
                komut.Parameters.AddWithValue("@urunadi", UrunAditxt.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(Miktaritxt.Text)); // Hata kontrolü eklenebilir
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(AlisFiyatitxt.Text)); // Hata kontrolü eklenebilir
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(SatisFiyatitxt.Text)); // Hata kontrolü eklenebilir

                // Sorguyu çalıştırıyoruz
                komut.ExecuteNonQuery();

                // Veritabanı bağlantısını kapatıyoruz
                baglanti.Close();

                // Veriyi güncelledikten sonra listeyi temizliyoruz ve yeniden yüklüyoruz
                daset.Tables["urun"].Clear();
                ÜrünListele(); // Bu fonksiyonun verileri güncellediğinden emin olun

                // Başarılı işlem mesajı
                MessageBox.Show("Güncelleme Yapıldı");

                // Formdaki tüm TextBox kontrollerini temizliyoruz
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            catch (FormatException ex)
            {
                // Kullanıcıdan alınan veriler doğru formatta değilse bu hata yakalanır
                MessageBox.Show("Lütfen fiyat ve miktar alanlarını doğru formatta giriniz. " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Diğer olası hatalar için genel bir hata yakalama
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BakodNotxt.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori,marka=@marka where barkodmo=@barkodno ", baglanti);
                komut.Parameters.AddWithValue("@barkodno", BakodNotxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme Yapıldı");
                daset.Tables["ürün"].Clear();
                ÜrünListele();
            }
            else
            {
                MessageBox.Show("BarkodNo yazılı değil");
            }

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from markabilgileri where kategori='" + comboKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "delete from urun where barkodno = @barkodno";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
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

                daset.Tables["urun"].Clear();
                ÜrünListele();
                MessageBox.Show("Kayıt silindi");
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçiniz.");
            }

        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun where barkodno like '%" + txtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void BakodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (BakodNotxt.Text == "")
            {
                Kategoritxt.Text = "";
                Markatxt.Text = "";
                UrunAditxt.Text = "";
                Miktaritxt.Text = "";
                AlisFiyatitxt.Text = "";
                SatisFiyatitxt.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '" + BakodNotxt.Text + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Kategoritxt.Text = read["kategori"].ToString();
                Markatxt.Text = read["marka"].ToString();
                UrunAditxt.Text = read["urunadi"].ToString();
                Miktaritxt.Text = read["miktari"].ToString();
                AlisFiyatitxt.Text = read["alisfiyati"].ToString();
                SatisFiyatitxt.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }
    }
}
