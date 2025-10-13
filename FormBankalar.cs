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
    public partial class FormBankalar : Form
    {
        public FormBankalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            //Listeleme metodu oluşturma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void firmalistesi()
        {
            //Firmalistesi Metodunuz Oluşturuyoruz
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID , AD From Tbl_Firmalar", bgl.baglanti());
            da.Fill(dt);
            firmalookedit.Properties.ValueMember = "ID";
            firmalookedit.Properties.DisplayMember = "AD";
            firmalookedit.Properties.DataSource = dt;
        }

        void temizle()
        {
            //Temizleme metodu oluşturma
            txtıd.Text = "";
            txtbankaad.Text = "";
            cmbxil.Text = "";
            cmbxilce.Text = "";
            firmalookedit.EditValue = "";
            txthesapno.Text = "";
            txthesaptürü.Text = "";
            txtiban.Text = "";
            txtsube.Text = "";
            txttarih.Text = "";
            txttelefon.Text = "";
            txtyetkili.Text = "";
            txtıd.Focus();

        }
        private void FormBankalar_Load(object sender, EventArgs e)
        {
            //Listele Metodunu ve Şehirlistesi Metodunu Çağırıyoruz
            //Firmalistesi metodunu çağırıyoruz
            listele();
            sehirlistesi();
            firmalistesi();
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


        private void btntemizle_Click(object sender, EventArgs e)
        {
            //Temizleme Metodunu Çağırıyoruz
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Gridde Listelenen Bilgileri Satırlara tıkladığımız zaman bunları araçlara aktarma
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtıd.Text = dr["ID"].ToString();
                txtbankaad.Text = dr["BANKAAD"].ToString();
                cmbxil.Text = dr["IL"].ToString();
                cmbxilce.Text = dr["ILCE"].ToString();
                firmalookedit.Text = dr["FIRMAID"].ToString();
                txthesapno.Text = dr["HESAPNO"].ToString();
                txthesaptürü.Text = dr["HESAPTURU"].ToString();
                txtiban.Text = dr["IBAN"].ToString();
                txtsube.Text = dr["SUBE"].ToString();
                txttarih.Text = dr["TARIH"].ToString();
                txttelefon.Text = dr["TELEFON"].ToString();
                txtyetkili.Text = dr["YETKILI"].ToString();
            }
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

            //Yeni Bir Banka Bilgisi Ekleme
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Bankalar " +
                "(BANKAAD , IL , ILCE , FIRMAID , HESAPNO , HESAPTURU , IBAN , SUBE , TARIH , TELEFON , YETKILI) values" +
                "(@p1 , @p2 , @p3, @p4 , @p5 , @p6 , @p7 , @p8 , @p9 , @p10 , @p11) ", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", txtbankaad.Text);
            komutkaydet.Parameters.AddWithValue("@p2", cmbxil.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbxilce.Text);
            komutkaydet.Parameters.AddWithValue("@p4", firmalookedit.EditValue);
            komutkaydet.Parameters.AddWithValue("@p5", txthesapno.Text);
            komutkaydet.Parameters.AddWithValue("@p6", txthesaptürü.Text);
            komutkaydet.Parameters.AddWithValue("@p7", txtiban.Text);
            komutkaydet.Parameters.AddWithValue("@p8", txtsube.Text);
            komutkaydet.Parameters.AddWithValue("@p9", txttarih.Text);
            komutkaydet.Parameters.AddWithValue("@p10", txttelefon.Text);
            komutkaydet.Parameters.AddWithValue("@p11", txtyetkili.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Sisteme Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            //Banka Bilgilerini Güncelleme
            SqlCommand komutgüncelle = new SqlCommand("update Tbl_Bankalar set BANKAAD = @p1 , IL = @p2 , ILCE = @p3 , FIRMAID = @p4 , HESAPNO = @p5 , HESAPTURU = @p6 , IBAN = @p7 , SUBE = @p8 , TARIH = @p9 , TELEFON= @p10 , YETKILI = @p11 where ID=@p12", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", txtbankaad.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", cmbxil.Text);
            komutgüncelle.Parameters.AddWithValue("@p3", cmbxilce.Text);
            komutgüncelle.Parameters.AddWithValue("@p4", firmalookedit.EditValue);
            komutgüncelle.Parameters.AddWithValue("@p5", txthesapno.Text);
            komutgüncelle.Parameters.AddWithValue("@p6", txthesaptürü.Text);
            komutgüncelle.Parameters.AddWithValue("@p7", txtiban.Text);
            komutgüncelle.Parameters.AddWithValue("@p8", txtsube.Text);
            komutgüncelle.Parameters.AddWithValue("@p9", txttarih.Text);
            komutgüncelle.Parameters.AddWithValue("@p10", txttelefon.Text);
            komutgüncelle.Parameters.AddWithValue("@p11", txtyetkili.Text);
            komutgüncelle.Parameters.Add("@p12", txtıd.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //Mevcut Banka Bilgisini Silme
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Bankalar where ID = @p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtıd.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Başarıyla Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
        }

        private void firmalookedit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
 