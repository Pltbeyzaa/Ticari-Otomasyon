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
    public partial class FormNotlar : Form
    {
        public FormNotlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void temizle()
        {
            //Temizleme Metodu
            txtıd.Text = "";
            msktarih.Text = "";
            msksaat.Text = "";
            txtolusturan.Text = "";
            txtbaslık.Text = "";
            rchdetay.Text = "";
            txtıd.Focus();

        }

        void listele()
        {
            //Listeleme Metodu
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Notlar", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FormNotlar_Load(object sender, EventArgs e)
        {
            //Listele Metodunu Çağırıyoruz
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //Notları KAYDETME
            SqlCommand komut = new SqlCommand("insert into Tbl_Notlar(TARIH , SAAT , OLUSTURAN , BASLIK , DETAY) values (@p1 , @p2 , @p3 , @p4 , @p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktarih.Text);
            komut.Parameters.AddWithValue("@p2", msksaat.Text);
            komut.Parameters.AddWithValue("@p3", txtolusturan.Text);
            komut.Parameters.AddWithValue("@p4", txtbaslık.Text);
            komut.Parameters.AddWithValue("@p5", rchdetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Sisteme Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //Silme Komutu
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Notlar where ID = @p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtıd.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Seçilen Not Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Gridde Listelenen Bilgileri Satırlara tıkladığımız zaman bunları araçlara aktarma
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtıd.Text = dr["ID"].ToString();
            msktarih.Text = dr["TARIH"].ToString();
            msksaat.Text = dr["SAAT"].ToString();
            txtolusturan.Text = dr["OLUSTURAN"].ToString();
            txtbaslık.Text = dr["BASLIK"].ToString();
            rchdetay.Text = dr["DETAY"].ToString();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            //Temizleme Metodunu Çağırıyoruz
            temizle();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            //Güncelleme Komutu
            SqlCommand komutgüncelle = new SqlCommand("update Tbl_Notlar set TARIH = @p1 , SAAT = @p2 , OLUSTURAN = @p3 , BASLIK = @p4 , DETAY = @p5 where ID = @p6", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", msktarih.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", msksaat.Text);
            komutgüncelle.Parameters.AddWithValue("@p3", txtolusturan.Text);
            komutgüncelle.Parameters.AddWithValue("@p4", txtbaslık.Text);
            komutgüncelle.Parameters.AddWithValue("@p5", rchdetay.Text);
            komutgüncelle.Parameters.Add("@p6", txtıd.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
