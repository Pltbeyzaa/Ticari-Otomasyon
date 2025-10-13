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

namespace Ticari_Otomasyon
{
    public partial class FormFaturalar : Form
    {
        public FormFaturalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            //Listeleme Metodu
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_FaturaBilgi", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle1()
        {
            //Temizleme metodu oluşturma
            txtfaturabilgiıd.Text = "";
            txtseri.Text = "";
            txtsırano.Text = "";
            msktarih.Text = "";
            msksaat.Text = "";
            txtalıcı.Text = "";
            txtteslimeden.Text = "";
            txtteslimalan.Text = "";

        }

        void temizle2()
        {
            //Temizleme metodu oluşturma
            txtfaturaurunıd.Text = "";
            txturunad.Text = "";
            txtfiyat.Text = "";
            txtmiktar.Text = "";
            txttutar.Text = "";
            txtfaturaıd.Text = "";
           
        }

        private void FormFaturalar_Load(object sender, EventArgs e)
        {
            //Listeleme Metodunu Çağırıyoruz
            listele();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //Fatura Bilgisi Kaydetme
                SqlCommand komut = new SqlCommand("insert into Tbl_FaturaBilgi " +
                    "(SERI , SIRANO , TARIH , SAAT , ALICI , TESLIMEDEN , TESLIMALAN)  VALUES " +
                    "(@p1 , @p2 , @p3 , @p4 , @p5 , @p6 , @p7 ) ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtseri.Text);
                komut.Parameters.AddWithValue("@p2", txtsırano.Text);
                komut.Parameters.AddWithValue("@p3", msktarih.Text);
                komut.Parameters.AddWithValue("@p4", msksaat.Text);
                komut.Parameters.AddWithValue("@p5", txtalıcı.Text);
                komut.Parameters.AddWithValue("@p6", txtteslimeden.Text);
                komut.Parameters.AddWithValue("@p7", txtteslimalan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Gridde Listelenen Bilgileri Satırlara tıkladığımız zaman bunları araçlara aktarma
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtfaturabilgiıd.Text = dr["FATURABILGIID"].ToString();
                txtseri.Text = dr["SERI"].ToString();
                txtsırano.Text = dr["SIRANO"].ToString();
                msktarih.Text = dr["TARIH"].ToString();
                msksaat.Text = dr["SAAT"].ToString();
                txtalıcı.Text = dr["ALICI"].ToString();
                txtteslimeden.Text = dr["TESLIMEDEN"].ToString();
                txtteslimalan.Text = dr["TESLIMALAN"].ToString();

            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Temizleme Metodunu Çağırıyoruz
            temizle1();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            //Fatura Detayı Ekleme
            double miktar, tutar, fiyat;
            fiyat = Convert.ToDouble(txtfiyat.Text);
            miktar = Convert.ToDouble(txtmiktar.Text);
            tutar = miktar * fiyat;
            txttutar.Text = tutar.ToString();


            SqlCommand komut = new SqlCommand("insert into Tbl_FaturaDetay " +
                "(URUNAD , MIKTAR , FIYAT , TUTAR , FATURAID )  VALUES " +
                "(@p1 , @p2 , @p3 , @p4 , @p5) ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txturunad.Text);
            komut.Parameters.AddWithValue("@p2", txtmiktar.Text);
            komut.Parameters.AddWithValue("@p3", txtfiyat.Text);
            komut.Parameters.AddWithValue("@p4", txttutar.Text);
            komut.Parameters.AddWithValue("@p5", txtfaturaıd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Faturaya Ait Ürün Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //Fatura Silme
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_FaturaBilgi where FATURABILGIID = @p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtfaturabilgiıd.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Başarıyla Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
        }

        

        

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //Fatura Bilgilerini Günceleme 
            SqlCommand komut = new SqlCommand("update Tbl_FaturaBilgi set SERI = @p1 , SIRANO = @p2 , TARIH = @p3 , SAAT = @p4 , ALICI = @p5 , TESLIMEDEN = @p6 , TESLIMALAN = @p7  where FATURABILGIID = @p8", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtseri.Text);
            komut.Parameters.AddWithValue("@p2", txtsırano.Text);
            komut.Parameters.AddWithValue("@p3", msktarih.Text);
            komut.Parameters.AddWithValue("@p4", msksaat.Text);
            komut.Parameters.AddWithValue("@p5", txtalıcı.Text);
            komut.Parameters.AddWithValue("@p6", txtteslimeden.Text);
            komut.Parameters.AddWithValue("@p7", txtteslimalan.Text);
            komut.Parameters.Add("@p8", txtfaturabilgiıd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

       

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormÜrünler fr = new FormÜrünler();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null )
            {
                fr.id = dr["FATURABILGIID"].ToString();
            }
            fr.Show();
        }
    }
}






