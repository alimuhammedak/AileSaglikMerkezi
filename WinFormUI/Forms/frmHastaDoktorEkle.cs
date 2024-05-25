using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Business.DependencyResolvers.AutoMapper;
using Core.Mapper;
using Core.Utilities.Result;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using Entities.DTOs.DoktorHastaListeDtos;
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
    public partial class frmHastaDoktorEkle : Form
    {
        private readonly IHastaKayitService _hastaKayitService;
        private readonly IHastaService _hastaService;
        private readonly IResimYolService _resimYolService;
        private readonly IDoktorService _doktorService;
        private DoktorDto _selectedDoktor; // Seçilen doktoru saklamak için
        private HastaListeDto _selectedHasta;
        public frmHastaDoktorEkle()
        {
            InitializeComponent();
            _hastaKayitService = InstanceFactory.GetInstance<IHastaKayitService>();
            _hastaService = InstanceFactory.GetInstance<IHastaService>();
            _resimYolService = InstanceFactory.GetInstance<IResimYolService>();
            _doktorService = InstanceFactory.GetInstance<IDoktorService>();
        }


        private void frmHastaKayit_Load(object sender, EventArgs e)
        {
            LblKayitTarihi.Text = DateTime.Now.ToString("dd/MM/yyyy");
            var result = _hastaService.GetAllList();
            LblProtokolNo.Text = _hastaKayitService.GetAll().Data.First().protokolNo;

            DataGwHastaKayit.DataSource = result.Data;

            var doktorResult = _doktorService.GetAllKayit(); // Tüm doktorları getir

            DataGwDoktorBilgisi.DataSource = doktorResult.Data; // DataGridView'e ata
        }

        private void SelectDoktor(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;

            DataGridViewRow selectedRow = DataGwDoktorBilgisi.Rows[e.RowIndex];
            _selectedDoktor = (DoktorDto)selectedRow.DataBoundItem;
        }

        private void DataGwHastaKayit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectHasta(sender, e);
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
            _selectedHasta = selectedHasta;

        }

        private void PctrBxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PctrBxCReturn_Click(object sender, EventArgs e)
        {
            var frmAnaSayfa = new frmPersonelAnasayfa();
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

        private void BtnHastaKayit_Click(object sender, EventArgs e)
        {
            if (_selectedHasta != null && _selectedDoktor != null)
            {
                var hastaKayit = new HastaKayit
                {
                    hastaID = _selectedHasta.hastaID,
                    doktorID = _selectedDoktor.doktorID,
                    kayitTarih = DateTime.Now,
                    protokolNo = _hastaKayitService.GenerateProtokolNo() // Örnek protokol no üretimi
                };

                var result = _hastaKayitService.Add(hastaKayit);

                if (result.IsSuccess)
                {
                    MessageBox.Show("Kayıt başarıyla oluşturuldu.");
                }
                else
                {
                    MessageBox.Show("Kayıt oluşturulurken hata oluştu: " + result.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir hasta ve doktor seçin.");
            }
        }

        private void DataGwDoktorBilgisi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SelectDoktor(sender, e);
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            var frmAnaSayfa = new frmPersonelAnasayfa();
            frmAnaSayfa.Show();
            this.Hide();
        }
    }
}
