namespace WinFormUI.Forms
{
    partial class frmBilgiEkrani
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
            this.components = new System.ComponentModel.Container();
            this.frmBilgiEkraniElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmBilgiEkraniDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PnlHastaBilgi = new Guna.UI2.WinForms.Guna2Panel();
            this.LblEvliMi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblCocukSayisi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaAdresi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaDogumTarihi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaCinsiyet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaSoyadi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaAdi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PctrBoxHasta = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PnlHastaBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBoxHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // frmBilgiEkraniDragControl
            // 
            this.frmBilgiEkraniDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmBilgiEkraniDragControl.UseTransparentDrag = true;
            // 
            // PnlHastaBilgi
            // 
            this.PnlHastaBilgi.Controls.Add(this.LblEvliMi);
            this.PnlHastaBilgi.Controls.Add(this.LblCocukSayisi);
            this.PnlHastaBilgi.Controls.Add(this.LblHastaAdresi);
            this.PnlHastaBilgi.Controls.Add(this.LblHastaDogumTarihi);
            this.PnlHastaBilgi.Controls.Add(this.LblHastaCinsiyet);
            this.PnlHastaBilgi.Controls.Add(this.LblHastaSoyadi);
            this.PnlHastaBilgi.Controls.Add(this.LblHastaAdi);
            this.PnlHastaBilgi.Controls.Add(this.PctrBoxHasta);
            this.PnlHastaBilgi.Location = new System.Drawing.Point(0, 0);
            this.PnlHastaBilgi.Name = "PnlHastaBilgi";
            this.PnlHastaBilgi.Size = new System.Drawing.Size(535, 280);
            this.PnlHastaBilgi.TabIndex = 42;
            // 
            // LblEvliMi
            // 
            this.LblEvliMi.BackColor = System.Drawing.Color.Transparent;
            this.LblEvliMi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEvliMi.Location = new System.Drawing.Point(31, 223);
            this.LblEvliMi.Name = "LblEvliMi";
            this.LblEvliMi.Size = new System.Drawing.Size(12, 17);
            this.LblEvliMi.TabIndex = 58;
            this.LblEvliMi.Text = "...";
            // 
            // LblCocukSayisi
            // 
            this.LblCocukSayisi.BackColor = System.Drawing.Color.Transparent;
            this.LblCocukSayisi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCocukSayisi.Location = new System.Drawing.Point(31, 200);
            this.LblCocukSayisi.Name = "LblCocukSayisi";
            this.LblCocukSayisi.Size = new System.Drawing.Size(12, 17);
            this.LblCocukSayisi.TabIndex = 57;
            this.LblCocukSayisi.Text = "...";
            // 
            // LblHastaAdresi
            // 
            this.LblHastaAdresi.AutoSize = false;
            this.LblHastaAdresi.BackColor = System.Drawing.Color.Transparent;
            this.LblHastaAdresi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaAdresi.Location = new System.Drawing.Point(200, 116);
            this.LblHastaAdresi.Name = "LblHastaAdresi";
            this.LblHastaAdresi.Size = new System.Drawing.Size(231, 48);
            this.LblHastaAdresi.TabIndex = 56;
            this.LblHastaAdresi.Text = "...";
            // 
            // LblHastaDogumTarihi
            // 
            this.LblHastaDogumTarihi.BackColor = System.Drawing.Color.Transparent;
            this.LblHastaDogumTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaDogumTarihi.Location = new System.Drawing.Point(200, 93);
            this.LblHastaDogumTarihi.Name = "LblHastaDogumTarihi";
            this.LblHastaDogumTarihi.Size = new System.Drawing.Size(12, 17);
            this.LblHastaDogumTarihi.TabIndex = 55;
            this.LblHastaDogumTarihi.Text = "...";
            // 
            // LblHastaCinsiyet
            // 
            this.LblHastaCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.LblHastaCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaCinsiyet.Location = new System.Drawing.Point(200, 70);
            this.LblHastaCinsiyet.Name = "LblHastaCinsiyet";
            this.LblHastaCinsiyet.Size = new System.Drawing.Size(12, 17);
            this.LblHastaCinsiyet.TabIndex = 54;
            this.LblHastaCinsiyet.Text = "...";
            // 
            // LblHastaSoyadi
            // 
            this.LblHastaSoyadi.BackColor = System.Drawing.Color.Transparent;
            this.LblHastaSoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaSoyadi.Location = new System.Drawing.Point(200, 47);
            this.LblHastaSoyadi.Name = "LblHastaSoyadi";
            this.LblHastaSoyadi.Size = new System.Drawing.Size(12, 17);
            this.LblHastaSoyadi.TabIndex = 53;
            this.LblHastaSoyadi.Text = "...";
            // 
            // LblHastaAdi
            // 
            this.LblHastaAdi.BackColor = System.Drawing.Color.Transparent;
            this.LblHastaAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaAdi.Location = new System.Drawing.Point(200, 24);
            this.LblHastaAdi.Name = "LblHastaAdi";
            this.LblHastaAdi.Size = new System.Drawing.Size(12, 17);
            this.LblHastaAdi.TabIndex = 52;
            this.LblHastaAdi.Text = "...";
            // 
            // PctrBoxHasta
            // 
            this.PctrBoxHasta.ImageRotate = 0F;
            this.PctrBoxHasta.Location = new System.Drawing.Point(31, 24);
            this.PctrBoxHasta.Name = "PctrBoxHasta";
            this.PctrBoxHasta.Size = new System.Drawing.Size(125, 140);
            this.PctrBoxHasta.TabIndex = 51;
            this.PctrBoxHasta.TabStop = false;
            // 
            // frmBilgiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 606);
            this.Controls.Add(this.PnlHastaBilgi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBilgiEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBilgiEkrani";
            this.PnlHastaBilgi.ResumeLayout(false);
            this.PnlHastaBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBoxHasta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmBilgiEkraniElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmBilgiEkraniDragControl;
        private Guna.UI2.WinForms.Guna2Panel PnlHastaBilgi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblEvliMi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCocukSayisi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaAdresi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaDogumTarihi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaCinsiyet;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaSoyadi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaAdi;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBoxHasta;
    }
}