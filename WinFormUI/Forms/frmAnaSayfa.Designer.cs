﻿namespace WinFormUI
{
    partial class frmAnaSayfa
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
            this.frmAnaSayfaElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmAnaSayfaDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // frmAnaSayfaDragControl
            // 
            this.frmAnaSayfaDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmAnaSayfaDragControl.UseTransparentDrag = true;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.Location = new System.Drawing.Point(55, 35);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(3, 2);
            this.lblUser.TabIndex = 0;
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 560);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnaSayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmAnaSayfaElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmAnaSayfaDragControl;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUser;
    }
}