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
using DevExpress.Utils.VisualEffects;

namespace Ticari_Otomasyon
{
    public partial class FormELbise : Form
    {
        public FormELbise()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void temizle()
        {
            //Temizleme Metodunu Oluşturuyoruz
            txtıd.Text = "";
            txtad.Text = "";
            txtmarka.Text = "";
            nmrcadet.Value = 0;
            txtalışfiyat.Text = "";
            txtsatışfiyat.Text = "";
            txtkategori.Text = "";
            rchtxbdetay.Text = "";
            txtıd.Focus();

        }

        void listele()
        {
            //Listeleme Metodunu Oluşturuyoruz
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Elbise", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FormELbise_Load(object sender, EventArgs e)
        {
            //Listele Metodunu Çağırıyoruz
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //VERİLERİ KAYDETME
            SqlCommand komut = new SqlCommand("insert into Tbl_Elbise(ÜRÜNAD , MARKA , ADET , ALIŞFİYAT , SATIŞFİYAT , KATEGORİ , DETAY) values (@p1 , @p2 , @p3 , @p4 , @p5 , @p6 , @p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut.Parameters.AddWithValue("@p3", int.Parse((nmrcadet.Value).ToString()));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtalışfiyat.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txtsatışfiyat.Text));
            komut.Parameters.AddWithValue("@p6", txtkategori.Text);
            komut.Parameters.AddWithValue("@p7", rchtxbdetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //Silme Komutu
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Elbise where ID = @p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtıd.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            //Temizleme Metodunu Çağırıyoruz
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Gridde Listelenen Bilgileri Satırlara tıkladığımız zaman bunları araçlara aktarma
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtıd.Text = dr["ID"].ToString();
            txtad.Text = dr["ÜRÜNAD"].ToString();
            txtmarka.Text = dr["MARKA"].ToString();
            nmrcadet.Value = decimal.Parse(dr["ADET"].ToString());
            txtalışfiyat.Text = dr["ALIŞFİYAT"].ToString();
            txtsatışfiyat.Text = dr["SATIŞFİYAT"].ToString();
            txtkategori.Text = dr["KATEGORİ"].ToString();
            rchtxbdetay.Text = dr["DETAY"].ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            //Güncelleme Komutu
            SqlCommand komutgüncelle = new SqlCommand("update Tbl_Elbise set ÜRÜNAD = @p1 , MARKA = @p2 , ADET = @p3 , ALIŞFİYAT = @p4 , SATIŞFİYAT = @p5 , KATEGORİ = @p6 , DETAY = @p7 where ID = @p8", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", txtad.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", txtmarka.Text);
            komutgüncelle.Parameters.AddWithValue("@p3", int.Parse((nmrcadet.Value).ToString()));
            komutgüncelle.Parameters.AddWithValue("@p4", decimal.Parse(txtalışfiyat.Text));
            komutgüncelle.Parameters.AddWithValue("@p5", decimal.Parse(txtsatışfiyat.Text));
            komutgüncelle.Parameters.AddWithValue("@p6", txtkategori.Text);
            komutgüncelle.Parameters.AddWithValue("@p7", rchtxbdetay.Text);
            komutgüncelle.Parameters.Add("@p8", txtıd.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
