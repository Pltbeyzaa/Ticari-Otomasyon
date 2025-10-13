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
    public partial class FormGiderler : Form
    {
        public FormGiderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            //Listeleme metodu oluşturma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Giderler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void temizle()
        {
            //Temizleme metodu oluşturma
            txtıd.Text = "";
            cmbxay.Text = "";
            cmbxyıl.Text = "";
            txtelektrik.Text = "";
            txtsu.Text = "";
            txtdoğalgaz.Text = "";
            txtinternet.Text = "";
            txtmaas.Text = "";
            txtekstra.Text = "";
            rchnot.Text = "";
            txtıd.Focus();

        }
        private void FormGiderler_Load(object sender, EventArgs e)
        {
            //Listele Metodunu Çağırıyoruz
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //Yeni Gider Ekleme
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Giderler " +
                "(AY , YIL , ELEKTRIK , SU , DOGALGAZ , INTERNET , MAASLAR , EKSTRA , NOTLAR) values" +
                "(@p1 , @p2 , @p3, @p4 , @p5 , @p6 , @p7 , @p8 , @p9) ", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", cmbxay.Text);
            komutkaydet.Parameters.AddWithValue("@p2", cmbxyıl.Text);
            komutkaydet.Parameters.AddWithValue("@p3", txtelektrik.Text);
            komutkaydet.Parameters.AddWithValue("@p4", txtsu.Text);
            komutkaydet.Parameters.AddWithValue("@p5", txtdoğalgaz.Text);
            komutkaydet.Parameters.AddWithValue("@p6", txtinternet.Text);
            komutkaydet.Parameters.AddWithValue("@p7", txtmaas.Text);
            komutkaydet.Parameters.AddWithValue("@p8", txtekstra.Text);
            komutkaydet.Parameters.AddWithValue("@p9", rchnot.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Aylık Gider Sisteme Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //Mevcut Gideri Silme
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Giderler where ID = @p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtıd.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Bilgisi Başarıyla Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Gridde Listelenen Bilgileri Satırlara tıkladığımız zaman bunları araçlara aktarma
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtıd.Text = dr["ID"].ToString();
                cmbxay.Text = dr["AY"].ToString();
                cmbxyıl.Text = dr["YIL"].ToString();
                txtelektrik.Text = dr["ELEKTRIK"].ToString();
                txtsu.Text = dr["SU"].ToString();
                txtinternet.Text = dr["INTERNET"].ToString();
                txtdoğalgaz.Text = dr["DOGALGAZ"].ToString();
                txtmaas.Text = dr["MAASLAR"].ToString();
                txtekstra.Text = dr["EKSTRA"].ToString();
                rchnot.Text = dr["NOTLAR"].ToString();
            }
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            //Giderler Bilgilerini Güncelleme
            SqlCommand komutgüncelle = new SqlCommand("update Tbl_Giderler set AY= @p1 , YIL= @p2 , ELEKTRIK= @p3 , SU= @p4 , DOGALGAZ= @p5 , INTERNET= @p6 , MAASLAR= @p7 , EKSTRA= @p8 , NOTLAR= @p9 where ID = @p10", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", cmbxay.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", cmbxyıl.Text);
            komutgüncelle.Parameters.AddWithValue("@p3", txtelektrik.Text);
            komutgüncelle.Parameters.AddWithValue("@p4", txtsu.Text);
            komutgüncelle.Parameters.AddWithValue("@p5", txtdoğalgaz.Text);
            komutgüncelle.Parameters.AddWithValue("@p6", txtinternet.Text);
            komutgüncelle.Parameters.AddWithValue("@p7", txtmaas.Text);
            komutgüncelle.Parameters.AddWithValue("@p8", txtekstra.Text);
            komutgüncelle.Parameters.AddWithValue("@p9", rchnot.Text);
            komutgüncelle.Parameters.Add("@p10", txtıd.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            //Temizleme Metodunu Çağırıyoruz
            temizle();
        }
    }
}
