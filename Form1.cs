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
using Ticari_Otomasyon;

namespace Ticari_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FormELbise fre;
        FormPantolon frp;
        FormKaban frk;
        FormAyakkabı fra;
        FormMüşteriler frm;
        FormFirmalar frf;
        FormPersoneller frmp;
        FormHızlıErişim frr;
        FormGiderler frmg;
        FormBankalar frmb;
        FormFaturalar frmf;
        FormNotlar frmn;
        FormHareketler frmh;
        FormStoklar frms;
        FormAyarlar frma;
        FormKasa frmkk;
        FormAnasayfa frmas;
        public string nick;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frk = new FormKaban();
            if (frk != null)
            {              
                frk.MdiParent = this;
                frk.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frp = new FormPantolon();
            if (frp != null)
            {
                frp.MdiParent = this;
                frp.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fre = new FormELbise();
            if (fre != null)
            {
                fre.MdiParent = this;
                fre.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fra = new FormAyakkabı();
            if (fra != null)
            {
                fra.MdiParent = this;
                fra.Show();
            }
        }

        private void btnmüsteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm = new FormMüşteriler();
            if (frm != null)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnfirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frf = new FormFirmalar();
            if (frf != null)
            {
                frf.MdiParent = this;
                frf.Show();
            }
        }

        private void btnpersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmp = new FormPersoneller();
            if (frmp != null)
            {
                frmp.MdiParent = this;
                frmp.Show();
            }
        }

        private void btnrehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frr = new FormHızlıErişim();
            if (frr != null)
            {
                frr.MdiParent = this;
                frr.Show();
            }
        }

        private void btngiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmg = new FormGiderler();
            if (frmg != null)
            {
                frmg.MdiParent = this;
                frmg.Show();
            }
        }

        private void btnbanka_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmb = new FormBankalar();
            if (frmb != null)
            {
                frmb.MdiParent = this;
                frmb.Show();
            }
        }

        private void btnfaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmf = new FormFaturalar();
            if (frmf != null)
            {
                frmf.MdiParent = this;
                frmf.Show();
            }
        }

        private void btnnotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmn = new FormNotlar();
            if (frmn != null)
            {
                frmn.MdiParent = this;
                frmn.Show();
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmh = new FormHareketler();
            if (frmh != null)
            {
                frmh.MdiParent = this;
                frmh.Show();
            }
        }

        private void btnstoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frms = new FormStoklar();
            if (frms != null)
            {
                frms.MdiParent = this;
                frms.Show();
            }
        }

        private void btnayarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frma = new FormAyarlar();
            if (frma != null)
            {
                frma.Show();
            }
        }

        private void btnkasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmkk = new FormKasa();
            if (frmkk != null)
            {
                frmkk.MdiParent = this;
               frmkk.aktif=nick;
                frmkk.Show();

            }
        }

        private void btnanasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmas = new FormAnasayfa();
            if (frmas != null)
            {
                frmas.MdiParent = this;
                frmas.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmas = new FormAnasayfa();
            if (frmas != null)
            {
                frmas.MdiParent = this;
                frmas.Show();
            }
        }
    }
}
