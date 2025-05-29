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
    public partial class frmBitti : Form
    {
        public frmBitti()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=FERDI-TEKIK\\SQLEXPRESS;Initial Catalog=Stok_Takip1;Integrated Security=True; ");
        DataSet daset = new DataSet();
        private void frmBitti_Load(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from satis", baglanti);

                object sonuc = komut.ExecuteScalar();

                if (sonuc != null && sonuc != DBNull.Value)
                {
                    lblBittiFiyat.Text = Convert.ToDecimal(sonuc).ToString("0.00") + " TL";
                }
                else
                {
                    lblBittiFiyat.Text = "0.00 TL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
    }
}
