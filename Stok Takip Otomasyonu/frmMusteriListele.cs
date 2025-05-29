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
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=FERDI-TEKIK\\SQLEXPRESS;Initial Catalog=Stok_Takip1;Integrated Security=True;");
        DataSet daset = new DataSet();
        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stok_Takip1DataSet.müşteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.müşteriTableAdapter.Fill(this.stok_Takip1DataSet.müşteri);
            Kayıt_Goster();

        }

        private void Kayıt_Goster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from müşteri", baglanti);
            adtr.Fill(daset, "müşteri");
            dataGridView1.DataSource = daset.Tables["müşteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adSoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells["eMail"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(
                    "UPDATE müşteri SET adSoyad = @adSoyad, telefon = @telefon, adres = @adres, eMail = @eMail WHERE tc = @tc",
                    baglanti
                );

                komut.Parameters.AddWithValue("@tc", txtTc.Text.Trim());
                komut.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text.Trim());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                komut.Parameters.AddWithValue("@adres", txtAdres.Text.Trim());
                komut.Parameters.AddWithValue("@eMail", txtMail.Text.Trim());

                komut.ExecuteNonQuery();
                MessageBox.Show("Müşteri kaydı güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            // Tabloyu ve arayüzü güncelle
            daset.Tables["müşteri"].Clear();
            Kayıt_Goster();

            // TextBox'ları temizle
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //string kolonlar = "";
            //foreach (DataGridViewColumn kolon in dataGridView1.Columns)
            //{
            //    kolonlar += kolon.Name + ", ";
            //}
            //MessageBox.Show("Mevcut sütunlar: " + kolonlar);
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "DELETE FROM müşteri WHERE tc = @tc";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tcDataGridViewTextBoxColumn"].Value.ToString());
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

                daset.Tables["müşteri"].Clear();
                Kayıt_Goster();
                MessageBox.Show("Kayıt silindi");
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçiniz.");
            }


        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();

            // Parametreli sorgu kullanarak SQL enjeksiyonuna karşı önlem alıyoruz
            SqlCommand komut = new SqlCommand("SELECT * FROM müşteri WHERE tc LIKE @tc", baglanti);
            komut.Parameters.AddWithValue("@tc", "%" + txtTcAra.Text + "%");

            SqlDataAdapter adtr = new SqlDataAdapter(komut);
            adtr.Fill(tablo);

            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
                txtAdres.Text = "";
                txtMail.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from müşteri where tc like '" + txtTc.Text + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtAdres.Text = read["telefon"].ToString();
                txtTelefon.Text = read["adres"].ToString();
                txtMail.Text = read["eMail"].ToString();
            }
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
