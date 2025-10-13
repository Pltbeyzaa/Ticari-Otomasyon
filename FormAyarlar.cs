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
    public partial class FormAyarlar : Form
    {
        public FormAyarlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Admin", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FormAyarlar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Yeni Admin Kaydetme
            if (simpleButton1.Text == "Kaydet") {
                SqlCommand komut = new SqlCommand("insert into Tbl_Admin values (@p1 , @p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtkullaniciadi.Text);
                komut.Parameters.AddWithValue("@p2", txtsifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Admin Sisteme Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            //Admin Bilgisini Güncelleme
            if (simpleButton1.Text == "Güncelle")
            { 
                SqlCommand komut = new SqlCommand("update Tbl_Admin set SİFRE = @p2 Where KULLANİCİAD = @p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtkullaniciadi.Text);
                komut.Parameters.AddWithValue("@p2", txtsifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Admin Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Gridde Listelenen Bilgileri Satırlara tıkladığımız zaman bunları araçlara aktarma
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtkullaniciadi.Text = dr["KULLANİCİAD"].ToString();
            txtsifre.Text = dr["SİFRE"].ToString();
        }

        private void txtkullaniciadi_EditValueChanged(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text != "")
            {
                simpleButton1.Text = "Güncelle";
            }
            else
            {
                simpleButton1.Text = "Kaydet";
            }
        }
    }
}
