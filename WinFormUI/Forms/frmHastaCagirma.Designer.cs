namespace WinFormUI.Forms
{
    partial class frmHastaCagirma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.frmHastaCagirmaElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmHastaCagirmaDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PnlDoktorBilgi = new Guna.UI2.WinForms.Guna2Panel();
            this.LblDoktorAdi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblTarih = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PnlHastaBilgi = new Guna.UI2.WinForms.Guna2Panel();
            this.PnlHastaDetay = new Guna.UI2.WinForms.Guna2Panel();
            this.LblHastaAdi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblRandevuSaati = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DataGwHastaSirasi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PnlDoktorBilgi.SuspendLayout();
            this.PnlHastaBilgi.SuspendLayout();
            this.PnlHastaDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGwHastaSirasi)).BeginInit();
            this.SuspendLayout();
            // 
            // frmHastaCagirmaDragControl
            // 
            this.frmHastaCagirmaDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmHastaCagirmaDragControl.UseTransparentDrag = true;
            // 
            // PnlDoktorBilgi
            // 
            this.PnlDoktorBilgi.Controls.Add(this.LblTarih);
            this.PnlDoktorBilgi.Controls.Add(this.LblDoktorAdi);
            this.PnlDoktorBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDoktorBilgi.Location = new System.Drawing.Point(0, 0);
            this.PnlDoktorBilgi.Name = "PnlDoktorBilgi";
            this.PnlDoktorBilgi.Size = new System.Drawing.Size(1182, 100);
            this.PnlDoktorBilgi.TabIndex = 0;
            // 
            // LblDoktorAdi
            // 
            this.LblDoktorAdi.BackColor = System.Drawing.Color.Transparent;
            this.LblDoktorAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblDoktorAdi.Location = new System.Drawing.Point(26, 39);
            this.LblDoktorAdi.Name = "LblDoktorAdi";
            this.LblDoktorAdi.Size = new System.Drawing.Size(90, 23);
            this.LblDoktorAdi.TabIndex = 18;
            this.LblDoktorAdi.Text = "Doktor Adı:";
            // 
            // LblTarih
            // 
            this.LblTarih.BackColor = System.Drawing.Color.Transparent;
            this.LblTarih.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblTarih.Location = new System.Drawing.Point(968, 39);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(15, 23);
            this.LblTarih.TabIndex = 19;
            this.LblTarih.Text = "...";
            // 
            // PnlHastaBilgi
            // 
            this.PnlHastaBilgi.Controls.Add(this.LblRandevuSaati);
            this.PnlHastaBilgi.Controls.Add(this.LblHastaAdi);
            this.PnlHastaBilgi.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlHastaBilgi.Location = new System.Drawing.Point(0, 100);
            this.PnlHastaBilgi.Name = "PnlHastaBilgi";
            this.PnlHastaBilgi.Size = new System.Drawing.Size(467, 460);
            this.PnlHastaBilgi.TabIndex = 1;
            // 
            // PnlHastaDetay
            // 
            this.PnlHastaDetay.Controls.Add(this.DataGwHastaSirasi);
            this.PnlHastaDetay.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlHastaDetay.Location = new System.Drawing.Point(473, 100);
            this.PnlHastaDetay.Name = "PnlHastaDetay";
            this.PnlHastaDetay.Size = new System.Drawing.Size(709, 460);
            this.PnlHastaDetay.TabIndex = 2;
            // 
            // LblHastaAdi
            // 
            this.LblHastaAdi.BackColor = System.Drawing.Color.Transparent;
            this.LblHastaAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LblHastaAdi.Location = new System.Drawing.Point(26, 21);
            this.LblHastaAdi.Name = "LblHastaAdi";
            this.LblHastaAdi.Size = new System.Drawing.Size(104, 27);
            this.LblHastaAdi.TabIndex = 19;
            this.LblHastaAdi.Text = "HASTA ADI";
            // 
            // LblRandevuSaati
            // 
            this.LblRandevuSaati.BackColor = System.Drawing.Color.Transparent;
            this.LblRandevuSaati.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LblRandevuSaati.Location = new System.Drawing.Point(210, 355);
            this.LblRandevuSaati.Name = "LblRandevuSaati";
            this.LblRandevuSaati.Size = new System.Drawing.Size(18, 27);
            this.LblRandevuSaati.TabIndex = 20;
            this.LblRandevuSaati.Text = "...";
            // 
            // DataGwHastaSirasi
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGwHastaSirasi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGwHastaSirasi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGwHastaSirasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGwHastaSirasi.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGwHastaSirasi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGwHastaSirasi.Location = new System.Drawing.Point(3, 52);
            this.DataGwHastaSirasi.Name = "DataGwHastaSirasi";
            this.DataGwHastaSirasi.RowHeadersVisible = false;
            this.DataGwHastaSirasi.Size = new System.Drawing.Size(694, 373);
            this.DataGwHastaSirasi.TabIndex = 0;
            this.DataGwHastaSirasi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGwHastaSirasi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGwHastaSirasi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGwHastaSirasi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGwHastaSirasi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGwHastaSirasi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGwHastaSirasi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGwHastaSirasi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGwHastaSirasi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGwHastaSirasi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGwHastaSirasi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGwHastaSirasi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGwHastaSirasi.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGwHastaSirasi.ThemeStyle.ReadOnly = false;
            this.DataGwHastaSirasi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGwHastaSirasi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGwHastaSirasi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGwHastaSirasi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGwHastaSirasi.ThemeStyle.RowsStyle.Height = 22;
            this.DataGwHastaSirasi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGwHastaSirasi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmHastaCagirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 560);
            this.Controls.Add(this.PnlHastaDetay);
            this.Controls.Add(this.PnlHastaBilgi);
            this.Controls.Add(this.PnlDoktorBilgi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHastaCagirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHastaCagirma";
            this.PnlDoktorBilgi.ResumeLayout(false);
            this.PnlDoktorBilgi.PerformLayout();
            this.PnlHastaBilgi.ResumeLayout(false);
            this.PnlHastaBilgi.PerformLayout();
            this.PnlHastaDetay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGwHastaSirasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmHastaCagirmaElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmHastaCagirmaDragControl;
        private Guna.UI2.WinForms.Guna2Panel PnlDoktorBilgi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTarih;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDoktorAdi;
        private Guna.UI2.WinForms.Guna2Panel PnlHastaBilgi;
        private Guna.UI2.WinForms.Guna2Panel PnlHastaDetay;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHastaAdi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblRandevuSaati;
        private Guna.UI2.WinForms.Guna2DataGridView DataGwHastaSirasi;
    }
}