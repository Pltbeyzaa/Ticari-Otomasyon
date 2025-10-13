using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alım_Satım_Otomasyonu
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        Sql_Connection bgl = new Sql_Connection();


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
            txtKullanici.Text = adminA;

            SqlCommand görev = new SqlCommand("Select ALAN From Tbl_Personeller Where  AD=@p1", bgl.baglanti());
            görev.Parameters.AddWithValue("@p1", txtKullanici.Text);
            SqlDataReader dr = görev.ExecuteReader();

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
            while (xml.Read())
            {
                if (xml.Name == "title")
                {

                    listBox1.Items.Add(xml.ReadString());
                }

            }



        }
    }
