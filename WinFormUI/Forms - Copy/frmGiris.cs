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
        IKullaniciService _kullaniciService;
        IDoktorService _doktorService;
        IPersonelService _personelService;
        public frmGiris()
        {
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            _doktorService = InstanceFactory.GetInstance<IDoktorService>();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
            InitializeComponent();
        }

        private void pctrBxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var result = _kullaniciService.GetByUserNameAndPassword(txtKullanici.Text, txtSifre.Text);
            if (!result.IsSuccess)
            {
                ErrorMessages(result.Message);
                ResetTextBoxs();
                return;
            }
            else if(result.Data.yetkiID == 2)
            {
                Program.Kullanici = result.Data;
                Program.Doktor = _doktorService.GetByKullaniciId(Program.Kullanici.kullaniciID).Data;
                ShowForm(new frmDoktorAnasayfa());
            }
            else if(result.Data.yetkiID == 4)
            {
                Program.Kullanici = result.Data;
                Program.Personel = _personelService.GetByKullaniciId(Program.Kullanici.kullaniciID).Data;
                ShowForm(new frmPersonelAnasayfa());
            }
            
            
        }

        private void ResetTextBoxs()
        {
            txtKullanici.Clear();
            txtSifre.Clear();
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

        private void btnSfrUntm_Click(object sender, EventArgs e)
        {
            ShowForm(new frmSifreSifirlama());
        }
    }
}
