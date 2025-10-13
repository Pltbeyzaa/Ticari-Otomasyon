namespace Ticari_Otomasyon
{
    partial class FormHızlıErişim
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
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtratabpage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtratabpage = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtratabpage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtratabpage)).BeginInit();
            this.xtratabpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.ImageOptions.Image = global::Ticari_Otomasyon.Properties.Resources.firma1_32;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1380, 712);
            this.xtraTabPage2.Text = "Firmalar";
            // 
            // gridControl2
            // 
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl2.Location = new System.Drawing.Point(8, 8);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1380, 728);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.DetailHeight = 444;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 937;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            // 
            // xtratabpage1
            // 
            this.xtratabpage1.Controls.Add(this.gridControl1);
            this.xtratabpage1.ImageOptions.Image = global::Ticari_Otomasyon.Properties.Resources.müşterş_32;
            this.xtratabpage1.Name = "xtratabpage1";
            this.xtratabpage1.Size = new System.Drawing.Size(1380, 712);
            this.xtratabpage1.Text = "Müşteriler";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView3;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1380, 712);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.DetailHeight = 444;
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsEditForm.PopupEditFormWidth = 937;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // xtratabpage
            // 
            this.xtratabpage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtratabpage.Location = new System.Drawing.Point(0, 0);
            this.xtratabpage.Name = "xtratabpage";
            this.xtratabpage.SelectedTabPage = this.xtratabpage1;
            this.xtratabpage.Size = new System.Drawing.Size(1382, 758);
            this.xtratabpage.TabIndex = 0;
            this.xtratabpage.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtratabpage1,
            this.xtraTabPage2});
            // 
            // FormHızlıErişim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 758);
            this.Controls.Add(this.xtratabpage);
            this.Name = "FormHızlıErişim";
            this.Text = "FormRehber";
            this.Load += new System.EventHandler(this.FormHızlıErişim_Load);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtratabpage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtratabpage)).EndInit();
            this.xtratabpage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtratabpage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraTab.XtraTabControl xtratabpage;
    }
}