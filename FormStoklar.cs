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
    public partial class FormStoklar : Form
    {
        public FormStoklar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FormStoklar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute StokGrafik" , bgl.baglanti());
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            gridControl1.DataSource = dt1;

            //Charta Stok Miktarı Listeleme
            SqlCommand komut1 = new SqlCommand("Execute StokGrafik" , bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr1[0]), int.Parse(dr1[1].ToString()));
            }
            bgl.baglanti().Close();

            //Charta Firma Şehir Sayısı Çekme
            SqlCommand komut2 = new SqlCommand("Select İL , Count (*) From Tbl_Firmalar Group By İL", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            bgl.baglanti().Close();
        }
    }
}
