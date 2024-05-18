using Business.Abstract;
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
    public partial class frmHastaCagirma : Form
    {
        private readonly IHastaKayitService _hastaKayitService;
        public frmHastaCagirma()
        {
            InitializeComponent();
            _hastaKayitService = InstanceFactory.GetInstance<IHastaKayitService>();

        }

        private void frmHastaCagirma_Load(object sender, EventArgs e)
        {
            var result = _hastaKayitService.GetAllHastaCagirmaByDoktorID(152);
            DataGwHastaSirasi.DataSource = result.Data;
            DataGwHastaSirasi.Columns["Doktor"].Visible = false;
            DataGwHastaSirasi.Columns["K"].Visible = false;

            LblDoktorAdi.Text = result.Data.Select(k => k.Kullanici + " " + k.Kullanici.soyad).FirstOrDefault();

            LblHastaAdi.Text = result.Data.Select(h => h.HastaAd + " " + h.HastaSoyad).FirstOrDefault();

            LblRandevuSaati.Text = result.Data.Select(h => h.HastaSira.Value.ToString()).FirstOrDefault();

            LblTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void PctrBxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PctrBxCReturn_Click(object sender, EventArgs e)
        {
            frmDoktorAnasayfa frmAnaSayfa = new frmDoktorAnasayfa();
            frmAnaSayfa.Show();
            this.Hide();
        }

        
    }
}
