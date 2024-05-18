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
            this.PnlSifreSifirlama = new Guna.UI2.WinForms.Guna2Panel();
            this.LblSifreSifirla = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblTcNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHatirladim = new Guna.UI2.WinForms.Guna2TileButton();
            this.BtnSifreSifirlama = new Guna.UI2.WinForms.Guna2TileButton();
            this.txtSifreTekrar = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblAdi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PctrBxAciklamaResim = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PctrBxClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.frmSifreGirmeElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmSifreGirmeDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PnlSifreSifirlama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxAciklamaResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSifreSifirlama
            // 
            this.PnlSifreSifirlama.Controls.Add(this.LblSifreSifirla);
            this.PnlSifreSifirlama.Controls.Add(this.LblTcNo);
            this.PnlSifreSifirlama.Controls.Add(this.txtSifre);
            this.PnlSifreSifirlama.Controls.Add(this.btnHatirladim);
            this.PnlSifreSifirlama.Controls.Add(this.BtnSifreSifirlama);
            this.PnlSifreSifirlama.Controls.Add(this.txtSifreTekrar);
            this.PnlSifreSifirlama.Controls.Add(this.LblAdi);
            this.PnlSifreSifirlama.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSifreSifirlama.Location = new System.Drawing.Point(0, 0);
            this.PnlSifreSifirlama.Name = "PnlSifreSifirlama";
            this.PnlSifreSifirlama.Size = new System.Drawing.Size(709, 560);
            this.PnlSifreSifirlama.TabIndex = 1;
            // 
            // LblSifreSifirla
            // 
            this.LblSifreSifirla.BackColor = System.Drawing.Color.Transparent;
            this.LblSifreSifirla.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblSifreSifirla.Location = new System.Drawing.Point(269, 99);
            this.LblSifreSifirla.Name = "LblSifreSifirla";
            this.LblSifreSifirla.Size = new System.Drawing.Size(172, 23);
            this.LblSifreSifirla.TabIndex = 21;
            this.LblSifreSifirla.Text = "Yeni Şifre Giriniz Lütfen";
            // 
            // LblTcNo
            // 
            this.LblTcNo.BackColor = System.Drawing.Color.Transparent;
            this.LblTcNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LblTcNo.Location = new System.Drawing.Point(132, 211);
            this.LblTcNo.Name = "LblTcNo";
            this.LblTcNo.Size = new System.Drawing.Size(27, 17);
            this.LblTcNo.TabIndex = 18;
            this.LblTcNo.Text = "Şifre";
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
            this.txtSifre.Location = new System.Drawing.Point(132, 234);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '\0';
            this.txtSifre.PlaceholderText = "";
            this.txtSifre.SelectedText = "";
            this.txtSifre.Size = new System.Drawing.Size(439, 30);
            this.txtSifre.TabIndex = 2;
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
            this.btnHatirladim.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnHatirladim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHatirladim.Location = new System.Drawing.Point(132, 440);
            this.btnHatirladim.Name = "btnHatirladim";
            this.btnHatirladim.Size = new System.Drawing.Size(196, 33);
            this.btnHatirladim.TabIndex = 4;
            this.btnHatirladim.Text = "<- Hatırladım";
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
            this.BtnSifreSifirlama.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnSifreSifirlama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSifreSifirlama.Location = new System.Drawing.Point(375, 440);
            this.BtnSifreSifirlama.Name = "BtnSifreSifirlama";
            this.BtnSifreSifirlama.Size = new System.Drawing.Size(196, 33);
            this.BtnSifreSifirlama.TabIndex = 5;
            this.BtnSifreSifirlama.Text = "Şifre Kaydet";
            this.BtnSifreSifirlama.Click += new System.EventHandler(this.BtnSifreSifirlama_Click);
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
            this.txtSifreTekrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSifreTekrar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSifreTekrar.Location = new System.Drawing.Point(132, 303);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '\0';
            this.txtSifreTekrar.PlaceholderText = "";
            this.txtSifreTekrar.SelectedText = "";
            this.txtSifreTekrar.Size = new System.Drawing.Size(439, 30);
            this.txtSifreTekrar.TabIndex = 3;
            // 
            // LblAdi
            // 
            this.LblAdi.BackColor = System.Drawing.Color.Transparent;
            this.LblAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LblAdi.Location = new System.Drawing.Point(132, 280);
            this.LblAdi.Name = "LblAdi";
            this.LblAdi.Size = new System.Drawing.Size(63, 17);
            this.LblAdi.TabIndex = 9;
            this.LblAdi.Text = "Şifre Tekrar";
            // 
            // PctrBxAciklamaResim
            // 
            this.PctrBxAciklamaResim.Image = global::WinFormUI.Properties.Resources.ORTALI_LOGO_TÜRKÇE;
            this.PctrBxAciklamaResim.ImageRotate = 0F;
            this.PctrBxAciklamaResim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PctrBxAciklamaResim.Location = new System.Drawing.Point(715, 0);
            this.PctrBxAciklamaResim.Name = "PctrBxAciklamaResim";
            this.PctrBxAciklamaResim.Size = new System.Drawing.Size(467, 560);
            this.PctrBxAciklamaResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxAciklamaResim.TabIndex = 2;
            this.PctrBxAciklamaResim.TabStop = false;
            // 
            // PctrBxClose
            // 
            this.PctrBxClose.Image = global::WinFormUI.Properties.Resources.multiply;
            this.PctrBxClose.ImageRotate = 0F;
            this.PctrBxClose.Location = new System.Drawing.Point(1145, 12);
            this.PctrBxClose.Name = "PctrBxClose";
            this.PctrBxClose.Size = new System.Drawing.Size(25, 25);
            this.PctrBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxClose.TabIndex = 25;
            this.PctrBxClose.TabStop = false;
            this.PctrBxClose.Click += new System.EventHandler(this.PctrBxClose_Click);
            // 
            // frmSifreGirmeDragControl
            // 
            this.frmSifreGirmeDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmSifreGirmeDragControl.UseTransparentDrag = true;
            // 
            // frmSifreGirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 560);
            this.Controls.Add(this.PctrBxClose);
            this.Controls.Add(this.PctrBxAciklamaResim);
            this.Controls.Add(this.PnlSifreSifirlama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSifreGirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSifreGirme";
            this.PnlSifreSifirlama.ResumeLayout(false);
            this.PnlSifreSifirlama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxAciklamaResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnlSifreSifirlama;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblSifreSifirla;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTcNo;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
        private Guna.UI2.WinForms.Guna2TileButton btnHatirladim;
        private Guna.UI2.WinForms.Guna2TileButton BtnSifreSifirlama;
        private Guna.UI2.WinForms.Guna2TextBox txtSifreTekrar;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblAdi;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxAciklamaResim;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxClose;
        private Guna.UI2.WinForms.Guna2Elipse frmSifreGirmeElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmSifreGirmeDragControl;
    }
}