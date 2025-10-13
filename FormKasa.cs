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
using DevExpress.Charts;
using DevExpress.XtraBars;

namespace Ticari_Otomasyon
{
    public partial class FormKasa : Form
    {
        public FormKasa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute ", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        public string aktif;

        private void FormKasa_Load(object sender, EventArgs e)
        {
            DataTable dt0 = new DataTable();
            SqlDataAdapter da0 = new SqlDataAdapter("Select *From Tbl_Giderler", bgl.baglanti());
            da0.Fill(dt0);
            gridControl3.DataSource = dt0;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_FirmaHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select *From Tbl_MüşteriHareketler", bgl.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;

            SqlCommand toplamTutar = new SqlCommand("Select Sum(TOPLAM) from Tbl_MüşteriHareketler ", bgl.baglanti());
            SqlDataReader dr = toplamTutar.ExecuteReader();
            while (dr.Read())
            {
                lbltoplamtutar.Text = dr[0] + "";

            }
            SqlCommand odemeler = new SqlCommand("Select Sum(ELEKTRIK+SU+DOGALGAZ+INTERNET+MAASLAR+EKSTRA) from Tbl_Giderler", bgl.baglanti());
            SqlDataReader dr2 = odemeler.ExecuteReader();
            while (dr2.Read())
            {
                lblödemeler.Text = dr2[0] + "";

            }
            SqlCommand maaslar = new SqlCommand("Select Sum(MAASLAR) from Tbl_Giderler", bgl.baglanti());
            SqlDataReader dr3 = maaslar.ExecuteReader();
            while (dr3.Read())
            {
                lblpersonelmmas.Text = dr3[0] + "";

            }
            SqlCommand personelS = new SqlCommand("Select Count(ID) from Tbl_Personeller", bgl.baglanti());
            SqlDataReader dr4 = personelS.ExecuteReader();
            while (dr4.Read())
            {
                lblpersonelsayısı.Text = dr4[0] + "";

            }
            lblaktifkullanici.Text = aktif;

 
        }
        int sayac=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 0 && sayac <= 5)
            {
                //1. Chart Controle Elektrik Faturası Son 4 Ay Listeleme 
                groupBox1.Text = "Elektrik Gideri";
                SqlCommand komut1 = new SqlCommand("Select top 4 AY ,ELEKTRIK From Tbl_Giderler order By ID Desc", bgl.baglanti());
                SqlDataReader dr5 = komut1.ExecuteReader();
                while (dr5.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr5[0], dr5[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 5 && sayac <= 10)
            {
                
                groupBox1.Text = "SU Gideri";
                SqlCommand komut2 = new SqlCommand("Select top 4 AY ,SU From Tbl_Giderler order By ID Desc", bgl.baglanti());
                SqlDataReader dr6 = komut2.ExecuteReader();
                while (dr6.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr6[0], dr6[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 10 && sayac <= 15)
            {
             
                groupBox1.Text = "Doğalgaz Gideri";
                SqlCommand komut3 = new SqlCommand("Select top 4 AY ,DOGALGAZ From Tbl_Giderler order By ID Desc", bgl.baglanti());
                SqlDataReader dr7 = komut3.ExecuteReader();
                while (dr7.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr7[0], dr7[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 15&& sayac <= 20)
            {
               
                groupBox1.Text = "İnternet Gideri";
                SqlCommand komut4 = new SqlCommand("Select top 4 AY ,INTERNET From Tbl_Giderler order By ID Desc", bgl.baglanti());
                SqlDataReader dr8 = komut4.ExecuteReader();
                while (dr8.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr8[0], dr8[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 20 && sayac <= 25)
            {
                
                groupBox1.Text = "Maaşlar Gideri";
                SqlCommand komut5 = new SqlCommand("Select top 4 AY ,MAASLAR From Tbl_Giderler order By ID Desc", bgl.baglanti());
                SqlDataReader dr9 = komut5.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr9[0], dr9[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 25 && sayac <= 30)
            {
                
                groupBox1.Text = "Ekstra Giderler";
                SqlCommand komut6 = new SqlCommand("Select top 4 AY , EKSTRA From Tbl_Giderler order By ID Desc", bgl.baglanti());
                SqlDataReader dr10 = komut6.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
                sayac = 0;
            }
           
        }
       
    }
}
    