﻿using System;
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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=FERDI-TEKIK\\SQLEXPRESS;Initial Catalog=Stok_Takip1;Integrated Security=True; ");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into markabilgileri(kategori,marka) values('"+comboBox1.Text+"','" + textBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            textBox1.Text = "";
            comboBox1.Text = "";
            MessageBox.Show("Marka eklendi");
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
             kategorigetir();
        }

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
    }
}
