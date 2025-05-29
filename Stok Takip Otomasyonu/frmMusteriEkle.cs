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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Stok_Takip1;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO müşteri (tc, adSoyad, telefon, adres, eMail) VALUES (@tc, @adSoyad, @telefon, @adres, @eMail)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text.Trim());
                komut.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text.Trim());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                komut.Parameters.AddWithValue("@adres", txtAdres.Text.Trim());
                komut.Parameters.AddWithValue("@eMail", txtMail.Text.Trim());
                komut.ExecuteNonQuery();
                MessageBox.Show("Müşteri kaydı eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
            this.Close();

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
