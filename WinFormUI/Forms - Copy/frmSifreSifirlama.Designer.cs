﻿namespace WinFormUI.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreSifirlama));
            this.frmSifreSifirlamaElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmSifreSifirlamaDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
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
            this.PnlAciklama = new Guna.UI2.WinForms.Guna2Panel();
            this.PnlSifreSifirlama.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmSifreSifirlamaDragControl
            // 
            this.frmSifreSifirlamaDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmSifreSifirlamaDragControl.UseTransparentDrag = true;
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
            resources.ApplyResources(this.PnlSifreSifirlama, "PnlSifreSifirlama");
            this.PnlSifreSifirlama.Name = "PnlSifreSifirlama";
            // 
            // dtSfDogumTarih
            // 
            this.dtSfDogumTarih.BackColor = System.Drawing.Color.White;
            this.dtSfDogumTarih.Checked = true;
            this.dtSfDogumTarih.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dtSfDogumTarih, "dtSfDogumTarih");
            this.dtSfDogumTarih.ForeColor = System.Drawing.Color.Black;
            this.dtSfDogumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtSfDogumTarih.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtSfDogumTarih.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtSfDogumTarih.Name = "dtSfDogumTarih";
            this.dtSfDogumTarih.Value = new System.DateTime(2024, 5, 16, 2, 21, 10, 267);
            // 
            // LblSifreSifirlama
            // 
            this.LblSifreSifirlama.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LblSifreSifirlama, "LblSifreSifirlama");
            this.LblSifreSifirlama.Name = "LblSifreSifirlama";
            // 
            // TxtBxSoyadi
            // 
            this.TxtBxSoyadi.BorderRadius = 5;
            this.TxtBxSoyadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBxSoyadi.DefaultText = "";
            this.TxtBxSoyadi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBxSoyadi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBxSoyadi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxSoyadi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxSoyadi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.TxtBxSoyadi, "TxtBxSoyadi");
            this.TxtBxSoyadi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxSoyadi.Name = "TxtBxSoyadi";
            this.TxtBxSoyadi.PasswordChar = '\0';
            this.TxtBxSoyadi.PlaceholderText = "";
            this.TxtBxSoyadi.SelectedText = "";
            // 
            // LbSoyadi
            // 
            this.LbSoyadi.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LbSoyadi, "LbSoyadi");
            this.LbSoyadi.Name = "LbSoyadi";
            // 
            // LblTcNo
            // 
            this.LblTcNo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LblTcNo, "LblTcNo");
            this.LblTcNo.Name = "LblTcNo";
            // 
            // TxtBxTcNo
            // 
            this.TxtBxTcNo.BorderRadius = 5;
            this.TxtBxTcNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBxTcNo.DefaultText = "";
            this.TxtBxTcNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBxTcNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBxTcNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxTcNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxTcNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.TxtBxTcNo, "TxtBxTcNo");
            this.TxtBxTcNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxTcNo.Name = "TxtBxTcNo";
            this.TxtBxTcNo.PasswordChar = '\0';
            this.TxtBxTcNo.PlaceholderText = "";
            this.TxtBxTcNo.SelectedText = "";
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
            this.BtnSifreSifirlama.Click += new System.EventHandler(this.BtnSifreSifirlama_Click);
            // 
            // TxtBxAdi
            // 
            this.TxtBxAdi.BorderRadius = 5;
            this.TxtBxAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBxAdi.DefaultText = "";
            this.TxtBxAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBxAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBxAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.TxtBxAdi, "TxtBxAdi");
            this.TxtBxAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxAdi.Name = "TxtBxAdi";
            this.TxtBxAdi.PasswordChar = '\0';
            this.TxtBxAdi.PlaceholderText = "";
            this.TxtBxAdi.SelectedText = "";
            // 
            // LblDogumTarihi
            // 
            this.LblDogumTarihi.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LblDogumTarihi, "LblDogumTarihi");
            this.LblDogumTarihi.Name = "LblDogumTarihi";
            // 
            // LblAdi
            // 
            this.LblAdi.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LblAdi, "LblAdi");
            this.LblAdi.Name = "LblAdi";
            // 
            // PnlAciklama
            // 
            resources.ApplyResources(this.PnlAciklama, "PnlAciklama");
            this.PnlAciklama.Name = "PnlAciklama";
            this.PnlAciklama.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlAciklama_Paint);
            // 
            // frmSifreSifirlama
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlAciklama);
            this.Controls.Add(this.PnlSifreSifirlama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSifreSifirlama";
            this.PnlSifreSifirlama.ResumeLayout(false);
            this.PnlSifreSifirlama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse frmSifreSifirlamaElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmSifreSifirlamaDragControl;
        private Guna.UI2.WinForms.Guna2Panel PnlSifreSifirlama;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDogumTarihi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblAdi;
        private Guna.UI2.WinForms.Guna2TextBox TxtBxAdi;
        private Guna.UI2.WinForms.Guna2TileButton BtnSifreSifirlama;
        private Guna.UI2.WinForms.Guna2TileButton btnHatirladim;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTcNo;
        private Guna.UI2.WinForms.Guna2TextBox TxtBxTcNo;
        private Guna.UI2.WinForms.Guna2TextBox TxtBxSoyadi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbSoyadi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblSifreSifirlama;
        private Guna.UI2.WinForms.Guna2Panel PnlAciklama;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtSfDogumTarih;
    }
}