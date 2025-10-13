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
using System.Globalization;
using System.Xml;

namespace Ticari_Otomasyon
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select top 5 TARIH , SAAT , BASLIK , DETAY From Tbl_Notlar order by ID desc", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void fihrist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD , TELEFON1 From Tbl_Firmalar", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }


        private void FormAnasayfa_Load(object sender, EventArgs e)
        {
            ajanda();
            fihrist();
            haberler();

            webBrowser1.Navigate("https://www.mgm.gov.tr");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dayName = DateTime.Now.ToString("dddd", new CultureInfo("tr-TR"));
            TxtGün.Text = dayName;
            TxtTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
            TxtSaat.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        public void haberler()
        {
            XmlTextReader xml = new XmlTextReader("https://www.elle.com/rss/fashion.xml/");
            while (xml.Read())
            {
                if (xml.Name == "title")
                {

                    listBox1.Items.Add(xml.ReadString());
                }

            }
        }
    }
}