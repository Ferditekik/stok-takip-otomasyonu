using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Stok_Takip_Otomasyonu
{
    public partial class frmSifreYenilemecs : Form
    {
        public frmSifreYenilemecs()
        {
            InitializeComponent();
        }

        //SqlConnection baglanti = new SqlConnection("Data Source=FERDI-TEKIK\\SQLEXPRESS;Initial Catalog=Stok_Takip1;Integrated Security=True;");
        //DataSet daset = new DataSet();

        private void btnYenile_Click(object sender, EventArgs e)
        {
            sqlBaglantisi bgln = new sqlBaglantisi();
            SqlCommand komut = new SqlCommand("Select * from kullanicilar1 where kullaniciAdi='"+txtKullaniciAdi.ToString()+"' and ePosta='"+txtePosta.ToString()+"'",bgln.baglanti());

            SqlDataReader oku  = komut.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    if(bgln.baglanti().State==ConnectionState.Closed)
                    {
                        bgln.baglanti().Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    string tarih = DateTime.Now.ToLongDateString();
                    string mailAdresi = ("ferditekik8@gmail.com");
                    string sifre = ("123");
                    string smtpsrvr = "smtp.gmail.com";
                    string kime = (oku["ePosta"].ToString());
                    string konu = ("Şifre Hatırlatma Maili");
                    string yaz = ("Sayın, " + oku["adSoyad"].ToString() + "\n" + tarih + "Tarihinde Şifre Hatırlatmada " +
                        "Bulundunuz" + "\n" + "Parolanız" + oku["sifre"].ToString() + "\nİyi Günler");
                    smtpserver.Credentials = new NetworkCredential(mailAdresi, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailAdresi);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Şifreniz mail adresinize gönderilmiştir");
                    bgln.baglanti().Close();
                    this.Hide();

                }
                catch(Exception hata)
                {
                    MessageBox.Show("Mail gönderme hatası!",hata.Message);
                }
            }
        }

    }
}
