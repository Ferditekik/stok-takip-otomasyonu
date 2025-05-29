using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stok_Takip_Otomasyonu
{
    public partial class frmÜrünEkle : Form
    {
        public frmÜrünEkle()
        {
            InitializeComponent();
        }

        void temizle()
        {
            txtBarkodNo.Text = "";
            ComboKategori.Text = "";
            comboMarka.Text = "";
            txtUrunAdi.Text = "";
            txtMiktari.Text = "";
            txtSatisFiyati.Text = "";
            txtAlisFiyati.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=FERDI-TEKIK\\SQLEXPRESS;Initial Catalog=Stok_Takip1;Integrated Security=True; ");
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString()  || txtBarkodNo.Text=="")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }


        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ComboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void frmÜrünEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void ComboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from markabilgileri where kategori='" + ComboKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if(durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urun(barkodno, kategori, marka, urunadi, miktari, alisfiyati,satisfiyati, tarih) values(@barkodno, @kategori, @marka, @urunadi, @miktari, @alisfiyati,@satisfiyati, @tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", ComboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlisFiyati.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyati.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteReader();
                baglanti.Close();
                MessageBox.Show("Ürün eklendi");
                temizle();
            }


            comboMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                temizle();
                
            }

        }

        private void btnVarOlanaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE urun SET miktari = miktari + @miktar WHERE barkodno = @barkodno", baglanti);
                komut.Parameters.AddWithValue("@miktar", int.Parse(Miktaritxt.Text));
                komut.Parameters.AddWithValue("@barkodno", BakodNotxt.Text);
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
                temizle();
                MessageBox.Show("Var olan ürüne ekleme yapıldı");
            }
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

            //if (BakodNotxt.Text == "")
            //{
            //    lblMiktari.Text = "";
            //    foreach (Control item in groupBox2.Controls)
            //    {
            //        temizle();
            //    }

            //    baglanti.Open();
            //    SqlCommand sql = new SqlCommand("select *from urun where barkodno like'" + txtBarkodNo.Text + "'", baglanti);
            //    SqlDataReader read = sql.ExecuteReader();
            //    while (read.Read())
            //    {
            //        Kategoritxt.Text = read["kategori"].ToString();
            //        Markatxt.Text = read["marka"].ToString();
            //        UrunAditxt.Text = read["urunadi"].ToString();
            //        Miktaritxt.Text = read["miktari"].ToString();
            //        AlisFiyatitxt.Text = read["alisfiyati"].ToString();
            //        SatisFiyatitxt.Text = read["satisfiyati"].ToString();
            //    }
            //    baglanti.Close();
            //}
        }
    }
}
