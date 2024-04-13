namespace WinFormUI.Forms
{
    partial class frmHastaKayit
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
            this.dgvHastaKayit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblKayitTarihi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProtokolNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblKayit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProtokol = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTcNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.PnlHastaDetay = new Guna.UI2.WinForms.Guna2Panel();
            this.LblEvliMi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblCocukSayisi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaAdresi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaDogumTarihi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaCinsiyet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaSoyadi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHastaAdi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pctrBoxHasta = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlDoktor = new Guna.UI2.WinForms.Guna2Panel();
            this.btnIptal = new Guna.UI2.WinForms.Guna2TileButton();
            this.dgvDoktorBilgisi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnHastaKayit = new Guna.UI2.WinForms.Guna2TileButton();
            this.PnlHastaBilgisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastaKayit)).BeginInit();
            this.PnlHastaDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxHasta)).BeginInit();
            this.pnlDoktor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktorBilgisi)).BeginInit();
            this.SuspendLayout();
            // 
            // frmHastaKayitDragControl
            // 
            this.frmHastaKayitDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmHastaKayitDragControl.UseTransparentDrag = true;
            // 
            // PnlHastaBilgisi
            // 
            this.PnlHastaBilgisi.Controls.Add(this.dgvHastaKayit);
            this.PnlHastaBilgisi.Controls.Add(this.lblKayitTarihi);
            this.PnlHastaBilgisi.Controls.Add(this.lblProtokolNo);
            this.PnlHastaBilgisi.Controls.Add(this.lblKayit);
            this.PnlHastaBilgisi.Controls.Add(this.lblProtokol);
            this.PnlHastaBilgisi.Controls.Add(this.txtTcNo);
            this.PnlHastaBilgisi.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHastaBilgisi.Location = new System.Drawing.Point(0, 0);
            this.PnlHastaBilgisi.Name = "PnlHastaBilgisi";
            this.PnlHastaBilgisi.Size = new System.Drawing.Size(1182, 278);
            this.PnlHastaBilgisi.TabIndex = 0;
            this.PnlHastaBilgisi.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHastaKayit_Paint);
            // 
            // dgvHastaKayit
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHastaKayit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHastaKayit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHastaKayit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHastaKayit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHastaKayit.ColumnHeadersHeight = 4;
            this.dgvHastaKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHastaKayit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHastaKayit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvHastaKayit.Location = new System.Drawing.Point(31, 86);
            this.dgvHastaKayit.Name = "dgvHastaKayit";
            this.dgvHastaKayit.RowHeadersVisible = false;
            this.dgvHastaKayit.Size = new System.Drawing.Size(1117, 170);
            this.dgvHastaKayit.TabIndex = 21;
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
            this.dgvHastaKayit.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvHastaKayit.ThemeStyle.ReadOnly = false;
            this.dgvHastaKayit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHastaKayit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHastaKayit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvHastaKayit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHastaKayit.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHastaKayit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHastaKayit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblKayitTarihi
            // 
            this.lblKayitTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblKayitTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitTarihi.Location = new System.Drawing.Point(934, 44);
            this.lblKayitTarihi.Name = "lblKayitTarihi";
            this.lblKayitTarihi.Size = new System.Drawing.Size(12, 17);
            this.lblKayitTarihi.TabIndex = 20;
            this.lblKayitTarihi.Text = "...";
            // 
            // lblProtokolNo
            // 
            this.lblProtokolNo.BackColor = System.Drawing.Color.Transparent;
            this.lblProtokolNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProtokolNo.Location = new System.Drawing.Point(934, 21);
            this.lblProtokolNo.Name = "lblProtokolNo";
            this.lblProtokolNo.Size = new System.Drawing.Size(12, 17);
            this.lblProtokolNo.TabIndex = 19;
            this.lblProtokolNo.Text = "...";
            // 
            // lblKayit
            // 
            this.lblKayit.BackColor = System.Drawing.Color.Transparent;
            this.lblKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayit.Location = new System.Drawing.Point(855, 44);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(65, 17);
            this.lblKayit.TabIndex = 18;
            this.lblKayit.Text = "Kayıt Tarihi:";
            // 
            // lblProtokol
            // 
            this.lblProtokol.BackColor = System.Drawing.Color.Transparent;
            this.lblProtokol.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProtokol.Location = new System.Drawing.Point(855, 21);
            this.lblProtokol.Name = "lblProtokol";
            this.lblProtokol.Size = new System.Drawing.Size(70, 17);
            this.lblProtokol.TabIndex = 17;
            this.lblProtokol.Text = "Protokol No:";
            // 
            // txtTcNo
            // 
            this.txtTcNo.BorderRadius = 5;
            this.txtTcNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTcNo.DefaultText = "";
            this.txtTcNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTcNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTcNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTcNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTcNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTcNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTcNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTcNo.Location = new System.Drawing.Point(31, 21);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.PasswordChar = '\0';
            this.txtTcNo.PlaceholderText = "TC Kimlik Numarası Giriniz";
            this.txtTcNo.SelectedText = "";
            this.txtTcNo.Size = new System.Drawing.Size(196, 30);
            this.txtTcNo.TabIndex = 16;
            // 
            // PnlHastaDetay
            // 
            this.PnlHastaDetay.Controls.Add(this.LblEvliMi);
            this.PnlHastaDetay.Controls.Add(this.LblCocukSayisi);
            this.PnlHastaDetay.Controls.Add(this.LblHastaAdresi);
            this.PnlHastaDetay.Controls.Add(this.LblHastaDogumTarihi);
            this.PnlHastaDetay.Controls.Add(this.LblHastaCinsiyet);
            this.PnlHastaDetay.Controls.Add(this.LblHastaSoyadi);
            this.PnlHastaDetay.Controls.Add(this.lblHastaAdi);
            this.PnlHastaDetay.Controls.Add(this.pctrBoxHasta);
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
            // lblHastaAdi
            // 
            this.lblHastaAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblHastaAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaAdi.Location = new System.Drawing.Point(200, 24);
            this.lblHastaAdi.Name = "lblHastaAdi";
            this.lblHastaAdi.Size = new System.Drawing.Size(12, 17);
            this.lblHastaAdi.TabIndex = 52;
            this.lblHastaAdi.Text = "...";
            // 
            // pctrBoxHasta
            // 
            this.pctrBoxHasta.ImageRotate = 0F;
            this.pctrBoxHasta.Location = new System.Drawing.Point(31, 24);
            this.pctrBoxHasta.Name = "pctrBoxHasta";
            this.pctrBoxHasta.Size = new System.Drawing.Size(125, 140);
            this.pctrBoxHasta.TabIndex = 51;
            this.pctrBoxHasta.TabStop = false;
            // 
            // pnlDoktor
            // 
            this.pnlDoktor.Controls.Add(this.btnIptal);
            this.pnlDoktor.Controls.Add(this.dgvDoktorBilgisi);
            this.pnlDoktor.Controls.Add(this.btnHastaKayit);
            this.pnlDoktor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDoktor.Location = new System.Drawing.Point(541, 278);
            this.pnlDoktor.Name = "pnlDoktor";
            this.pnlDoktor.Size = new System.Drawing.Size(641, 328);
            this.pnlDoktor.TabIndex = 42;
            // 
            // btnIptal
            // 
            this.btnIptal.Animated = true;
            this.btnIptal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIptal.BorderRadius = 5;
            this.btnIptal.BorderThickness = 1;
            this.btnIptal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIptal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIptal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIptal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIptal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIptal.Location = new System.Drawing.Point(45, 281);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(196, 33);
            this.btnIptal.TabIndex = 43;
            this.btnIptal.Text = "İptal";
            // 
            // dgvDoktorBilgisi
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDoktorBilgisi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDoktorBilgisi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDoktorBilgisi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoktorBilgisi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDoktorBilgisi.ColumnHeadersHeight = 4;
            this.dgvDoktorBilgisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoktorBilgisi.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDoktorBilgisi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvDoktorBilgisi.Location = new System.Drawing.Point(45, 24);
            this.dgvDoktorBilgisi.Name = "dgvDoktorBilgisi";
            this.dgvDoktorBilgisi.RowHeadersVisible = false;
            this.dgvDoktorBilgisi.Size = new System.Drawing.Size(562, 170);
            this.dgvDoktorBilgisi.TabIndex = 42;
            this.dgvDoktorBilgisi.Tag = "";
            this.dgvDoktorBilgisi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoktorBilgisi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDoktorBilgisi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDoktorBilgisi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDoktorBilgisi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDoktorBilgisi.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvDoktorBilgisi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvDoktorBilgisi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDoktorBilgisi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDoktorBilgisi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvDoktorBilgisi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDoktorBilgisi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDoktorBilgisi.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDoktorBilgisi.ThemeStyle.ReadOnly = false;
            this.dgvDoktorBilgisi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoktorBilgisi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDoktorBilgisi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvDoktorBilgisi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDoktorBilgisi.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDoktorBilgisi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDoktorBilgisi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnHastaKayit
            // 
            this.btnHastaKayit.Animated = true;
            this.btnHastaKayit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHastaKayit.BorderRadius = 5;
            this.btnHastaKayit.BorderThickness = 1;
            this.btnHastaKayit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHastaKayit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHastaKayit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHastaKayit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHastaKayit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHastaKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnHastaKayit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHastaKayit.Location = new System.Drawing.Point(411, 281);
            this.btnHastaKayit.Name = "btnHastaKayit";
            this.btnHastaKayit.Size = new System.Drawing.Size(196, 33);
            this.btnHastaKayit.TabIndex = 41;
            this.btnHastaKayit.Text = "Kaydet";
            // 
            // frmHastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 606);
            this.Controls.Add(this.pnlDoktor);
            this.Controls.Add(this.PnlHastaDetay);
            this.Controls.Add(this.PnlHastaBilgisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHastaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHastaKayit";
            this.Load += new System.EventHandler(this.frmHastaKayit_Load);
            this.PnlHastaBilgisi.ResumeLayout(false);
            this.PnlHastaBilgisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastaKayit)).EndInit();
            this.PnlHastaDetay.ResumeLayout(false);
            this.PnlHastaDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxHasta)).EndInit();
            this.pnlDoktor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktorBilgisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmHastaKayitElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmHastaKayitDragControl;
        private Guna.UI2.WinForms.Guna2Panel PnlHastaBilgisi;
        private Guna.UI2.WinForms.Guna2TextBox txtTcNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProtokol;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblKayitTarihi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProtokolNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblKayit;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHastaKayit;
        private Guna.UI2.WinForms.Guna2Panel PnlHastaDetay;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblEvliMi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCocukSayisi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaAdresi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaDogumTarihi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaCinsiyet;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaSoyadi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHastaAdi;
        private Guna.UI2.WinForms.Guna2PictureBox pctrBoxHasta;
        private Guna.UI2.WinForms.Guna2Panel pnlDoktor;
        private Guna.UI2.WinForms.Guna2TileButton btnIptal;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDoktorBilgisi;
        private Guna.UI2.WinForms.Guna2TileButton btnHastaKayit;
    }
}