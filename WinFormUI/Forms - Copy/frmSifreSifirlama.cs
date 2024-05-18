using Business.Abstract;
using Business.DependencyResolvers.Autofac;
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

            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
        }

        private void PctrBxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSifreSifirlama_Click(object sender, EventArgs e)
        {
            var result = _kullaniciService.GetByUserPasswordReset(TxtBxTcNo.Text, TxtBxAdi.Text, TxtBxSoyadi.Text, dtSfDogumTarih.Value);
            if (result.IsSuccess)
            {

                //var kullanici = _kullaniciService.GetById(Convert.ToInt32(TxtBxTcNo.Text));
                //kullanici.Data.passwordSalt = 
            }
        }

        private void btnHatirladim_Click(object sender, EventArgs e)
        {
            var frm = new frmGiris();
            frm.Show();
            this.Close();
        }

        private void PnlAciklama_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
