using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Core.Entity;
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
    public partial class frmSifreGirme : Form
    {
        Kullanici _kullanici;
        IKullaniciService _kullaniciService;
        public frmSifreGirme(Kullanici entity)
        {
            InitializeComponent();
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            _kullanici = entity;
        }

        private void PctrBxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSifreSifirlama_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor. Lütfen Kontrol Ediniz!","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                _kullanici.passwordSalt = txtSifre.Text;
                var result = _kullaniciService.Update(_kullanici);
                if (result.IsSuccess)
                {
                    MessageBox.Show(result.Message,"Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var frm = new frmGiris();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
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
