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
            this.PnlGiris = new Guna.UI2.WinForms.Guna2Panel();
            this.PctrBxClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnSfrUntm = new Guna.UI2.WinForms.Guna2TileButton();
            this.BtnGiris = new Guna.UI2.WinForms.Guna2TileButton();

            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlGiris = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSifreSifirlama = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnGiris = new Guna.UI2.WinForms.Guna2TileButton();

            this.LblSifre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblKullanici = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKullaniciAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUyariMesaj = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PnlLogo.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.PctrBxLogo)).BeginInit();
            this.PnlGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlGiris.SuspendLayout();

            this.SuspendLayout();
            // 
            // frmGirisDragControl
            // 
            this.frmGirisDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmGirisDragControl.UseTransparentDrag = true;
            // 
            // PnlLogo
            // 
            this.PnlLogo.Controls.Add(this.pbLogo);
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
            // PnlGiris
            // 
            this.PnlGiris.Controls.Add(this.PctrBxClose);
            this.PnlGiris.Controls.Add(this.BtnSfrUntm);
            this.PnlGiris.Controls.Add(this.BtnGiris);
            this.PnlGiris.Controls.Add(this.LblSifre);
            this.PnlGiris.Controls.Add(this.LblKullanici);
            this.PnlGiris.Controls.Add(this.TxtBxSifre);
            this.PnlGiris.Controls.Add(this.TxtBxKullanici);
            this.PnlGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGiris.Location = new System.Drawing.Point(467, 0);
            this.PnlGiris.Name = "PnlGiris";
            this.PnlGiris.Size = new System.Drawing.Size(715, 560);
            this.PnlGiris.TabIndex = 1;
            // 
            // PctrBxClose
            // 
            this.PctrBxClose.Image = global::WinFormUI.Properties.Resources.Multiply;
            this.PctrBxClose.ImageRotate = 0F;
            this.PctrBxClose.Location = new System.Drawing.Point(667, 3);
            this.PctrBxClose.Name = "PctrBxClose";
            this.PctrBxClose.Size = new System.Drawing.Size(45, 45);
            this.PctrBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxClose.TabIndex = 6;
            this.PctrBxClose.TabStop = false;
            this.PctrBxClose.Click += new System.EventHandler(this.PctrBxClose_Click);
            // 
            // BtnSfrUntm
            // 
            this.BtnSfrUntm.Animated = true;
            this.BtnSfrUntm.BorderColor = System.Drawing.Color.Transparent;
            this.BtnSfrUntm.BorderRadius = 5;
            this.BtnSfrUntm.BorderThickness = 1;
            this.BtnSfrUntm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSfrUntm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSfrUntm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSfrUntm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSfrUntm.FillColor = System.Drawing.Color.Transparent;
            this.BtnSfrUntm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnSfrUntm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSfrUntm.Location = new System.Drawing.Point(461, 335);
            this.BtnSfrUntm.Name = "BtnSfrUntm";
            this.BtnSfrUntm.Size = new System.Drawing.Size(117, 33);
            this.BtnSfrUntm.TabIndex = 5;
            this.BtnSfrUntm.Text = "Şifremi Unuttum";
            // 
            // BtnGiris
            // 
            this.BtnGiris.Animated = true;
            this.BtnGiris.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGiris.BorderRadius = 5;
            this.BtnGiris.BorderThickness = 1;
            this.BtnGiris.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnGiris.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnGiris.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnGiris.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnGiris.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnGiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGiris.Location = new System.Drawing.Point(139, 374);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(439, 33);
            this.BtnGiris.TabIndex = 4;
            this.BtnGiris.Text = "Giriş";

            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = global::WinFormUI.Properties.Resources.ORTALI_LOGO_TÜRKÇE;
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(467, 560);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlGiris
            // 
            this.pnlGiris.Controls.Add(this.lblUyariMesaj);
            this.pnlGiris.Controls.Add(this.btnSifreSifirlama);
            this.pnlGiris.Controls.Add(this.btnGiris);
            this.pnlGiris.Controls.Add(this.LblSifre);
            this.pnlGiris.Controls.Add(this.LblKullanici);
            this.pnlGiris.Controls.Add(this.txtSifre);
            this.pnlGiris.Controls.Add(this.txtKullaniciAdi);
            this.pnlGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGiris.Location = new System.Drawing.Point(467, 0);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(715, 560);
            this.pnlGiris.TabIndex = 1;
            // 
            // btnSifreSifirlama
            // 
            this.btnSifreSifirlama.Animated = true;
            this.btnSifreSifirlama.BorderColor = System.Drawing.Color.Transparent;
            this.btnSifreSifirlama.BorderRadius = 5;
            this.btnSifreSifirlama.BorderThickness = 1;
            this.btnSifreSifirlama.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSifreSifirlama.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSifreSifirlama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSifreSifirlama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSifreSifirlama.FillColor = System.Drawing.Color.Transparent;
            this.btnSifreSifirlama.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSifreSifirlama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSifreSifirlama.Location = new System.Drawing.Point(461, 335);
            this.btnSifreSifirlama.Name = "btnSifreSifirlama";
            this.btnSifreSifirlama.Size = new System.Drawing.Size(117, 33);
            this.btnSifreSifirlama.TabIndex = 5;
            this.btnSifreSifirlama.Text = "Şifremi Unuttum";
            this.btnSifreSifirlama.Click += new System.EventHandler(this.btnSifreSifirlama_Click);
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
            // LblSifre
            // 
            this.LblSifre.BackColor = System.Drawing.Color.Transparent;
            this.LblSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.Location = new System.Drawing.Point(139, 264);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(27, 17);
            this.LblSifre.TabIndex = 3;
            this.LblSifre.Text = "Şifre";
            // 
            // LblKullanici
            // 
            this.LblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.LblKullanici.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullanici.Location = new System.Drawing.Point(139, 190);
            this.LblKullanici.Name = "LblKullanici";
            this.LblKullanici.Size = new System.Drawing.Size(69, 17);
            this.LblKullanici.TabIndex = 2;
            this.LblKullanici.Text = "Kullanıcı Adı";
            // 
            // txtSifre
            // 
            this.txtSifre.BorderRadius = 5;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.DefaultText = "";
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
            this.txtSifre.PlaceholderText = "";
            this.txtSifre.SelectedText = "";
            this.txtSifre.Size = new System.Drawing.Size(439, 30);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BorderRadius = 5;
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.DefaultText = "";
            this.txtKullaniciAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKullaniciAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKullaniciAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKullaniciAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKullaniciAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKullaniciAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(139, 213);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.PlaceholderText = "";
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(439, 30);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // lblUyariMesaj
            // 
            this.lblUyariMesaj.BackColor = System.Drawing.Color.Transparent;
            this.lblUyariMesaj.Location = new System.Drawing.Point(350, 128);
            this.lblUyariMesaj.Name = "lblUyariMesaj";
            this.lblUyariMesaj.Size = new System.Drawing.Size(31, 15);
            this.lblUyariMesaj.TabIndex = 6;
            this.lblUyariMesaj.Text = "Mesaj";
            this.lblUyariMesaj.Visible = false;
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
            this.PnlGiris.ResumeLayout(false);
            this.PnlGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();

            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmGirisElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmGirisDragControl;
        private Guna.UI2.WinForms.Guna2Panel PnlLogo;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2Panel pnlGiris;
        private Guna.UI2.WinForms.Guna2TextBox txtKullaniciAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblSifre;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblKullanici;

        private Guna.UI2.WinForms.Guna2TileButton BtnGiris;
        private Guna.UI2.WinForms.Guna2TileButton BtnSfrUntm;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxClose;

        private Guna.UI2.WinForms.Guna2TileButton btnGiris;
        private Guna.UI2.WinForms.Guna2TileButton btnSifreSifirlama;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUyariMesaj;

    }
}