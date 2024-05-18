using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Business.DependencyResolvers.AutoMapper;
using Core.Mapper;
using Entities.DTOs;
using Entities.DTOs.HastaCagirmaDtos;
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
            var result = _hastaKayitService.GetAllHastaCagirmaByDoktorID(Program.Doktor.doktorID);

            #region Mapper Config
            var mapperConfiguration = new AutoMapperConfiguration();
            var mapper = mapperConfiguration.Configure(new MappingProfile());
            var resultHasta = mapper.Map<List<HastaCagirmaDto>, List<HastaCagirmaHastaDto>>(result.Data);
            #endregion

            DataGwHastaSirasi.DataSource = resultHasta;

            lblDoktor.Text = result.Data.Select(h => h.DoktorUnvan + " DR. " + h.DoktorAdi).FirstOrDefault();
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
            this.Close();
        }


    }
}
