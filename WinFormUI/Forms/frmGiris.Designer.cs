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
            this.BtnSfrUntm = new Guna.UI2.WinForms.Guna2TileButton();
            this.BtnGiris = new Guna.UI2.WinForms.Guna2TileButton();
            this.LblSifre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblKullanici = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtBxSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtBxKullanici = new Guna.UI2.WinForms.Guna2TextBox();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxLogo)).BeginInit();
            this.PnlGiris.SuspendLayout();
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
            // PnlGiris
            // 
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
            // 
            // LblSifre
            // 
            this.LblSifre.BackColor = System.Drawing.Color.Transparent;
            this.LblSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.Location = new System.Drawing.Point(139, 264);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(30, 17);
            this.LblSifre.TabIndex = 3;
            this.LblSifre.Text = "Şifre";
            // 
            // LblKullanici
            // 
            this.LblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.LblKullanici.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullanici.Location = new System.Drawing.Point(139, 190);
            this.LblKullanici.Name = "LblKullanici";
            this.LblKullanici.Size = new System.Drawing.Size(70, 17);
            this.LblKullanici.TabIndex = 2;
            this.LblKullanici.Text = "Kullanıcı Adı";
            // 
            // TxtBxSifre
            // 
            this.TxtBxSifre.BorderRadius = 5;
            this.TxtBxSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBxSifre.DefaultText = "";
            this.TxtBxSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBxSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBxSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBxSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxSifre.Location = new System.Drawing.Point(139, 287);
            this.TxtBxSifre.Name = "TxtBxSifre";
            this.TxtBxSifre.PasswordChar = '●';
            this.TxtBxSifre.PlaceholderText = "";
            this.TxtBxSifre.SelectedText = "";
            this.TxtBxSifre.Size = new System.Drawing.Size(439, 30);
            this.TxtBxSifre.TabIndex = 1;
            this.TxtBxSifre.UseSystemPasswordChar = true;
            // 
            // TxtBxKullanici
            // 
            this.TxtBxKullanici.BorderRadius = 5;
            this.TxtBxKullanici.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBxKullanici.DefaultText = "";
            this.TxtBxKullanici.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBxKullanici.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBxKullanici.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxKullanici.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxKullanici.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxKullanici.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBxKullanici.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxKullanici.Location = new System.Drawing.Point(139, 213);
            this.TxtBxKullanici.Name = "TxtBxKullanici";
            this.TxtBxKullanici.PasswordChar = '\0';
            this.TxtBxKullanici.PlaceholderText = "";
            this.TxtBxKullanici.SelectedText = "";
            this.TxtBxKullanici.Size = new System.Drawing.Size(439, 30);
            this.TxtBxKullanici.TabIndex = 0;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 560);
            this.Controls.Add(this.PnlGiris);
            this.Controls.Add(this.PnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiris";
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxLogo)).EndInit();
            this.PnlGiris.ResumeLayout(false);
            this.PnlGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmGirisElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmGirisDragControl;
        private Guna.UI2.WinForms.Guna2Panel PnlLogo;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxLogo;
        private Guna.UI2.WinForms.Guna2Panel PnlGiris;
        private Guna.UI2.WinForms.Guna2TextBox TxtBxKullanici;
        private Guna.UI2.WinForms.Guna2TextBox TxtBxSifre;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblSifre;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblKullanici;
        private Guna.UI2.WinForms.Guna2TileButton BtnGiris;
        private Guna.UI2.WinForms.Guna2TileButton BtnSfrUntm;
    }
}