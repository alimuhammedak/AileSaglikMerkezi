﻿using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI.Forms
{
    public partial class frmSifreSifirlama : Form
    {
        IKullaniciService _kullaniciService;

        public frmSifreSifirlama()
        {
            InitializeComponent();
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();

        }

        private void PctrBxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSifreSifirlama_Click(object sender, EventArgs e)
        {
            // Tarih bilgisini al
            DateTime selectedBirthDate = dtSfDogumTarih.Value.Date;

            // Tarihi string olarak formatla
            string onlyDate = selectedBirthDate.ToString("yyyy-MM-dd");

            // İhtiyaç halinde string tarihi tekrar DateTime'a dönüştür
            DateTime dateOnly = DateTime.Parse(onlyDate);

            var result = _kullaniciService.GetByUserPasswordReset(TxtBxTcNo.Text, TxtBxAdi.Text, TxtBxSoyadi.Text, dateOnly);
            if (result.IsSuccess)
            {
                var kullanici = _kullaniciService.GetByIdentityNumber(TxtBxTcNo.Text);
                var frm = new frmSifreGirme(kullanici.Data);
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnHatirladim_Click(object sender, EventArgs e)
        {
            var frm = new frmGiris();
            frm.Show();
            this.Close();
        }
    }
}
