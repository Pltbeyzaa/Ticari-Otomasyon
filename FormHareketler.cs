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
    public partial class FormHareketler : Form
    {
        public FormHareketler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        Formmüşterikaban frmkaban;
        FormMüşteriElbise frmelbise;
        FormmüşteriPantolon frmpantolon;
        Formmüşteriayakkabı frmayakkabı;
        Formfirmakaban frmfkaban;
        FormfirmaElbise frmfelbise;
        FormfirmaPantolon frmfpantolon;
        Formfirmaayakkabı frmfayakkabı;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmkaban = new Formmüşterikaban();
            frmkaban.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmelbise = new FormMüşteriElbise();
            frmelbise.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmpantolon = new FormmüşteriPantolon();
            frmpantolon.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmayakkabı = new Formmüşteriayakkabı();
            frmayakkabı.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            frmfkaban = new Formfirmakaban();
            frmfkaban.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmfelbise = new FormfirmaElbise();
            frmfelbise.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmfpantolon = new FormfirmaPantolon();
            frmfpantolon.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmfayakkabı = new Formfirmaayakkabı();
            frmfayakkabı.Show();
        }
    }
}
