namespace Ticari_Otomasyon
{
    partial class FormKaban
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btngüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtıd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtmarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtalışfiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtsatışfiyat = new DevExpress.XtraEditors.TextEdit();
            this.nmrcadet = new System.Windows.Forms.NumericUpDown();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.rchtxbdetay = new System.Windows.Forms.RichTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtkategori = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtıd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalışfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsatışfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcadet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 682;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1562;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Location = new System.Drawing.Point(15, 8);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(871, 514);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btnkaydet
            // 
            this.btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Appearance.Options.UseFont = true;
            this.btnkaydet.ImageOptions.SvgImage = global::Ticari_Otomasyon.Properties.Resources.saveall;
            this.btnkaydet.Location = new System.Drawing.Point(7, 393);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(6);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(132, 44);
            this.btnkaydet.TabIndex = 18;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.ImageOptions.Image = global::Ticari_Otomasyon.Properties.Resources.delete_32x32;
            this.btnsil.Location = new System.Drawing.Point(168, 393);
            this.btnsil.Margin = new System.Windows.Forms.Padding(6);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(147, 44);
            this.btnsil.TabIndex = 21;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.Appearance.Options.UseFont = true;
            this.btngüncelle.ImageOptions.Image = global::Ticari_Otomasyon.Properties.Resources.convert_32x32;
            this.btngüncelle.Location = new System.Drawing.Point(345, 393);
            this.btngüncelle.Margin = new System.Windows.Forms.Padding(6);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(132, 44);
            this.btngüncelle.TabIndex = 22;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Appearance.Options.UseFont = true;
            this.btntemizle.ImageOptions.Image = global::Ticari_Otomasyon.Properties.Resources.cleartablestyle_32x32;
            this.btntemizle.Location = new System.Drawing.Point(168, 449);
            this.btntemizle.Margin = new System.Windows.Forms.Padding(6);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(147, 44);
            this.btntemizle.TabIndex = 23;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(113, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 21);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "ID :";
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(168, 5);
            this.txtıd.Margin = new System.Windows.Forms.Padding(6);
            this.txtıd.Name = "txtıd";
            this.txtıd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtıd.Properties.Appearance.Options.UseFont = true;
            this.txtıd.Size = new System.Drawing.Size(147, 28);
            this.txtıd.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(108, 52);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 21);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "AD :";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(168, 45);
            this.txtad.Margin = new System.Windows.Forms.Padding(6);
            this.txtad.Name = "txtad";
            this.txtad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Properties.Appearance.Options.UseFont = true;
            this.txtad.Size = new System.Drawing.Size(147, 28);
            this.txtad.TabIndex = 27;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(75, 92);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 21);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "MARKA :";
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(168, 85);
            this.txtmarka.Margin = new System.Windows.Forms.Padding(6);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmarka.Properties.Appearance.Options.UseFont = true;
            this.txtmarka.Size = new System.Drawing.Size(147, 28);
            this.txtmarka.TabIndex = 29;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(46, 132);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 21);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "ALIŞ FİYAT :";
            // 
            // txtalışfiyat
            // 
            this.txtalışfiyat.Location = new System.Drawing.Point(168, 125);
            this.txtalışfiyat.Margin = new System.Windows.Forms.Padding(6);
            this.txtalışfiyat.Name = "txtalışfiyat";
            this.txtalışfiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtalışfiyat.Properties.Appearance.Options.UseFont = true;
            this.txtalışfiyat.Size = new System.Drawing.Size(147, 28);
            this.txtalışfiyat.TabIndex = 31;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(40, 175);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(102, 21);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "SATIŞ FİYAT:";
            // 
            // txtsatışfiyat
            // 
            this.txtsatışfiyat.Location = new System.Drawing.Point(168, 168);
            this.txtsatışfiyat.Margin = new System.Windows.Forms.Padding(6);
            this.txtsatışfiyat.Name = "txtsatışfiyat";
            this.txtsatışfiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsatışfiyat.Properties.Appearance.Options.UseFont = true;
            this.txtsatışfiyat.Size = new System.Drawing.Size(147, 28);
            this.txtsatışfiyat.TabIndex = 33;
            // 
            // nmrcadet
            // 
            this.nmrcadet.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrcadet.Location = new System.Drawing.Point(168, 248);
            this.nmrcadet.Margin = new System.Windows.Forms.Padding(6);
            this.nmrcadet.Name = "nmrcadet";
            this.nmrcadet.Size = new System.Drawing.Size(147, 28);
            this.nmrcadet.TabIndex = 34;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(88, 255);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(54, 21);
            this.labelControl8.TabIndex = 35;
            this.labelControl8.Text = "ADET :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(78, 291);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 21);
            this.labelControl9.TabIndex = 36;
            this.labelControl9.Text = "DETAY :";
            // 
            // rchtxbdetay
            // 
            this.rchtxbdetay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchtxbdetay.Location = new System.Drawing.Point(168, 288);
            this.rchtxbdetay.Margin = new System.Windows.Forms.Padding(6);
            this.rchtxbdetay.Name = "rchtxbdetay";
            this.rchtxbdetay.Size = new System.Drawing.Size(147, 93);
            this.rchtxbdetay.TabIndex = 37;
            this.rchtxbdetay.Text = "";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(50, 215);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 21);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "KATEGORİ :";
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(168, 208);
            this.txtkategori.Margin = new System.Windows.Forms.Padding(6);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkategori.Properties.Appearance.Options.UseFont = true;
            this.txtkategori.Size = new System.Drawing.Size(147, 28);
            this.txtkategori.TabIndex = 39;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtkategori);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.rchtxbdetay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.nmrcadet);
            this.groupControl1.Controls.Add(this.txtsatışfiyat);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtalışfiyat);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtmarka);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtıd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.btngüncelle);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Location = new System.Drawing.Point(891, 15);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(489, 507);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // FormKaban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 758);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormKaban";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.FormKaban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtıd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalışfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsatışfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcadet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btngüncelle;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtıd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtmarka;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtalışfiyat;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtsatışfiyat;
        private System.Windows.Forms.NumericUpDown nmrcadet;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.RichTextBox rchtxbdetay;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtkategori;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}