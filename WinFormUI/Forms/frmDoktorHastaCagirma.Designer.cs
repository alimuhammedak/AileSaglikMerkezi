namespace WinFormUI.Forms
{
    partial class frmDoktorHastaCagirma
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
            this.frmDoktorHastaCagirmaElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmDoktorHastaCagirmaDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PnlHastaCagirma = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.PnlHastaSiraListesi = new Guna.UI2.WinForms.Guna2Panel();
            this.LblSifreSifirlama = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PctrBxClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PnlHastaCagirma.SuspendLayout();
            this.PnlHastaSiraListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // frmDoktorHastaCagirmaDragControl
            // 
            this.frmDoktorHastaCagirmaDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmDoktorHastaCagirmaDragControl.UseTransparentDrag = true;
            // 
            // PnlHastaCagirma
            // 
            this.PnlHastaCagirma.Controls.Add(this.PctrBxClose);
            this.PnlHastaCagirma.Controls.Add(this.guna2PictureBox1);
            this.PnlHastaCagirma.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlHastaCagirma.Location = new System.Drawing.Point(715, 0);
            this.PnlHastaCagirma.Name = "PnlHastaCagirma";
            this.PnlHastaCagirma.Size = new System.Drawing.Size(467, 560);
            this.PnlHastaCagirma.TabIndex = 0;
            // 
            // PnlHastaSiraListesi
            // 
            this.PnlHastaSiraListesi.Controls.Add(this.LblSifreSifirlama);
            this.PnlHastaSiraListesi.Controls.Add(this.guna2DataGridView1);
            this.PnlHastaSiraListesi.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlHastaSiraListesi.Location = new System.Drawing.Point(0, 0);
            this.PnlHastaSiraListesi.Name = "PnlHastaSiraListesi";
            this.PnlHastaSiraListesi.Size = new System.Drawing.Size(709, 560);
            this.PnlHastaSiraListesi.TabIndex = 1;
            // 
            // LblSifreSifirlama
            // 
            this.LblSifreSifirlama.BackColor = System.Drawing.Color.Transparent;
            this.LblSifreSifirlama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblSifreSifirlama.Location = new System.Drawing.Point(272, 35);
            this.LblSifreSifirlama.Name = "LblSifreSifirlama";
            this.LblSifreSifirlama.Size = new System.Drawing.Size(130, 23);
            this.LblSifreSifirlama.TabIndex = 22;
            this.LblSifreSifirlama.Text = "Hasta Sıra Listesi";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(12, 91);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(694, 445);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::WinFormUI.Properties.Resources.ORTALI_LOGO_TÜRKÇE;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(467, 560);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // PctrBxClose
            // 
            this.PctrBxClose.Image = global::WinFormUI.Properties.Resources.Multiply;
            this.PctrBxClose.ImageRotate = 0F;
            this.PctrBxClose.Location = new System.Drawing.Point(419, 3);
            this.PctrBxClose.Name = "PctrBxClose";
            this.PctrBxClose.Size = new System.Drawing.Size(45, 45);
            this.PctrBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxClose.TabIndex = 23;
            this.PctrBxClose.TabStop = false;
            // 
            // frmDoktorHastaCagirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 560);
            this.Controls.Add(this.PnlHastaSiraListesi);
            this.Controls.Add(this.PnlHastaCagirma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoktorHastaCagirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoktorHastaCagirma";
            this.PnlHastaCagirma.ResumeLayout(false);
            this.PnlHastaSiraListesi.ResumeLayout(false);
            this.PnlHastaSiraListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmDoktorHastaCagirmaElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmDoktorHastaCagirmaDragControl;
        private Guna.UI2.WinForms.Guna2GradientPanel PnlHastaCagirma;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel PnlHastaSiraListesi;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblSifreSifirlama;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxClose;
    }
}