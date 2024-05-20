using System.Windows.Forms;

namespace WinFormUI.Forms
{
    partial class frmSifreSifirlama
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
            this.dtSfDogumTarih = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.LblSifreSifirlama = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtBxSoyadi = new Guna.UI2.WinForms.Guna2TextBox();
            this.LbSoyadi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblTcNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtBxTcNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHatirladim = new Guna.UI2.WinForms.Guna2TileButton();
            this.BtnSifreSifirlama = new Guna.UI2.WinForms.Guna2TileButton();
            this.TxtBxAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblDogumTarihi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblAdi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PctrBxAciklamaResim = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PctrBxClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.frmSifreSifirlaElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmSifreSifirlaDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PnlSifreSifirlama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxAciklamaResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSifreSifirlama
            // 
            this.PnlSifreSifirlama.Controls.Add(this.dtSfDogumTarih);
            this.PnlSifreSifirlama.Controls.Add(this.LblSifreSifirlama);
            this.PnlSifreSifirlama.Controls.Add(this.TxtBxSoyadi);
            this.PnlSifreSifirlama.Controls.Add(this.LbSoyadi);
            this.PnlSifreSifirlama.Controls.Add(this.LblTcNo);
            this.PnlSifreSifirlama.Controls.Add(this.TxtBxTcNo);
            this.PnlSifreSifirlama.Controls.Add(this.btnHatirladim);
            this.PnlSifreSifirlama.Controls.Add(this.BtnSifreSifirlama);
            this.PnlSifreSifirlama.Controls.Add(this.TxtBxAdi);
            this.PnlSifreSifirlama.Controls.Add(this.LblDogumTarihi);
            this.PnlSifreSifirlama.Controls.Add(this.LblAdi);
            this.PnlSifreSifirlama.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSifreSifirlama.Location = new System.Drawing.Point(0, 0);
            this.PnlSifreSifirlama.Name = "PnlSifreSifirlama";
            this.PnlSifreSifirlama.Size = new System.Drawing.Size(709, 560);
            this.PnlSifreSifirlama.TabIndex = 1;
            // 
            // dtSfDogumTarih
            // 
            this.dtSfDogumTarih.BackColor = System.Drawing.Color.White;
            this.dtSfDogumTarih.Checked = true;
            this.dtSfDogumTarih.CustomFormat = "yyyy-MM-dd";
            this.dtSfDogumTarih.FillColor = System.Drawing.Color.White;
            this.dtSfDogumTarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtSfDogumTarih.ForeColor = System.Drawing.Color.Black;
            this.dtSfDogumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSfDogumTarih.Location = new System.Drawing.Point(132, 382);
            this.dtSfDogumTarih.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtSfDogumTarih.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtSfDogumTarih.Name = "dtSfDogumTarih";
            this.dtSfDogumTarih.Size = new System.Drawing.Size(439, 26);
            this.dtSfDogumTarih.TabIndex = 5;
            this.dtSfDogumTarih.Value = new System.DateTime(1982, 2, 1, 0, 0, 0, 0);
            // 
            // LblSifreSifirlama
            // 
            this.LblSifreSifirlama.BackColor = System.Drawing.Color.Transparent;
            this.LblSifreSifirlama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblSifreSifirlama.Location = new System.Drawing.Point(269, 99);
            this.LblSifreSifirlama.Name = "LblSifreSifirlama";
            this.LblSifreSifirlama.Size = new System.Drawing.Size(155, 23);
            this.LblSifreSifirlama.TabIndex = 21;
            this.LblSifreSifirlama.Text = "Şifre Sıfırlama Formu";
            // 
            // TxtBxSoyadi
            // 
            this.TxtBxSoyadi.BorderRadius = 5;
            this.TxtBxSoyadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBxSoyadi.DefaultText = "Öztürk";
            this.TxtBxSoyadi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBxSoyadi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBxSoyadi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxSoyadi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxSoyadi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxSoyadi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBxSoyadi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxSoyadi.Location = new System.Drawing.Point(132, 313);
            this.TxtBxSoyadi.Name = "TxtBxSoyadi";
            this.TxtBxSoyadi.PasswordChar = '\0';
            this.TxtBxSoyadi.PlaceholderText = "";
            this.TxtBxSoyadi.SelectedText = "";
            this.TxtBxSoyadi.Size = new System.Drawing.Size(439, 30);
            this.TxtBxSoyadi.TabIndex = 4;
            // 
            // LbSoyadi
            // 
            this.LbSoyadi.BackColor = System.Drawing.Color.Transparent;
            this.LbSoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LbSoyadi.Location = new System.Drawing.Point(132, 290);
            this.LbSoyadi.Name = "LbSoyadi";
            this.LbSoyadi.Size = new System.Drawing.Size(36, 17);
            this.LbSoyadi.TabIndex = 19;
            this.LbSoyadi.Text = "Soyad";
            // 
            // LblTcNo
            // 
            this.LblTcNo.BackColor = System.Drawing.Color.Transparent;
            this.LblTcNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LblTcNo.Location = new System.Drawing.Point(132, 153);
            this.LblTcNo.Name = "LblTcNo";
            this.LblTcNo.Size = new System.Drawing.Size(107, 17);
            this.LblTcNo.TabIndex = 18;
            this.LblTcNo.Text = "TC Kimlik Numarası";
            // 
            // TxtBxTcNo
            // 
            this.TxtBxTcNo.BorderRadius = 5;
            this.TxtBxTcNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBxTcNo.DefaultText = "29119978663";
            this.TxtBxTcNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBxTcNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBxTcNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxTcNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxTcNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxTcNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBxTcNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxTcNo.Location = new System.Drawing.Point(132, 176);
            this.TxtBxTcNo.Name = "TxtBxTcNo";
            this.TxtBxTcNo.PasswordChar = '\0';
            this.TxtBxTcNo.PlaceholderText = "";
            this.TxtBxTcNo.SelectedText = "";
            this.TxtBxTcNo.Size = new System.Drawing.Size(439, 30);
            this.TxtBxTcNo.TabIndex = 2;
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
            this.btnHatirladim.TabIndex = 6;
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
            this.BtnSifreSifirlama.TabIndex = 7;
            this.BtnSifreSifirlama.Text = "Şifre Sıfırla";
            this.BtnSifreSifirlama.Click += new System.EventHandler(this.BtnSifreSifirlama_Click);
            // 
            // TxtBxAdi
            // 
            this.TxtBxAdi.BorderRadius = 5;
            this.TxtBxAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBxAdi.DefaultText = "Fatma";
            this.TxtBxAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBxAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBxAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBxAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxAdi.Location = new System.Drawing.Point(132, 245);
            this.TxtBxAdi.Name = "TxtBxAdi";
            this.TxtBxAdi.PasswordChar = '\0';
            this.TxtBxAdi.PlaceholderText = "";
            this.TxtBxAdi.SelectedText = "";
            this.TxtBxAdi.Size = new System.Drawing.Size(439, 30);
            this.TxtBxAdi.TabIndex = 3;
            // 
            // LblDogumTarihi
            // 
            this.LblDogumTarihi.BackColor = System.Drawing.Color.Transparent;
            this.LblDogumTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LblDogumTarihi.Location = new System.Drawing.Point(132, 359);
            this.LblDogumTarihi.Name = "LblDogumTarihi";
            this.LblDogumTarihi.Size = new System.Drawing.Size(77, 17);
            this.LblDogumTarihi.TabIndex = 10;
            this.LblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // LblAdi
            // 
            this.LblAdi.BackColor = System.Drawing.Color.Transparent;
            this.LblAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LblAdi.Location = new System.Drawing.Point(132, 222);
            this.LblAdi.Name = "LblAdi";
            this.LblAdi.Size = new System.Drawing.Size(18, 17);
            this.LblAdi.TabIndex = 9;
            this.LblAdi.Text = "Ad";
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
            this.PctrBxClose.TabIndex = 26;
            this.PctrBxClose.TabStop = false;
            this.PctrBxClose.Click += new System.EventHandler(this.PctrBxClose_Click);
            // 
            // frmSifreSifirlaDragControl
            // 
            this.frmSifreSifirlaDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmSifreSifirlaDragControl.UseTransparentDrag = true;
            // 
            // frmSifreSifirlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 560);
            this.Controls.Add(this.PctrBxClose);
            this.Controls.Add(this.PctrBxAciklamaResim);
            this.Controls.Add(this.PnlSifreSifirlama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSifreSifirlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSifreSifirlama";
            this.PnlSifreSifirlama.ResumeLayout(false);
            this.PnlSifreSifirlama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxAciklamaResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnlSifreSifirlama;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtSfDogumTarih;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblSifreSifirlama;
        private Guna.UI2.WinForms.Guna2TextBox TxtBxSoyadi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbSoyadi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTcNo;
        private Guna.UI2.WinForms.Guna2TextBox TxtBxTcNo;
        private Guna.UI2.WinForms.Guna2TileButton btnHatirladim;
        private Guna.UI2.WinForms.Guna2TileButton BtnSifreSifirlama;
        private Guna.UI2.WinForms.Guna2TextBox TxtBxAdi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDogumTarihi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblAdi;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxAciklamaResim;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxClose;
        private Guna.UI2.WinForms.Guna2Elipse frmSifreSifirlaElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmSifreSifirlaDragControl;
    }
}