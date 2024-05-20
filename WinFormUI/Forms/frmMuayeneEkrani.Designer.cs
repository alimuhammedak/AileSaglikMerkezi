using System.Windows.Forms;

namespace WinFormUI.Forms
{
    partial class frmMuayeneEkrani
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
            this.frmMuayeneEkraniElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmMuayeneEkraniDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PnlHastaBilgi = new Guna.UI2.WinForms.Guna2Panel();
            this.LblTcNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaDogumTarihi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaCinsiyet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblIletisimNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHastaAdi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PnlSikayetEkleme = new Guna.UI2.WinForms.Guna2Panel();
            this.TxtBxHastaSikayeti = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblSikayetEkleme = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PnlRecete = new Guna.UI2.WinForms.Guna2Panel();
            this.lstSelectedMedicines = new System.Windows.Forms.ListBox();
            this.cmbIlacList = new System.Windows.Forms.ComboBox();
            this.LblRecete = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PnlUstBilgi = new Guna.UI2.WinForms.Guna2Panel();
            this.LblMuayeneTarihi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblMuayene = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblProtokolNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblProtokol = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PnlTetkikler = new Guna.UI2.WinForms.Guna2Panel();
            this.cbTetkikList = new System.Windows.Forms.CheckedListBox();
            this.LblTetkik = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PnlTani = new Guna.UI2.WinForms.Guna2Panel();
            this.lstselectedDiagnosis = new System.Windows.Forms.ListBox();
            this.txtHastalikDetay = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbHastalikList = new System.Windows.Forms.ComboBox();
            this.LblHastalik = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.LblHastaIslemleri = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbSave = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PctrBxCReturn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PctrBxClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PctrBoxHasta = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PnlHastaBilgi.SuspendLayout();
            this.PnlSikayetEkleme.SuspendLayout();
            this.PnlRecete.SuspendLayout();
            this.PnlUstBilgi.SuspendLayout();
            this.PnlTetkikler.SuspendLayout();
            this.PnlTani.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxCReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBoxHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // frmMuayeneEkraniDragControl
            // 
            this.frmMuayeneEkraniDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmMuayeneEkraniDragControl.UseTransparentDrag = true;
            // 
            // PnlHastaBilgi
            // 
            this.PnlHastaBilgi.Controls.Add(this.LblTcNo);
            this.PnlHastaBilgi.Controls.Add(this.LblHastaDogumTarihi);
            this.PnlHastaBilgi.Controls.Add(this.LblHastaCinsiyet);
            this.PnlHastaBilgi.Controls.Add(this.LblIletisimNo);
            this.PnlHastaBilgi.Controls.Add(this.LblHastaAdi);
            this.PnlHastaBilgi.Controls.Add(this.PctrBoxHasta);
            this.PnlHastaBilgi.Location = new System.Drawing.Point(0, 0);
            this.PnlHastaBilgi.Name = "PnlHastaBilgi";
            this.PnlHastaBilgi.Size = new System.Drawing.Size(235, 340);
            this.PnlHastaBilgi.TabIndex = 42;
            // 
            // LblTcNo
            // 
            this.LblTcNo.BackColor = System.Drawing.Color.Transparent;
            this.LblTcNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTcNo.Location = new System.Drawing.Point(31, 200);
            this.LblTcNo.Name = "LblTcNo";
            this.LblTcNo.Size = new System.Drawing.Size(12, 17);
            this.LblTcNo.TabIndex = 57;
            this.LblTcNo.Text = "...";
            // 
            // LblHastaDogumTarihi
            // 
            this.LblHastaDogumTarihi.BackColor = System.Drawing.Color.Transparent;
            this.LblHastaDogumTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaDogumTarihi.Location = new System.Drawing.Point(31, 223);
            this.LblHastaDogumTarihi.Name = "LblHastaDogumTarihi";
            this.LblHastaDogumTarihi.Size = new System.Drawing.Size(12, 17);
            this.LblHastaDogumTarihi.TabIndex = 55;
            this.LblHastaDogumTarihi.Text = "...";
            // 
            // LblHastaCinsiyet
            // 
            this.LblHastaCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.LblHastaCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaCinsiyet.Location = new System.Drawing.Point(31, 269);
            this.LblHastaCinsiyet.Name = "LblHastaCinsiyet";
            this.LblHastaCinsiyet.Size = new System.Drawing.Size(12, 17);
            this.LblHastaCinsiyet.TabIndex = 54;
            this.LblHastaCinsiyet.Text = "...";
            // 
            // LblIletisimNo
            // 
            this.LblIletisimNo.BackColor = System.Drawing.Color.Transparent;
            this.LblIletisimNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblIletisimNo.Location = new System.Drawing.Point(31, 246);
            this.LblIletisimNo.Name = "LblIletisimNo";
            this.LblIletisimNo.Size = new System.Drawing.Size(12, 17);
            this.LblIletisimNo.TabIndex = 53;
            this.LblIletisimNo.Text = "...";
            // 
            // LblHastaAdi
            // 
            this.LblHastaAdi.BackColor = System.Drawing.Color.Transparent;
            this.LblHastaAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaAdi.Location = new System.Drawing.Point(31, 177);
            this.LblHastaAdi.Name = "LblHastaAdi";
            this.LblHastaAdi.Size = new System.Drawing.Size(12, 17);
            this.LblHastaAdi.TabIndex = 52;
            this.LblHastaAdi.Text = "...";
            // 
            // PnlSikayetEkleme
            // 
            this.PnlSikayetEkleme.Controls.Add(this.TxtBxHastaSikayeti);
            this.PnlSikayetEkleme.Controls.Add(this.LblSikayetEkleme);
            this.PnlSikayetEkleme.Location = new System.Drawing.Point(241, 37);
            this.PnlSikayetEkleme.Name = "PnlSikayetEkleme";
            this.PnlSikayetEkleme.Size = new System.Drawing.Size(465, 286);
            this.PnlSikayetEkleme.TabIndex = 43;
            // 
            // TxtBxHastaSikayeti
            // 
            this.TxtBxHastaSikayeti.BorderRadius = 5;
            this.TxtBxHastaSikayeti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBxHastaSikayeti.DefaultText = "";
            this.TxtBxHastaSikayeti.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBxHastaSikayeti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBxHastaSikayeti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxHastaSikayeti.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBxHastaSikayeti.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxHastaSikayeti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBxHastaSikayeti.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBxHastaSikayeti.Location = new System.Drawing.Point(3, 65);
            this.TxtBxHastaSikayeti.Multiline = true;
            this.TxtBxHastaSikayeti.Name = "TxtBxHastaSikayeti";
            this.TxtBxHastaSikayeti.PasswordChar = '\0';
            this.TxtBxHastaSikayeti.PlaceholderText = "";
            this.TxtBxHastaSikayeti.SelectedText = "";
            this.TxtBxHastaSikayeti.Size = new System.Drawing.Size(459, 199);
            this.TxtBxHastaSikayeti.TabIndex = 25;
            // 
            // LblSikayetEkleme
            // 
            this.LblSikayetEkleme.BackColor = System.Drawing.Color.Transparent;
            this.LblSikayetEkleme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LblSikayetEkleme.Location = new System.Drawing.Point(190, 24);
            this.LblSikayetEkleme.Name = "LblSikayetEkleme";
            this.LblSikayetEkleme.Size = new System.Drawing.Size(88, 19);
            this.LblSikayetEkleme.TabIndex = 22;
            this.LblSikayetEkleme.Text = "Hasta Şikayeti";
            // 
            // PnlRecete
            // 
            this.PnlRecete.Controls.Add(this.lstSelectedMedicines);
            this.PnlRecete.Controls.Add(this.cmbIlacList);
            this.PnlRecete.Controls.Add(this.LblRecete);
            this.PnlRecete.Location = new System.Drawing.Point(712, 37);
            this.PnlRecete.Name = "PnlRecete";
            this.PnlRecete.Size = new System.Drawing.Size(468, 286);
            this.PnlRecete.TabIndex = 44;
            // 
            // lstSelectedMedicines
            // 
            this.lstSelectedMedicines.FormattingEnabled = true;
            this.lstSelectedMedicines.Location = new System.Drawing.Point(38, 65);
            this.lstSelectedMedicines.Name = "lstSelectedMedicines";
            this.lstSelectedMedicines.Size = new System.Drawing.Size(394, 199);
            this.lstSelectedMedicines.TabIndex = 29;
            // 
            // cmbIlacList
            // 
            this.cmbIlacList.AllowDrop = true;
            this.cmbIlacList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbIlacList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbIlacList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIlacList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbIlacList.FormattingEnabled = true;
            this.cmbIlacList.Location = new System.Drawing.Point(38, 34);
            this.cmbIlacList.Name = "cmbIlacList";
            this.cmbIlacList.Size = new System.Drawing.Size(394, 25);
            this.cmbIlacList.TabIndex = 28;
            this.cmbIlacList.SelectedIndexChanged += new System.EventHandler(this.CmbIlacList_SelectedIndexChanged);
            this.cmbIlacList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbIlacList_KeyDown);
            // 
            // LblRecete
            // 
            this.LblRecete.BackColor = System.Drawing.Color.Transparent;
            this.LblRecete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LblRecete.Location = new System.Drawing.Point(213, 9);
            this.LblRecete.Name = "LblRecete";
            this.LblRecete.Size = new System.Drawing.Size(43, 19);
            this.LblRecete.TabIndex = 23;
            this.LblRecete.Text = "Reçete";
            // 
            // PnlUstBilgi
            // 
            this.PnlUstBilgi.Controls.Add(this.PctrBxCReturn);
            this.PnlUstBilgi.Controls.Add(this.PctrBxClose);
            this.PnlUstBilgi.Controls.Add(this.LblMuayeneTarihi);
            this.PnlUstBilgi.Controls.Add(this.LblMuayene);
            this.PnlUstBilgi.Controls.Add(this.LblProtokolNo);
            this.PnlUstBilgi.Controls.Add(this.LblProtokol);
            this.PnlUstBilgi.Location = new System.Drawing.Point(241, 0);
            this.PnlUstBilgi.Name = "PnlUstBilgi";
            this.PnlUstBilgi.Size = new System.Drawing.Size(939, 41);
            this.PnlUstBilgi.TabIndex = 45;
            // 
            // LblMuayeneTarihi
            // 
            this.LblMuayeneTarihi.BackColor = System.Drawing.Color.Transparent;
            this.LblMuayeneTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMuayeneTarihi.Location = new System.Drawing.Point(715, 11);
            this.LblMuayeneTarihi.Name = "LblMuayeneTarihi";
            this.LblMuayeneTarihi.Size = new System.Drawing.Size(12, 17);
            this.LblMuayeneTarihi.TabIndex = 23;
            this.LblMuayeneTarihi.Text = "...";
            // 
            // LblMuayene
            // 
            this.LblMuayene.BackColor = System.Drawing.Color.Transparent;
            this.LblMuayene.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMuayene.Location = new System.Drawing.Point(618, 11);
            this.LblMuayene.Name = "LblMuayene";
            this.LblMuayene.Size = new System.Drawing.Size(88, 17);
            this.LblMuayene.TabIndex = 22;
            this.LblMuayene.Text = "Muayene Tarihi:";
            // 
            // LblProtokolNo
            // 
            this.LblProtokolNo.BackColor = System.Drawing.Color.Transparent;
            this.LblProtokolNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblProtokolNo.Location = new System.Drawing.Point(471, 12);
            this.LblProtokolNo.Name = "LblProtokolNo";
            this.LblProtokolNo.Size = new System.Drawing.Size(12, 17);
            this.LblProtokolNo.TabIndex = 21;
            this.LblProtokolNo.Text = "...";
            // 
            // LblProtokol
            // 
            this.LblProtokol.BackColor = System.Drawing.Color.Transparent;
            this.LblProtokol.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblProtokol.Location = new System.Drawing.Point(392, 12);
            this.LblProtokol.Name = "LblProtokol";
            this.LblProtokol.Size = new System.Drawing.Size(70, 17);
            this.LblProtokol.TabIndex = 20;
            this.LblProtokol.Text = "Protokol No:";
            // 
            // PnlTetkikler
            // 
            this.PnlTetkikler.Controls.Add(this.cbTetkikList);
            this.PnlTetkikler.Controls.Add(this.LblTetkik);
            this.PnlTetkikler.Location = new System.Drawing.Point(241, 329);
            this.PnlTetkikler.Name = "PnlTetkikler";
            this.PnlTetkikler.Size = new System.Drawing.Size(280, 274);
            this.PnlTetkikler.TabIndex = 46;
            // 
            // cbTetkikList
            // 
            this.cbTetkikList.BackColor = System.Drawing.SystemColors.Control;
            this.cbTetkikList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbTetkikList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbTetkikList.FormattingEnabled = true;
            this.cbTetkikList.Location = new System.Drawing.Point(3, 35);
            this.cbTetkikList.Name = "cbTetkikList";
            this.cbTetkikList.Size = new System.Drawing.Size(274, 238);
            this.cbTetkikList.TabIndex = 24;
            // 
            // LblTetkik
            // 
            this.LblTetkik.BackColor = System.Drawing.Color.Transparent;
            this.LblTetkik.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LblTetkik.Location = new System.Drawing.Point(115, 3);
            this.LblTetkik.Name = "LblTetkik";
            this.LblTetkik.Size = new System.Drawing.Size(54, 19);
            this.LblTetkik.TabIndex = 23;
            this.LblTetkik.Text = "Tetkikler";
            // 
            // PnlTani
            // 
            this.PnlTani.Controls.Add(this.lstselectedDiagnosis);
            this.PnlTani.Controls.Add(this.txtHastalikDetay);
            this.PnlTani.Controls.Add(this.cmbHastalikList);
            this.PnlTani.Controls.Add(this.LblHastalik);
            this.PnlTani.Location = new System.Drawing.Point(527, 329);
            this.PnlTani.Name = "PnlTani";
            this.PnlTani.Size = new System.Drawing.Size(367, 273);
            this.PnlTani.TabIndex = 47;
            // 
            // lstselectedDiagnosis
            // 
            this.lstselectedDiagnosis.FormattingEnabled = true;
            this.lstselectedDiagnosis.Location = new System.Drawing.Point(3, 76);
            this.lstselectedDiagnosis.Name = "lstselectedDiagnosis";
            this.lstselectedDiagnosis.Size = new System.Drawing.Size(361, 43);
            this.lstselectedDiagnosis.TabIndex = 30;
            // 
            // txtHastalikDetay
            // 
            this.txtHastalikDetay.BorderRadius = 5;
            this.txtHastalikDetay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastalikDetay.DefaultText = "Hastalık Detayını Giriniz";
            this.txtHastalikDetay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHastalikDetay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHastalikDetay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastalikDetay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastalikDetay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastalikDetay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHastalikDetay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastalikDetay.Location = new System.Drawing.Point(3, 131);
            this.txtHastalikDetay.Multiline = true;
            this.txtHastalikDetay.Name = "txtHastalikDetay";
            this.txtHastalikDetay.PasswordChar = '\0';
            this.txtHastalikDetay.PlaceholderText = "";
            this.txtHastalikDetay.SelectedText = "";
            this.txtHastalikDetay.Size = new System.Drawing.Size(361, 139);
            this.txtHastalikDetay.TabIndex = 28;
            // 
            // cmbHastalikList
            // 
            this.cmbHastalikList.AllowDrop = true;
            this.cmbHastalikList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHastalikList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbHastalikList.FormattingEnabled = true;
            this.cmbHastalikList.Location = new System.Drawing.Point(3, 35);
            this.cmbHastalikList.Name = "cmbHastalikList";
            this.cmbHastalikList.Size = new System.Drawing.Size(361, 25);
            this.cmbHastalikList.TabIndex = 27;
            this.cmbHastalikList.SelectedIndexChanged += new System.EventHandler(this.CmbHastlikList_SelectedIndexChanged);
            this.cmbHastalikList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbHastalikList_KeyDown);
            // 
            // LblHastalik
            // 
            this.LblHastalik.BackColor = System.Drawing.Color.Transparent;
            this.LblHastalik.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LblHastalik.Location = new System.Drawing.Point(169, 3);
            this.LblHastalik.Name = "LblHastalik";
            this.LblHastalik.Size = new System.Drawing.Size(28, 19);
            this.LblHastalik.TabIndex = 24;
            this.LblHastalik.Text = "Tanı";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pbSave);
            this.guna2Panel1.Controls.Add(this.LblHastaIslemleri);
            this.guna2Panel1.Location = new System.Drawing.Point(900, 329);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(280, 274);
            this.guna2Panel1.TabIndex = 48;
            // 
            // LblHastaIslemleri
            // 
            this.LblHastaIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.LblHastaIslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LblHastaIslemleri.Location = new System.Drawing.Point(79, 3);
            this.LblHastaIslemleri.Name = "LblHastaIslemleri";
            this.LblHastaIslemleri.Size = new System.Drawing.Size(121, 19);
            this.LblHastaIslemleri.TabIndex = 23;
            this.LblHastaIslemleri.Text = "Hızlı Hasta İşlemleri";
            // 
            // pbSave
            // 
            this.pbSave.Image = global::WinFormUI.Properties.Resources.save;
            this.pbSave.ImageRotate = 0F;
            this.pbSave.Location = new System.Drawing.Point(25, 35);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(64, 65);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 24;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // PctrBxCReturn
            // 
            this.PctrBxCReturn.Image = global::WinFormUI.Properties.Resources._return;
            this.PctrBxCReturn.ImageRotate = 0F;
            this.PctrBxCReturn.Location = new System.Drawing.Point(878, 3);
            this.PctrBxCReturn.Name = "PctrBxCReturn";
            this.PctrBxCReturn.Size = new System.Drawing.Size(25, 25);
            this.PctrBxCReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxCReturn.TabIndex = 49;
            this.PctrBxCReturn.TabStop = false;
            this.PctrBxCReturn.Click += new System.EventHandler(this.PctrBxCReturn_Click);
            // 
            // PctrBxClose
            // 
            this.PctrBxClose.Image = global::WinFormUI.Properties.Resources.multiply;
            this.PctrBxClose.ImageRotate = 0F;
            this.PctrBxClose.Location = new System.Drawing.Point(911, 4);
            this.PctrBxClose.Name = "PctrBxClose";
            this.PctrBxClose.Size = new System.Drawing.Size(25, 25);
            this.PctrBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxClose.TabIndex = 24;
            this.PctrBxClose.TabStop = false;
            this.PctrBxClose.Click += new System.EventHandler(this.PctrBxClose_Click);
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
            // frmMuayeneEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 606);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.PnlTani);
            this.Controls.Add(this.PnlTetkikler);
            this.Controls.Add(this.PnlUstBilgi);
            this.Controls.Add(this.PnlRecete);
            this.Controls.Add(this.PnlSikayetEkleme);
            this.Controls.Add(this.PnlHastaBilgi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMuayeneEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBilgiEkrani";
            this.Load += new System.EventHandler(this.frmMuayeneEkrani_Load);
            this.PnlHastaBilgi.ResumeLayout(false);
            this.PnlHastaBilgi.PerformLayout();
            this.PnlSikayetEkleme.ResumeLayout(false);
            this.PnlSikayetEkleme.PerformLayout();
            this.PnlRecete.ResumeLayout(false);
            this.PnlRecete.PerformLayout();
            this.PnlUstBilgi.ResumeLayout(false);
            this.PnlUstBilgi.PerformLayout();
            this.PnlTetkikler.ResumeLayout(false);
            this.PnlTetkikler.PerformLayout();
            this.PnlTani.ResumeLayout(false);
            this.PnlTani.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxCReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBoxHasta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmMuayeneEkraniElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmMuayeneEkraniDragControl;
        private Guna.UI2.WinForms.Guna2Panel PnlHastaBilgi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTcNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaDogumTarihi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaCinsiyet;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblIletisimNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaAdi;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBoxHasta;
        private Guna.UI2.WinForms.Guna2Panel PnlSikayetEkleme;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblSikayetEkleme;
        private Guna.UI2.WinForms.Guna2Panel PnlRecete;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblRecete;
        private Guna.UI2.WinForms.Guna2Panel PnlUstBilgi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblMuayeneTarihi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblMuayene;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblProtokolNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblProtokol;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxClose;
        private Guna.UI2.WinForms.Guna2TextBox TxtBxHastaSikayeti;
        private Guna.UI2.WinForms.Guna2Panel PnlTetkikler;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTetkik;
        private System.Windows.Forms.CheckedListBox cbTetkikList;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaIslemleri;
        private Guna.UI2.WinForms.Guna2Panel PnlTani;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastalik;
        private System.Windows.Forms.ComboBox cmbHastalikList;
        private Guna.UI2.WinForms.Guna2TextBox txtHastalikDetay;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxCReturn;
        private System.Windows.Forms.ComboBox cmbIlacList;
        private System.Windows.Forms.ListBox lstSelectedMedicines;
        private ListBox lstselectedDiagnosis;
        private Guna.UI2.WinForms.Guna2PictureBox pbSave;
    }
}