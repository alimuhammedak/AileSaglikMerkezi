using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class frmAnaSayfa : Form
    {
        IPersonelService _personelService;
        public frmAnaSayfa()
        {
            InitializeComponent();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
        }

    
        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            if (_personelService != null)
            {
                lblUser.Text = Program.personel.ad + " " + Program.personel.passwordSalt;

                var result = _personelService.GetAll();
                dgvPersonel.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show("Personel servisi null olarak atanmış.");
            }
        }
    }
}
