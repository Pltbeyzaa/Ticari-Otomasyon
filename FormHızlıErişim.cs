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
    public partial class FormHızlıErişim : Form
    {
        public FormHızlıErişim()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FormHızlıErişim_Load(object sender, EventArgs e)
        {
            //Müşteri Bilgileri
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select AD , SOYAD , TELEFON , MAİL , İL , İLÇE , ADRES From Tbl_Musteri", bgl.baglanti());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;

            //Firma Bilgileri
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select AD , YETKİLİADSOYAD , TELEFON1 , TELEFON2 , TELEFON3 , MAİL From Tbl_Firmalar", bgl.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;
        }
    }
}
