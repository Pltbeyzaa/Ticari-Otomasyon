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
    public partial class FormFirmalar : Form
    {
        public FormFirmalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            //Listeleme Metodu
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Firmalar", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void sehirlistesi()
        {
            //Şehirleri Çağırmak İçin Metot Oluşturuyoruz
            SqlCommand komutsehir = new SqlCommand("Select Sehir From Tbl_Iller", bgl.baglanti());
            SqlDataReader dt = komutsehir.ExecuteReader();
            while (dt.Read())
            {
                cmbxil.Properties.Items.Add(dt[0]);
            }
            bgl.baglanti().Close();

        }


        void temizle()
        {
            //Temizleme metodu oluşturma
            txtıd.Text = "";
            txtad.Text = "";
            txtsektör.Text = "";
            txtyetkili.Text = "";
            txtygörev.Text = "";
            txttelefon1.Text = "";
            txttelefon2.Text = "";
            txttelefon3.Text = "";
            txtmail.Text = "";
            cmbxil.Text = "";
            cmbxilce.Text = "";
            rchbxadres.Text = "";
            txtıd.Focus();

        }


        private void FormFirmalar_Load(object sender, EventArgs e)
        {
            //Listele Metodunu ve Şehirlistesi Metodunu Çağırıyoruz
            listele();
            sehirlistesi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Gridde Listelenen Bilgileri Satırlara tıkladığımız zaman bunları araçlara aktarma
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtıd.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                txtsektör.Text = dr["SEKTÖR"].ToString();
                txtyetkili.Text = dr["YETKİLİADSOYAD"].ToString();
                txtygörev.Text = dr["YETKİLİSTATÜ"].ToString();
                txttelefon1.Text = dr["TELEFON1"].ToString();
                txttelefon2.Text = dr["TELEFON2"].ToString();
                txttelefon3.Text = dr["TELEFON3"].ToString();
                txtmail.Text = dr["MAİL"].ToString();
                cmbxil.Text = dr["İL"].ToString();
                cmbxilce.Text = dr["İLÇE"].ToString();
                rchbxadres.Text = dr["ADRES"].ToString();
                
            }

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //Firmaları Kaydetme 
            SqlCommand komut = new SqlCommand("insert into Tbl_Firmalar " +
                "(AD , SEKTÖR , YETKİLİADSOYAD , YETKİLİSTATÜ , TELEFON1 , TELEFON2 , TELEFON3 , MAİL , İL , İLÇE , ADRES)  VALUES " +
                "(@p1 , @p2 , @p3 , @p4 , @p5 , @p6 , @p7 , @p8 , @p9 , @p10 , @p11) " , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsektör.Text);
            komut.Parameters.AddWithValue("@p3", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p4", txtygörev.Text);
            komut.Parameters.AddWithValue("@p5", txttelefon1.Text);
            komut.Parameters.AddWithValue("@p6", txttelefon2.Text);
            komut.Parameters.AddWithValue("@p7", txttelefon3.Text);
            komut.Parameters.AddWithValue("@p8", txtmail.Text);
            komut.Parameters.AddWithValue("@p9", cmbxil.Text);
            komut.Parameters.AddWithValue("@p10", cmbxilce.Text);
            komut.Parameters.AddWithValue("@p11", rchbxadres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
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

        private void btntemizle_Click(object sender, EventArgs e)
        {
            //Temizleme Metodunu Çağırıyoruz1
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //Firmaları Silme
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Firmalar where ID = @p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtıd.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Başarıyla Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            //Firma Bilgilerini Günceleme 
            SqlCommand komut = new SqlCommand("update Tbl_Firmalar set AD = @p1 , SEKTÖR = @p2 , YETKİLİADSOYAD = @p3 , YETKİLİSTATÜ = @p4 , TELEFON1 = @p5 , TELEFON2 = @p6 , TELEFON3 = @p7 , MAİL = @p8 , İL = @p9 , İLÇE = @p10 , ADRES = @p11 where ID = @p12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsektör.Text);
            komut.Parameters.AddWithValue("@p3", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p4", txtygörev.Text);
            komut.Parameters.AddWithValue("@p5", txttelefon1.Text);
            komut.Parameters.AddWithValue("@p6", txttelefon2.Text);
            komut.Parameters.AddWithValue("@p7", txttelefon3.Text);
            komut.Parameters.AddWithValue("@p8", txtmail.Text);
            komut.Parameters.AddWithValue("@p9", cmbxil.Text);
            komut.Parameters.AddWithValue("@p10", cmbxilce.Text);
            komut.Parameters.AddWithValue("@p11", rchbxadres.Text);
            komut.Parameters.Add("@p12", txtıd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

        }
    }
}
