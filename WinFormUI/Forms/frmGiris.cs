using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Core.Utilities.Result;
using WinFormUI.Forms;

namespace WinFormUI
{
    public partial class frmGiris : Form
    {
        IPersonelService _personelService;
        public frmGiris()
        {
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
            InitializeComponent();
        }

        private void PctrBxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var result = _personelService.GetByUserNameAndPassword(txtKullaniciAdi.Text, txtSifre.Text);
            if (!result.IsSuccess)
            {
                ErrorMessages(result.Message);
                ResetTextBoxs();
                return;
            }
            Program.personel = result.Data;
            ShowForm(new frmAnaSayfa());
        }

        private void ResetTextBoxs()
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }
        private void btnSifreSifirlama_Click(object sender, EventArgs e)
        {
            ShowForm(new frmSifreSifirlama());
        }

        private void ErrorMessages(string message)
        {
            lblUyariMesaj.Text = message;
            lblUyariMesaj.Visible = true;
        }

        private void ShowForm(Form form)
        {
            var frmAnaSayfa = form;
            frmAnaSayfa.Show();
            this.Hide();
        }

    }
}
