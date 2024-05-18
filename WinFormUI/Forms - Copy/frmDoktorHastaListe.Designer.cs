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
            this.LblEvliMi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblCocukSayisi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaAdresi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaDogumTarihi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaCinsiyet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaSoyadi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaAdi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PctrBoxHasta = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PnlDoktor = new Guna.UI2.WinForms.Guna2Panel();
            this.DataGwHastaKayitListe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PnlHastaBilgisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxCReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGwHastaKayit)).BeginInit();
            this.PnlHastaDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBoxHasta)).BeginInit();
            this.PnlDoktor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGwHastaKayitListe)).BeginInit();
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
            this.PnlHastaBilgisi.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHastaKayit_Paint);
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
            this.DataGwHastaKayit.ThemeStyle.ReadOnly = false;
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.Height = 22;
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGwHastaKayit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGwHastaKayit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGwHastaKayit_CellClick);
            this.DataGwHastaKayit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGwHastaKayit_CellContentClick);
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
            this.PnlHastaDetay.Controls.Add(this.LblEvliMi);
            this.PnlHastaDetay.Controls.Add(this.LblCocukSayisi);
            this.PnlHastaDetay.Controls.Add(this.LblHastaAdresi);
            this.PnlHastaDetay.Controls.Add(this.LblHastaDogumTarihi);
            this.PnlHastaDetay.Controls.Add(this.LblHastaCinsiyet);
            this.PnlHastaDetay.Controls.Add(this.LblHastaSoyadi);
            this.PnlHastaDetay.Controls.Add(this.LblHastaAdi);
            this.PnlHastaDetay.Controls.Add(this.PctrBoxHasta);
            this.PnlHastaDetay.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlHastaDetay.Location = new System.Drawing.Point(0, 278);
            this.PnlHastaDetay.Name = "PnlHastaDetay";
            this.PnlHastaDetay.Size = new System.Drawing.Size(535, 328);
            this.PnlHastaDetay.TabIndex = 41;
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
            this.LblHastaAdi.Click += new System.EventHandler(this.LblHastaAdi_Click);
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
            this.PnlDoktor.Controls.Add(this.DataGwHastaKayitListe);
            this.PnlDoktor.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlDoktor.Location = new System.Drawing.Point(541, 278);
            this.PnlDoktor.Name = "PnlDoktor";
            this.PnlDoktor.Size = new System.Drawing.Size(641, 328);
            this.PnlDoktor.TabIndex = 42;
            // 
            // DataGwHastaKayitListe
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGwHastaKayitListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGwHastaKayitListe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGwHastaKayitListe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGwHastaKayitListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGwHastaKayitListe.ColumnHeadersHeight = 25;
            this.DataGwHastaKayitListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGwHastaKayitListe.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGwHastaKayitListe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DataGwHastaKayitListe.Location = new System.Drawing.Point(24, 24);
            this.DataGwHastaKayitListe.Name = "DataGwHastaKayitListe";
            this.DataGwHastaKayitListe.RowHeadersVisible = false;
            this.DataGwHastaKayitListe.Size = new System.Drawing.Size(592, 274);
            this.DataGwHastaKayitListe.TabIndex = 22;
            this.DataGwHastaKayitListe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGwHastaKayitListe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGwHastaKayitListe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGwHastaKayitListe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGwHastaKayitListe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGwHastaKayitListe.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.DataGwHastaKayitListe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DataGwHastaKayitListe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGwHastaKayitListe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGwHastaKayitListe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGwHastaKayitListe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGwHastaKayitListe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGwHastaKayitListe.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGwHastaKayitListe.ThemeStyle.ReadOnly = false;
            this.DataGwHastaKayitListe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGwHastaKayitListe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGwHastaKayitListe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGwHastaKayitListe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGwHastaKayitListe.ThemeStyle.RowsStyle.Height = 22;
            this.DataGwHastaKayitListe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGwHastaKayitListe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGwHastaKayitListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmHastaKayitElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmHastaKayitDragControl;
        private Guna.UI2.WinForms.Guna2Panel PnlHastaBilgisi;
        private Guna.UI2.WinForms.Guna2TextBox TxtBxTcNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblProtokol;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblKayitTarihi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblProtokolNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblKayit;
        private Guna.UI2.WinForms.Guna2DataGridView DataGwHastaKayit;
        private Guna.UI2.WinForms.Guna2Panel PnlHastaDetay;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblEvliMi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCocukSayisi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaAdresi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaDogumTarihi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaCinsiyet;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaSoyadi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaAdi;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBoxHasta;
        private Guna.UI2.WinForms.Guna2Panel PnlDoktor;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxClose;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxCReturn;
        private Guna.UI2.WinForms.Guna2DataGridView DataGwHastaKayitListe;
    }
}