using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Core.Utilities.Result;
using Entities.DTOs;
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
    public partial class frmDoktorHastaCagirma : Form
    {
        private readonly IHastaKayitService _hastaKayitService;
        private readonly IDoktorService _doktorService;
        public frmDoktorHastaCagirma()
        {
            InitializeComponent();
            _hastaKayitService = InstanceFactory.GetInstance<IHastaKayitService>();
            _doktorService = InstanceFactory.GetInstance<IDoktorService>();
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

        private void frmDoktorHastaCagirma_Load(object sender, EventArgs e)
        {
            var doktor = _doktorService.GetByKullaniciId(Program.Kullanici.kullaniciID).Data;
            var result = _hastaKayitService.GetAllHastaCagirmaByDoktorID(doktor.doktorID);
            dgvHastaListe.DataSource = result.Data;
            dgvHastaListe.Columns["Doktor"].Visible = false;
            dgvHastaListe.Columns["Kullanici"].Visible = false;

            //LblDoktorAdi.Text = result.Data.Select(p => p.Personel.ad + " " + p.Personel.soyad).FirstOrDefault();

            LblHastaAdi.Text = result.Data.Select(h => h.HastaAd + " " + h.HastaSoyad).FirstOrDefault();
            LblHastaTc.Text = result.Data.Select(h => h.HastaTc).FirstOrDefault();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

        }

        private void LblSifreSifirlama_Click(object sender, EventArgs e)
        {

        }

        private void BtnHastaCagir_Click(object sender, EventArgs e)
        { 
            // DataGridView'de ilk satırı alın
            DataGridViewRow firstRow = dgvHastaListe.Rows[0];

            // İlk satırın bağlı olduğu HastaCagirmaDto nesnesini alın
            HastaCagirmaDto hastaCagirma = firstRow.DataBoundItem as HastaCagirmaDto;

            var hastaKayit = _hastaKayitService.GetById(hastaCagirma.HastaKayitID.Value).Data;
            hastaKayit.aktifMi = false;
            _hastaKayitService.Update(hastaKayit);

            //var result = _hastaKayitService.GetAllHastaCagirmaByDoktorID(152);
            //dgvHastaListe.DataSource = result.Data;

            //DataUpload();
            DataGridViewRow nextRow = dgvHastaListe.Rows[0];
            HastaCagirmaDto nextHasta = nextRow.DataBoundItem as HastaCagirmaDto;
            LblHastaAdi.Text = nextHasta.HastaAd + " " + nextHasta.HastaSoyad;
            LblHastaTc.Text = nextHasta.HastaTc;
            //LblHastaAdi.Text = result.Data.Select(h => h.HastaAd + " " + h.HastaSoyad).FirstOrDefault();
            //LblHastaTc.Text = result.Data.Select(h => h.HastaTc).FirstOrDefault();
        }

        //private void DataUpload()
        //{

        //}
    }
}
