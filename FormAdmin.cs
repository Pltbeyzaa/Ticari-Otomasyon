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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btngirisyap.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btngirisyap.BackColor = Color.White;
        }
       
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Admin where KULLANİCİAD = @p1 AND SİFRE = @p2" , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1" , txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 fr = new Form1();
                fr.nick = txtkullaniciadi.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre", "" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }

            bgl.baglanti(); 
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
