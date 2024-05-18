namespace WinFormUI.Forms
{
    partial class frmDoktorHastaListe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.frmHastaKayitElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmHastaKayitDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PnlHastaBilgisi = new Guna.UI2.WinForms.Guna2Panel();
            this.PctrBxCReturn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PctrBxClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DataGwHastaKayit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.LblKayitTarihi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblProtokolNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblKayit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblProtokol = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtBxTcNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.PnlHastaDetay = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDogumYer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAdres = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBilgilendirme = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIletisim = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDogumTarih = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCinsiyet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIdentityNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHastaAdSoyad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PctrBoxHasta = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PnlDoktor = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvHastaKayit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PnlHastaBilgisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxCReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGwHastaKayit)).BeginInit();
            this.PnlHastaDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBoxHasta)).BeginInit();
            this.PnlDoktor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastaKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // frmHastaKayitDragControl
            // 
            this.frmHastaKayitDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmHastaKayitDragControl.UseTransparentDrag = true;
            // 
            // PnlHastaBilgisi
            // 
            this.PnlHastaBilgisi.Controls.Add(this.PctrBxCReturn);
            this.PnlHastaBilgisi.Controls.Add(this.PctrBxClose);
            this.PnlHastaBilgisi.Controls.Add(this.DataGwHastaKayit);
            this.PnlHastaBilgisi.Controls.Add(this.LblKayitTarihi);
            this.PnlHastaBilgisi.Controls.Add(this.LblProtokolNo);
            this.PnlHastaBilgisi.Controls.Add(this.LblKayit);
            this.PnlHastaBilgisi.Controls.Add(this.LblProtokol);
            this.PnlHastaBilgisi.Controls.Add(this.TxtBxTcNo);
            this.PnlHastaBilgisi.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHastaBilgisi.Location = new System.Drawing.Point(0, 0);
            this.PnlHastaBilgisi.Name = "PnlHastaBilgisi";
            this.PnlHastaBilgisi.Size = new System.Drawing.Size(1182, 278);
            this.PnlHastaBilgisi.TabIndex = 0;
            // 
            // PctrBxCReturn
            // 
            this.PctrBxCReturn.Image = global::WinFormUI.Properties.Resources._return;
            this.PctrBxCReturn.ImageRotate = 0F;
            this.PctrBxCReturn.Location = new System.Drawing.Point(1123, 3);
            this.PctrBxCReturn.Name = "PctrBxCReturn";
            this.PctrBxCReturn.Size = new System.Drawing.Size(25, 25);
            this.PctrBxCReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxCReturn.TabIndex = 27;
            this.PctrBxCReturn.TabStop = false;
            this.PctrBxCReturn.Click += new System.EventHandler(this.PctrBxCReturn_Click);
            // 
            // PctrBxClose
            // 
            this.PctrBxClose.Image = global::WinFormUI.Properties.Resources.multiply;
            this.PctrBxClose.ImageRotate = 0F;
            this.PctrBxClose.Location = new System.Drawing.Point(1154, 3);
            this.PctrBxClose.Name = "PctrBxClose";
            this.PctrBxClose.Size = new System.Drawing.Size(25, 25);
            this.PctrBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxClose.TabIndex = 22;
            this.PctrBxClose.TabStop = false;
            this.PctrBxClose.Click += new System.EventHandler(this.PctrBxClose_Click);
            // 
            // DataGwHastaKayit
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGwHastaKayit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGwHastaKayit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGwHastaKayit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGwHastaKayit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGwHastaKayit.ColumnHeadersHeight = 25;
            this.DataGwHastaKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGwHastaKayit.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGwHastaKayit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DataGwHastaKayit.Location = new System.Drawing.Point(31, 86);
            this.DataGwHastaKayit.Name = "DataGwHastaKayit";
            this.DataGwHastaKayit.ReadOnly = true;
            this.DataGwHastaKayit.RowHeadersVisible = false;
            this.DataGwHastaKayit.Size = new System.Drawing.Size(1117, 170);
            this.DataGwHastaKayit.TabIndex = 21;
            this.DataGwHastaKayit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGwHastaKayit.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGwHastaKayit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGwHastaKayit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGwHastaKayit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGwHastaKayit.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.DataGwHastaKayit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DataGwHastaKayit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGwHastaKayit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGwHastaKayit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGwHastaKayit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGwHastaKayit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGwHastaKayit.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGwHastaKayit.ThemeStyle.ReadOnly = true;
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.Height = 22;
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGwHastaKayit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGwHastaKayit_CellClick);
            // 
            // LblKayitTarihi
            // 
            this.LblKayitTarihi.BackColor = System.Drawing.Color.Transparent;
            this.LblKayitTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKayitTarihi.Location = new System.Drawing.Point(934, 44);
            this.LblKayitTarihi.Name = "LblKayitTarihi";
            this.LblKayitTarihi.Size = new System.Drawing.Size(12, 17);
            this.LblKayitTarihi.TabIndex = 20;
            this.LblKayitTarihi.Text = "...";
            // 
            // LblProtokolNo
            // 
            this.LblProtokolNo.BackColor = System.Drawing.Color.Transparent;
            this.LblProtokolNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblProtokolNo.Location = new System.Drawing.Point(934, 21);
            this.LblProtokolNo.Name = "LblProtokolNo";
            this.LblProtokolNo.Size = new System.Drawing.Size(12, 17);
            this.LblProtokolNo.TabIndex = 19;
            this.LblProtokolNo.Text = "...";
            // 
            // LblKayit
            // 
            this.LblKayit.BackColor = System.Drawing.Color.Transparent;
            this.LblKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKayit.Location = new System.Drawing.Point(855, 44);
            this.LblKayit.Name = "LblKayit";
            this.LblKayit.Size = new System.Drawing.Size(65, 17);
            this.LblKayit.TabIndex = 18;
            this.LblKayit.Text = "Kayıt Tarihi:";
            // 
            // LblProtokol
            // 
            this.LblProtokol.BackColor = System.Drawing.Color.Transparent;
            this.LblProtokol.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblProtokol.Location = new System.Drawing.Point(855, 21);
            this.LblProtokol.Name = "LblProtokol";
            this.LblProtokol.Size = new System.Drawing.Size(70, 17);
            this.LblProtokol.TabIndex = 17;
            this.LblProtokol.Text = "Protokol No:";
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
            this.TxtBxTcNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBxTcNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxTcNo.Location = new System.Drawing.Point(31, 21);
            this.TxtBxTcNo.Name = "TxtBxTcNo";
            this.TxtBxTcNo.PasswordChar = '\0';
            this.TxtBxTcNo.PlaceholderText = "TC Kimlik Numaranızı Giriniz";
            this.TxtBxTcNo.SelectedText = "";
            this.TxtBxTcNo.Size = new System.Drawing.Size(196, 30);
            this.TxtBxTcNo.TabIndex = 16;
            this.TxtBxTcNo.TextChanged += new System.EventHandler(this.TxtBxTcNo_TextChanged);
            // 
            // PnlHastaDetay
            // 
            this.PnlHastaDetay.Controls.Add(this.lblDogumYer);
            this.PnlHastaDetay.Controls.Add(this.lblEmail);
            this.PnlHastaDetay.Controls.Add(this.lblAdres);
            this.PnlHastaDetay.Controls.Add(this.lblBilgilendirme);
            this.PnlHastaDetay.Controls.Add(this.lblIletisim);
            this.PnlHastaDetay.Controls.Add(this.lblDogumTarih);
            this.PnlHastaDetay.Controls.Add(this.lblCinsiyet);
            this.PnlHastaDetay.Controls.Add(this.lblIdentityNumber);
            this.PnlHastaDetay.Controls.Add(this.lblHastaAdSoyad);
            this.PnlHastaDetay.Controls.Add(this.PctrBoxHasta);
            this.PnlHastaDetay.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlHastaDetay.Location = new System.Drawing.Point(0, 278);
            this.PnlHastaDetay.Name = "PnlHastaDetay";
            this.PnlHastaDetay.Size = new System.Drawing.Size(535, 328);
            this.PnlHastaDetay.TabIndex = 41;
            // 
            // lblDogumYer
            // 
            this.lblDogumYer.BackColor = System.Drawing.Color.Transparent;
            this.lblDogumYer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumYer.Location = new System.Drawing.Point(200, 139);
            this.lblDogumYer.Name = "lblDogumYer";
            this.lblDogumYer.Size = new System.Drawing.Size(12, 17);
            this.lblDogumYer.TabIndex = 60;
            this.lblDogumYer.Text = "...";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(200, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(12, 17);
            this.lblEmail.TabIndex = 59;
            this.lblEmail.Text = "...";
            // 
            // lblAdres
            // 
            this.lblAdres.BackColor = System.Drawing.Color.Transparent;
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(31, 212);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(12, 17);
            this.lblAdres.TabIndex = 58;
            this.lblAdres.Text = "...";
            // 
            // lblBilgilendirme
            // 
            this.lblBilgilendirme.BackColor = System.Drawing.Color.Transparent;
            this.lblBilgilendirme.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgilendirme.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBilgilendirme.Location = new System.Drawing.Point(13, 299);
            this.lblBilgilendirme.Name = "lblBilgilendirme";
            this.lblBilgilendirme.Size = new System.Drawing.Size(214, 17);
            this.lblBilgilendirme.TabIndex = 57;
            this.lblBilgilendirme.Text = "Bu Kayıtlar Belge  Yerine Geçmemektedir";
            // 
            // lblIletisim
            // 
            this.lblIletisim.AutoSize = false;
            this.lblIletisim.BackColor = System.Drawing.Color.Transparent;
            this.lblIletisim.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIletisim.Location = new System.Drawing.Point(31, 181);
            this.lblIletisim.Name = "lblIletisim";
            this.lblIletisim.Size = new System.Drawing.Size(231, 48);
            this.lblIletisim.TabIndex = 56;
            this.lblIletisim.Text = "...";
            // 
            // lblDogumTarih
            // 
            this.lblDogumTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblDogumTarih.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarih.Location = new System.Drawing.Point(200, 93);
            this.lblDogumTarih.Name = "lblDogumTarih";
            this.lblDogumTarih.Size = new System.Drawing.Size(12, 17);
            this.lblDogumTarih.TabIndex = 55;
            this.lblDogumTarih.Text = "...";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(200, 70);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(12, 17);
            this.lblCinsiyet.TabIndex = 54;
            this.lblCinsiyet.Text = "...";
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentityNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdentityNumber.Location = new System.Drawing.Point(200, 47);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(12, 17);
            this.lblIdentityNumber.TabIndex = 53;
            this.lblIdentityNumber.Text = "...";
            // 
            // lblHastaAdSoyad
            // 
            this.lblHastaAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblHastaAdSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaAdSoyad.Location = new System.Drawing.Point(200, 24);
            this.lblHastaAdSoyad.Name = "lblHastaAdSoyad";
            this.lblHastaAdSoyad.Size = new System.Drawing.Size(12, 17);
            this.lblHastaAdSoyad.TabIndex = 52;
            this.lblHastaAdSoyad.Text = "...";
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
            // PnlDoktor
            // 
            this.PnlDoktor.Controls.Add(this.dgvHastaKayit);
            this.PnlDoktor.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlDoktor.Location = new System.Drawing.Point(541, 278);
            this.PnlDoktor.Name = "PnlDoktor";
            this.PnlDoktor.Size = new System.Drawing.Size(641, 328);
            this.PnlDoktor.TabIndex = 42;
            // 
            // dgvHastaKayit
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvHastaKayit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHastaKayit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHastaKayit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHastaKayit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHastaKayit.ColumnHeadersHeight = 25;
            this.dgvHastaKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHastaKayit.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHastaKayit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvHastaKayit.Location = new System.Drawing.Point(24, 24);
            this.dgvHastaKayit.Name = "dgvHastaKayit";
            this.dgvHastaKayit.RowHeadersVisible = false;
            this.dgvHastaKayit.Size = new System.Drawing.Size(592, 274);
            this.dgvHastaKayit.TabIndex = 22;
            this.dgvHastaKayit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHastaKayit.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHastaKayit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHastaKayit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHastaKayit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHastaKayit.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvHastaKayit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvHastaKayit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHastaKayit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHastaKayit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvHastaKayit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHastaKayit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHastaKayit.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvHastaKayit.ThemeStyle.ReadOnly = false;
            this.dgvHastaKayit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHastaKayit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHastaKayit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvHastaKayit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHastaKayit.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHastaKayit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHastaKayit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmDoktorHastaListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 606);
            this.Controls.Add(this.PnlDoktor);
            this.Controls.Add(this.PnlHastaDetay);
            this.Controls.Add(this.PnlHastaBilgisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoktorHastaListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHastaKayit";
            this.Load += new System.EventHandler(this.frmHastaKayit_Load);
            this.PnlHastaBilgisi.ResumeLayout(false);
            this.PnlHastaBilgisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxCReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGwHastaKayit)).EndInit();
            this.PnlHastaDetay.ResumeLayout(false);
            this.PnlHastaDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBoxHasta)).EndInit();
            this.PnlDoktor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastaKayit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmHastaKayitElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmHastaKayitDragControl;
        private Guna.UI2.WinForms.Guna2Panel PnlHastaBilgisi;
        private Guna.UI2.WinForms.Guna2TextBox TxtBxTcNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblKayitTarihi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblKayit;
        private Guna.UI2.WinForms.Guna2DataGridView DataGwHastaKayit;
        private Guna.UI2.WinForms.Guna2Panel PnlHastaDetay;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAdres;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBilgilendirme;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIletisim;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDogumTarih;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCinsiyet;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIdentityNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHastaAdSoyad;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBoxHasta;
        private Guna.UI2.WinForms.Guna2Panel PnlDoktor;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxClose;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxCReturn;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHastaKayit;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblProtokolNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblProtokol;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDogumYer;
    }
}