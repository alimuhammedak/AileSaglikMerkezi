using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Business.DependencyResolvers.AutoMapper;
using Core.Mapper;
using Core.Utilities.Result;
using Entities.DTOs;
using Entities.DTOs.HastaCagirmaDtos;
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
        BindingList<HastaCagirmaHastaDto> hastaListesi;

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
            //var doktor = _doktorService.GetByKullaniciId(Program.Kullanici.kullaniciID).Data;
            var result = _hastaKayitService.GetAllHastaCagirmaByDoktorID(Program.Doktor.doktorID);

            #region Mapper Config
            var mapperConfiguration = new AutoMapperConfiguration();
            var mapper = mapperConfiguration.Configure(new MappingProfile());
            var resultHasta = mapper.Map<List<HastaCagirmaDto>, List<HastaCagirmaHastaDto>>(result.Data);
            #endregion

            hastaListesi = new BindingList<HastaCagirmaHastaDto>(resultHasta);
            dgvHastaListe.DataSource = hastaListesi;
            //lblDoktor.Text = result.Data.Select(h => h.DoktorUnvan + " DR. " + h.DoktorAdi).FirstOrDefault();
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
            if (hastaListesi.Count > 0)
            {
                // İlk satırı alın
                var hastaCagirma = hastaListesi[0];

                if (hastaCagirma != null)
                {
                    // Hasta kaydını güncelle
                    var hastaKayit = _hastaKayitService.GetByIdentityNumber(hastaCagirma.HastaTc).Data;
                    hastaKayit.aktifMi = false;
                    _hastaKayitService.Update(hastaKayit);

                    // BindingList'ten ilk satırı kaldır
                    hastaListesi.RemoveAt(0);

                    // Eğer hala satır varsa, ilk satırdaki bilgileri alıp label'ları güncelleyin
                    if (hastaListesi.Count > 0)
                    {
                        var nextHasta = hastaListesi[0];
                        if (nextHasta != null)
                        {
                            LblHastaAdi.Text = nextHasta.HastaAd + " " + nextHasta.HastaSoyad;
                            LblHastaTc.Text = nextHasta.HastaTc;
                        }
                    }
                    else
                    {
                        // DataGridView boşsa, label'ları temizleyin
                        LblHastaAdi.Text = string.Empty;
                        LblHastaTc.Text = string.Empty;
                    }
                }
            }
        }


        //private void DataUpload()
        //{

        //}
    }
}
