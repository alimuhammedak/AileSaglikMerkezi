namespace WinFormUI
{
    partial class frmGiris
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
            this.frmGirisElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmGirisDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.PctrBxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlGiris = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUyariMesaj = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PctrBxClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSfrUntm = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnGiris = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblSifre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblKullanici = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKullanici = new Guna.UI2.WinForms.Guna2TextBox();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxLogo)).BeginInit();
            this.pnlGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // frmGirisDragControl
            // 
            this.frmGirisDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmGirisDragControl.UseTransparentDrag = true;
            // 
            // PnlLogo
            // 
            this.PnlLogo.Controls.Add(this.PctrBxLogo);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(467, 560);
            this.PnlLogo.TabIndex = 0;
            // 
            // PctrBxLogo
            // 
            this.PctrBxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PctrBxLogo.Image = global::WinFormUI.Properties.Resources.ORTALI_LOGO_TÜRKÇE;
            this.PctrBxLogo.ImageRotate = 0F;
            this.PctrBxLogo.Location = new System.Drawing.Point(0, 0);
            this.PctrBxLogo.Name = "PctrBxLogo";
            this.PctrBxLogo.Size = new System.Drawing.Size(467, 560);
            this.PctrBxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxLogo.TabIndex = 0;
            this.PctrBxLogo.TabStop = false;
            // 
            // pnlGiris
            // 
            this.pnlGiris.Controls.Add(this.lblUyariMesaj);
            this.pnlGiris.Controls.Add(this.PctrBxClose);
            this.pnlGiris.Controls.Add(this.btnSfrUntm);
            this.pnlGiris.Controls.Add(this.btnGiris);
            this.pnlGiris.Controls.Add(this.lblSifre);
            this.pnlGiris.Controls.Add(this.lblKullanici);
            this.pnlGiris.Controls.Add(this.txtSifre);
            this.pnlGiris.Controls.Add(this.txtKullanici);
            this.pnlGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGiris.Location = new System.Drawing.Point(467, 0);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(715, 560);
            this.pnlGiris.TabIndex = 1;
            // 
            // lblUyariMesaj
            // 
            this.lblUyariMesaj.BackColor = System.Drawing.Color.Transparent;
            this.lblUyariMesaj.Location = new System.Drawing.Point(309, 136);
            this.lblUyariMesaj.Name = "lblUyariMesaj";
            this.lblUyariMesaj.Size = new System.Drawing.Size(3, 2);
            this.lblUyariMesaj.TabIndex = 7;
            this.lblUyariMesaj.Text = null;
            // 
            // PctrBxClose
            // 
            this.PctrBxClose.Image = global::WinFormUI.Properties.Resources.multiply;
            this.PctrBxClose.ImageRotate = 0F;
            this.PctrBxClose.Location = new System.Drawing.Point(686, 3);
            this.PctrBxClose.Name = "PctrBxClose";
            this.PctrBxClose.Size = new System.Drawing.Size(26, 25);
            this.PctrBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxClose.TabIndex = 6;
            this.PctrBxClose.TabStop = false;
            this.PctrBxClose.Click += new System.EventHandler(this.pctrBxClose_Click);
            // 
            // btnSfrUntm
            // 
            this.btnSfrUntm.Animated = true;
            this.btnSfrUntm.BorderColor = System.Drawing.Color.Transparent;
            this.btnSfrUntm.BorderRadius = 5;
            this.btnSfrUntm.BorderThickness = 1;
            this.btnSfrUntm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSfrUntm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSfrUntm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSfrUntm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSfrUntm.FillColor = System.Drawing.Color.Transparent;
            this.btnSfrUntm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSfrUntm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSfrUntm.Location = new System.Drawing.Point(461, 335);
            this.btnSfrUntm.Name = "btnSfrUntm";
            this.btnSfrUntm.Size = new System.Drawing.Size(117, 33);
            this.btnSfrUntm.TabIndex = 5;
            this.btnSfrUntm.Text = "Şifremi Unuttum";
            this.btnSfrUntm.Click += new System.EventHandler(this.btnSfrUntm_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Animated = true;
            this.btnGiris.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGiris.BorderRadius = 5;
            this.btnGiris.BorderThickness = 1;
            this.btnGiris.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGiris.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGiris.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGiris.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGiris.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGiris.Location = new System.Drawing.Point(139, 374);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(439, 33);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(139, 264);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(27, 17);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre";
            // 
            // lblKullanici
            // 
            this.lblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(139, 190);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(69, 17);
            this.lblKullanici.TabIndex = 2;
            this.lblKullanici.Text = "Kullanıcı Adı";
            // 
            // txtSifre
            // 
            this.txtSifre.BorderRadius = 5;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.DefaultText = "ZXCV5J4K3L2H5";
            this.txtSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSifre.Location = new System.Drawing.Point(139, 287);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '●';
            this.txtSifre.PlaceholderText = "sifre123";
            this.txtSifre.SelectedText = "";
            this.txtSifre.Size = new System.Drawing.Size(439, 30);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullanici
            // 
            this.txtKullanici.BorderRadius = 5;
            this.txtKullanici.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullanici.DefaultText = "selin_koc";
            this.txtKullanici.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKullanici.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKullanici.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKullanici.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKullanici.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKullanici.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKullanici.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKullanici.Location = new System.Drawing.Point(139, 213);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.PasswordChar = '\0';
            this.txtKullanici.PlaceholderText = "aliak123";
            this.txtKullanici.SelectedText = "";
            this.txtKullanici.Size = new System.Drawing.Size(439, 30);
            this.txtKullanici.TabIndex = 0;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 560);
            this.Controls.Add(this.pnlGiris);
            this.Controls.Add(this.PnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiris";
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxLogo)).EndInit();
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmGirisElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmGirisDragControl;
        private Guna.UI2.WinForms.Guna2Panel PnlLogo;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxLogo;
        private Guna.UI2.WinForms.Guna2Panel pnlGiris;
        private Guna.UI2.WinForms.Guna2TextBox txtKullanici;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSifre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblKullanici;
        private Guna.UI2.WinForms.Guna2TileButton btnGiris;
        private Guna.UI2.WinForms.Guna2TileButton btnSfrUntm;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUyariMesaj;
    }
}