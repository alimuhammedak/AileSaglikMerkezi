using AutoMapper;
using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Business.DependencyResolvers.AutoMapper;
using Core.Entity;
using Core.Mapper;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using Entities.DTOs.DoktorHastaListeDtos;
using Entities.DTOs.HastaCagirmaDtos;
using Entities.DTOs.HastaKayitDtos;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI.Forms
{
    public partial class frmDoktorHastaListe : Form
    {
        private readonly IHastaKayitService _hastaKayitService;
        private readonly IHastaService _hastaService;
        private readonly IResimYolService _resimYolService;

        public frmDoktorHastaListe()
        {
            InitializeComponent();
            _hastaKayitService = InstanceFactory.GetInstance<IHastaKayitService>();
            _hastaService = InstanceFactory.GetInstance<IHastaService>();
            _resimYolService = InstanceFactory.GetInstance<IResimYolService>();

        }
        private void frmHastaKayit_Load(object sender, EventArgs e)
        {
            LblKayitTarihi.Text = DateTime.Now.ToString("dd/MM/yyyy");
            var result = _hastaService.GetAllList();
            LblProtokolNo.Text = _hastaKayitService.GetAll().Data.First().protokolNo;

            DataGwHastaKayit.DataSource = result.Data;

            HastaGoster(result.Data.First());
        }
        private void DataGwHastaKayit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectHasta(sender,e);
            
        }

       

        private void SelectHasta(object sender, DataGridViewCellEventArgs e)
        {
            // Tıklanan satırın indeksi -1 ise (başlık satırı) veya geçersiz bir sütunda tıklanmışsa işlem yapma
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;

            // Tıklanan satırı DataGridView'den al
            DataGridViewRow selectedRow = DataGwHastaKayit.Rows[e.RowIndex];
            // Tıklanan satırın bağlı olduğu veri nesnesini al
            var selectedHasta = (HastaListeDto)selectedRow.DataBoundItem;
            HastaGoster(selectedHasta);
            
            HastaKayitGoster(selectedHasta.identityNumber);
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
        private void TxtBxTcNo_TextChanged(object sender, EventArgs e)
        {
            string tc = TxtBxTcNo.Text;
            List<HastaListeDto> result;
            if (tc == null || tc == "")
            {
                result = _hastaService.GetAllList().Data;
            }
            else { result = _hastaService.GetListByIdentityNumber(tc).Data; }
           
            DataGwHastaKayit.DataSource = result;
        }
        private void HastaKayitGoster(string tc)
        {
            var result = _hastaKayitService.GetHastaCagirmaKayitDetayByTc(tc);
            dgvHastaKayit.DataSource = result.Data;
        }
        private void HastaGoster(HastaListeDto hasta)
        {
            var resimYol = _resimYolService.GetByHastaID(hasta.hastaID).Data;

            PctrBoxHasta.Image = Image.FromFile($"C:\\silinecekProjeler\\AileSaglikVize\\AileSaglikMerkezi\\WinFormUI\\Images\\{resimYol.yol}.jpg");
            PctrBoxHasta.SizeMode = PictureBoxSizeMode.StretchImage;
            lblHastaAdSoyad.Text = hasta.ad + " " + hasta.soyad;
            lblIdentityNumber.Text = hasta.identityNumber;
            lblDogumTarih.Text = hasta.dogumTarih?.ToString("dd/MM/yyyy");
            lblCinsiyet.Text = hasta.cinsiyet;
            lblEmail.Text = hasta.email;
            lblDogumYer.Text = hasta.dogumYer;

            lblIletisim.Text = hasta.iletisimNo;
            lblAdres.Text = hasta.adres;
        }
    }
}
