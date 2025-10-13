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
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    public partial class FormÜrünDüzenleme : Form
    {
        public FormÜrünDüzenleme()
        {
            InitializeComponent();
        }
        public string urunıd;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FormÜrünDüzenleme_Load(object sender, EventArgs e)
        {
            txtdtyfaturaurunıd.Text = urunıd;
            SqlCommand komut = new SqlCommand("Select * From Tbl_FaturaDetay where FATURAURUNİD = @p1" , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1" , urunıd);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                txtdtyfiyat.Text = dr[3].ToString();
                txtdtymiktar.Text = dr[2].ToString();
                txtdtytutar.Text = dr[4].ToString();
                txtdtyurunad.Text = dr[1].ToString();
                

            }

            bgl.baglanti().Close();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            //Faturadaki Ürün Bilgilerini Günceleme 
            SqlCommand komut = new SqlCommand("update Tbl_FaturaDetay set URUNAD = @p1 , MIKTAR = @p2 , FIYAT = @p3 , TUTAR = @p4 , FATURAID = @p5 where FATURAURUNİD =@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtdtyurunad.Text);
            komut.Parameters.AddWithValue("@p2", txtdtymiktar.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtdtyfiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtdtytutar.Text));
            komut.Parameters.AddWithValue("@p5", txtNrmfaturaıd.Text);
            komut.Parameters.AddWithValue("@p6", txtdtyfaturaurunıd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //Faturadaki Ürünleri Silme
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_FaturaDetay where ID = @p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtdtyfaturaurunıd.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Başarıyla Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
