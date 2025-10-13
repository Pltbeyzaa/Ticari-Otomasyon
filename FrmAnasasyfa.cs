using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Alım_Satım_Otomasyonu
{
    public partial class FrmAnasasyfa : Form
    {
        public FrmAnasasyfa()
        {
            InitializeComponent();
        }
        Sql_Connection bgl = new Sql_Connection();
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl3_Click(object sender, EventArgs e)
        {

        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dayName = DateTime.Now.ToString("dddd", new CultureInfo("tr-TR"));
            txtGün.Text = dayName;
            txtTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
            txtSaat.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        public string adminA;
        private void FrmAnasasyfa_Load(object sender, EventArgs e)
        {
            txtKullanici.Text=adminA;

            SqlCommand görev = new SqlCommand("Select ALAN From Tbl_Personeller Where  AD=@p1", bgl.baglanti());
            görev.Parameters.AddWithValue("@p1", txtKullanici.Text);
            SqlDataReader dr=görev.ExecuteReader();       
          
            while (dr.Read())
            {
                txtGörev.Text = dr[0] + "";
             
            }
   
            DataTable dt = new DataTable();
            SqlDataAdapter dr2 = new SqlDataAdapter("Select  NOTTARIH,NOTSAAT,NOTBASLIK,NOTDETAY,NOTSAHIBI From Tbl_Notlar", bgl.baglanti());
            dr2.Fill(dt);
            gridControl2.DataSource = dt;

            webBrowser1.Navigate("https://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx?il=Elazig");
            donanımH();


        }
        public void donanımH()
        {
            XmlTextReader xml = new XmlTextReader("https://www.donanimhaber.com/rss/tum/");
                while(xml.Read())
            {
                if (xml.Name == "title")
                {

                    listBox1.Items.Add(xml.ReadString());
                }


            }

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void txtGörev_Click(object sender, EventArgs e)
        {

        }
    }
}
