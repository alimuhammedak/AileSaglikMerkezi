using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Core.Utilities.Result;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
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
    public partial class frmHastaKayit : Form
    {
        private readonly IHastaKayitService _hastaKayitService;
        public frmHastaKayit()
        {
            InitializeComponent();
            _hastaKayitService = InstanceFactory.GetInstance<IHastaKayitService>();
        }


        private void frmHastaKayit_Load(object sender, EventArgs e)
        {
            LblKayitTarihi.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //var propertiesToHide = new string[]
            //    {
            //        "Cinsiyet",
            //        "HastaDetays",
            //        "HastaHastaliks",
            //        "HastaIlacRapors",
            //        "HastaKayits",
            //        "HastaYakins",
            //        "HastaYakins1",
            //            "adresID",
            //            "cinsiyetID",
            //    };

            string tc = TxtBxTcNo.Text;

            // HastaKayitDetayDto listesi döndüren GetAllHastaKayitDetayByTc metodunu çağır
            var result = _hastaKayitService.GetAllHastaKayitDetay();


            DataGwHastaKayit.DataSource = result.Data.Select(s => s.Hasta.ad).ToList();
            //foreach (var propertyName in propertiesToHide)
            //{
            //    DataGwHastaKayit.Columns[propertyName].Visible = false;
            //}
            var doktorBilgileri = result.Data.Select(s => new { Ad = s }).ToList();
            DataGwDoktorBilgisi.DataSource = doktorBilgileri;

        }
        private void DataGwHastaKayit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tıklanan satırın indeksi -1 ise (başlık satırı) veya geçersiz bir sütunda tıklanmışsa işlem yapma
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;

            // Tıklanan satırı DataGridView'den al
            DataGridViewRow selectedRow = DataGwHastaKayit.Rows[e.RowIndex];

            // Tıklanan satırın bağlı olduğu veri nesnesini al
            var selectedHasta = (Hasta)selectedRow.DataBoundItem;

            // Seçilen hastanın bilgilerini kullanabilirsiniz
            // Örnek olarak, MessageBox ile hasta adını gösterelim
            //LblHastaAdi.Text = selectedHasta.ad;
            //LblHastaSoyadi.Text = selectedHasta.soyad;
            //LblHastaAdresi.Text = selectedHasta.adres;
            //LblHastaDogumTarihi.Text = selectedHasta.dogumTarih.ToString();
            //LblHastaCinsiyet.Text = selectedHasta.Cinsiyet.ad;
            //LblCocukSayisi.Text = "Çocuk Sayısı: " + new Random().Next(1, 5).ToString();
            //LblEvliMi.Text = "Medeni Durumu: " + (new Random().Next(0, 2) == 1 ? "Evli" : "Bekar");
        }

        private void PnlHastaKayit_Paint(object sender, PaintEventArgs e)
        {

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

        private void DataGwHastaKayit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGwHastaKayit_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtBxTcNo_TextChanged(object sender, EventArgs e)
        {

            var propertiesToHide = new string[]
                {
                    "Cinsiyet",
                    "HastaDetays",
                    "HastaHastaliks",
                    "HastaIlacRapors",
                    "HastaKayits",
                    "HastaYakins",
                    "HastaYakins1",
                        "adresID",
                        "cinsiyetID",
                };
            string tc = TxtBxTcNo.Text;
            IDataResult<List<HastaKayitDetayDto>> result;
            if (tc == null)
            {
                result = _hastaKayitService.GetAllHastaKayitDetay();
            }
            else { result = _hastaKayitService.GetAllHastaKayitDetayByTc(tc); }
            // HastaKayitDetayDto listesi döndüren GetAllHastaKayitDetayByTc metodunu çağır



            DataGwHastaKayit.DataSource = result.Data.Select(s => s.Hasta).ToList();
            foreach (var propertyName in propertiesToHide)
            {
                DataGwHastaKayit.Columns[propertyName].Visible = false;
            }
        }

        private void LblHastaAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
