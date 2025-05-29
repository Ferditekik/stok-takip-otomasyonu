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
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }

        SqlConnection baglanti =new SqlConnection("Data Source=FERDI-TEKIK\\SQLEXPRESS;Initial Catalog=Stok_Takip1;Integrated Security=True; ");    

        private void frmKategori_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Parametreli sorgu kullanarak SQL enjeksiyonunu önlüyoruz
                SqlCommand komut = new SqlCommand("INSERT INTO kategoribilgileri(kategori) VALUES(@kategori)", baglanti);
                komut.Parameters.AddWithValue("@kategori", textBox1.Text);

                // Komutu çalıştırıyoruz
                komut.ExecuteNonQuery();

                // Bağlantıyı kapatıyoruz
                baglanti.Close();

                // TextBox'ı temizliyoruz
                textBox1.Text = "";

                // Kullanıcıya başarı mesajı gösteriyoruz
                MessageBox.Show("Kategori eklendi");
            }
            catch (Exception ex)
            {
                // Hata oluşursa, kullanıcıya hata mesajı gösteriyoruz
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }
    }
}
