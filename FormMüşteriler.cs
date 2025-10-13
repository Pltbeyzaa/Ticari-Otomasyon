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
    public partial class FormMüşteriler : Form
    {
        public FormMüşteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            //Listeleme metodu oluşturma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Musteri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void temizle()
        {
            //Temizleme metodu oluşturma
            txtıd.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            mtxtboxtelefon.Text = "";
            txtmail.Text = "";
            cmbxil.Text = "";
            cmbxilce.Text = "";
            rchbxadres.Text = "";
            
            txtıd.Focus();

        }

        void sehirlistesi()
        {
            //Şehirleri Çağırmak İçin Metot Oluşturuyoruz
            SqlCommand komutsehir = new SqlCommand("Select Sehir From Tbl_Iller" , bgl.baglanti());
            SqlDataReader dt = komutsehir.ExecuteReader();
            while (dt.Read())
            {
                cmbxil.Properties.Items.Add(dt[0]);
            }
            bgl.baglanti().Close();

        }

        private void FormMüşteriler_Load(object sender, EventArgs e)
        {
            //Listele Metodunu ve Şehirlistesi Metodunu Çağırıyoruz
            listele();

            sehirlistesi();

            
        }

        private void cmbxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen İle göre İlçeleri Çağırıyoruz
            cmbxilce.Properties.Items.Clear();
            SqlCommand komutilce = new SqlCommand("Select ILCE From Tbl_Ilceler Where Sehir=@p1", bgl.baglanti());
            komutilce.Parameters.AddWithValue("@p1", cmbxil.SelectedIndex + 1);
            SqlDataReader dt = komutilce.ExecuteReader();
            while (dt.Read())
            {
                cmbxilce.Properties.Items.Add(dt[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //Müşterileri Kaydetme
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Musteri " +
                "(AD , SOYAD , TELEFON , MAİL , İL , İLÇE , ADRES) values" +
                "(@p1 , @p2 , @p3, @p4 , @p5 , @p6 , @p7) " , bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1" , txtad.Text);
            komutkaydet.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p3", mtxtboxtelefon.Text);
            komutkaydet.Parameters.AddWithValue("@p4", txtmail.Text);
            komutkaydet.Parameters.AddWithValue("@p5", cmbxil.Text);
            komutkaydet.Parameters.AddWithValue("@p6", cmbxilce.Text);
            komutkaydet.Parameters.AddWithValue("@p7", rchbxadres.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //Müşterileri Silme
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Musteri where ID = @p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtıd.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Başarıyla Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Gridde Listelenen Bilgileri Satırlara tıkladığımız zaman bunları araçlara aktarma
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtıd.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                txtsoyad.Text = dr["SOYAD"].ToString();
                mtxtboxtelefon.Text = dr["TELEFON"].ToString();
                txtmail.Text = dr["MAİL"].ToString();
                cmbxil.Text = dr["İL"].ToString();
                cmbxilce.Text = dr["İLÇE"].ToString();
                rchbxadres.Text = dr["ADRES"].ToString();
            }
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            //Müşteri Bilgilerini Güncelleme
            SqlCommand komutgüncelle = new SqlCommand("update Tbl_Musteri set AD = @g1 , SOYAD = @g2 , TELEFON = @g3 , MAİL= @g4 , İL = @g5 , İLÇE = @g6 , ADRES = @g7 where ID = @g8", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@g1", txtad.Text);
            komutgüncelle.Parameters.AddWithValue("@g2", txtsoyad.Text);
            komutgüncelle.Parameters.AddWithValue("@g3", mtxtboxtelefon.Text);
            komutgüncelle.Parameters.AddWithValue("@g4", txtmail.Text);
            komutgüncelle.Parameters.AddWithValue("@g5", cmbxil.Text);
            komutgüncelle.Parameters.AddWithValue("@g6", cmbxilce.Text);
            komutgüncelle.Parameters.AddWithValue("@g7", rchbxadres.Text);
            komutgüncelle.Parameters.Add("@g8", txtıd.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();


        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            //Temizleme Metodunu Çağırıyoruz
            temizle();
        }
    }
}
