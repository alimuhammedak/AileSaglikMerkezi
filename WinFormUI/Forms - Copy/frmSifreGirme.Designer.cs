namespace WinFormUI.Forms
{
    partial class frmSifreGirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreGirme));
            this.frmSifreSifirlamaElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmSifreSifirlamaDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PnlSifreSifirlama = new Guna.UI2.WinForms.Guna2Panel();
            this.LblSifreSifirlama = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblTcNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHatirladim = new Guna.UI2.WinForms.Guna2TileButton();
            this.BtnSifreSifirlama = new Guna.UI2.WinForms.Guna2TileButton();
            this.txtSifreTekrar = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblAdi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PnlAciklama = new Guna.UI2.WinForms.Guna2Panel();
            this.PctrBxClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PctrBxAciklamaResim = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PnlSifreSifirlama.SuspendLayout();
            this.PnlAciklama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxAciklamaResim)).BeginInit();
            this.SuspendLayout();
            // 
            // frmSifreSifirlamaDragControl
            // 
            this.frmSifreSifirlamaDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmSifreSifirlamaDragControl.UseTransparentDrag = true;
            // 
            // PnlSifreSifirlama
            // 
            this.PnlSifreSifirlama.Controls.Add(this.LblSifreSifirlama);
            this.PnlSifreSifirlama.Controls.Add(this.LblTcNo);
            this.PnlSifreSifirlama.Controls.Add(this.txtSifre);
            this.PnlSifreSifirlama.Controls.Add(this.btnHatirladim);
            this.PnlSifreSifirlama.Controls.Add(this.BtnSifreSifirlama);
            this.PnlSifreSifirlama.Controls.Add(this.txtSifreTekrar);
            this.PnlSifreSifirlama.Controls.Add(this.LblAdi);
            resources.ApplyResources(this.PnlSifreSifirlama, "PnlSifreSifirlama");
            this.PnlSifreSifirlama.Name = "PnlSifreSifirlama";
            // 
            // LblSifreSifirlama
            // 
            this.LblSifreSifirlama.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LblSifreSifirlama, "LblSifreSifirlama");
            this.LblSifreSifirlama.Name = "LblSifreSifirlama";
            // 
            // LblTcNo
            // 
            this.LblTcNo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LblTcNo, "LblTcNo");
            this.LblTcNo.Name = "LblTcNo";
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
            resources.ApplyResources(this.txtSifre, "txtSifre");
            this.txtSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '\0';
            this.txtSifre.PlaceholderText = "";
            this.txtSifre.SelectedText = "";
            // 
            // btnHatirladim
            // 
            this.btnHatirladim.Animated = true;
            this.btnHatirladim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHatirladim.BorderRadius = 5;
            this.btnHatirladim.BorderThickness = 1;
            this.btnHatirladim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHatirladim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHatirladim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHatirladim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHatirladim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btnHatirladim, "btnHatirladim");
            this.btnHatirladim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHatirladim.Name = "btnHatirladim";
            this.btnHatirladim.Click += new System.EventHandler(this.btnHatirladim_Click);
            // 
            // BtnSifreSifirlama
            // 
            this.BtnSifreSifirlama.Animated = true;
            this.BtnSifreSifirlama.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSifreSifirlama.BorderRadius = 5;
            this.BtnSifreSifirlama.BorderThickness = 1;
            this.BtnSifreSifirlama.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSifreSifirlama.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSifreSifirlama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSifreSifirlama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSifreSifirlama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.BtnSifreSifirlama, "BtnSifreSifirlama");
            this.BtnSifreSifirlama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSifreSifirlama.Name = "BtnSifreSifirlama";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.BorderRadius = 5;
            this.txtSifreTekrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifreTekrar.DefaultText = "";
            this.txtSifreTekrar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSifreTekrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSifreTekrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSifreTekrar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSifreTekrar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtSifreTekrar, "txtSifreTekrar");
            this.txtSifreTekrar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '\0';
            this.txtSifreTekrar.PlaceholderText = "";
            this.txtSifreTekrar.SelectedText = "";
            // 
            // LblAdi
            // 
            this.LblAdi.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LblAdi, "LblAdi");
            this.LblAdi.Name = "LblAdi";
            // 
            // PnlAciklama
            // 
            this.PnlAciklama.Controls.Add(this.PctrBxClose);
            this.PnlAciklama.Controls.Add(this.PctrBxAciklamaResim);
            resources.ApplyResources(this.PnlAciklama, "PnlAciklama");
            this.PnlAciklama.Name = "PnlAciklama";
            // 
            // PctrBxClose
            // 
            this.PctrBxClose.Image = global::WinFormUI.Properties.Resources.multiply;
            this.PctrBxClose.ImageRotate = 0F;
            resources.ApplyResources(this.PctrBxClose, "PctrBxClose");
            this.PctrBxClose.Name = "PctrBxClose";
            this.PctrBxClose.TabStop = false;
            this.PctrBxClose.Click += new System.EventHandler(this.PctrBxClose_Click);
            // 
            // PctrBxAciklamaResim
            // 
            this.PctrBxAciklamaResim.Image = global::WinFormUI.Properties.Resources.ORTALI_LOGO_TÜRKÇE;
            this.PctrBxAciklamaResim.ImageRotate = 0F;
            resources.ApplyResources(this.PctrBxAciklamaResim, "PctrBxAciklamaResim");
            this.PctrBxAciklamaResim.Name = "PctrBxAciklamaResim";
            this.PctrBxAciklamaResim.TabStop = false;
            // 
            // frmSifreGirme
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlAciklama);
            this.Controls.Add(this.PnlSifreSifirlama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSifreGirme";
            this.PnlSifreSifirlama.ResumeLayout(false);
            this.PnlSifreSifirlama.PerformLayout();
            this.PnlAciklama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxAciklamaResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse frmSifreSifirlamaElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmSifreSifirlamaDragControl;
        private Guna.UI2.WinForms.Guna2Panel PnlSifreSifirlama;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtSifreTekrar;
        private Guna.UI2.WinForms.Guna2TileButton BtnSifreSifirlama;
        private Guna.UI2.WinForms.Guna2TileButton btnHatirladim;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTcNo;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblSifreSifirlama;
        private Guna.UI2.WinForms.Guna2Panel PnlAciklama;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxAciklamaResim;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxClose;
    }
}