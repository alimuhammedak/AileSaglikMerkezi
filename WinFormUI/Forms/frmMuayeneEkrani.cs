using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Business.DependencyResolvers.AutoMapper;
using Core.Mapper;
using Entities.DTOs.HastaCagirmaDtos;
using Entities.DTOs;
using Entities.Entity;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormUI.Forms
{
    public partial class frmMuayeneEkrani : Form
    {
        //private readonly IHastaService _hastaService;
        private readonly IHastaKayitService _hastaKayitService;
        private readonly IHastaService _hastaService;
        private readonly IIlacService _ilacService;
        private readonly ITetkikService _tetkikService;
        private readonly IHastalikService _hastalikService;
        private readonly IResimYolService _resimYolService;
        private HastaCagirmaDto _hasta;
        private List<string> tetkikList;
        private List<string> taniList;
        private List<string> ilacList;
        private List<string> selectedMedicines;
        private List<string> selectedDiagnosis;
        

        public frmMuayeneEkrani()
        {
            InitializeComponent();
            //_hastaService = InstanceFactory.GetInstance<IHastaService>();
            _hastaKayitService = InstanceFactory.GetInstance<IHastaKayitService>();
            _ilacService = InstanceFactory.GetInstance<IIlacService>();
            _hastalikService = InstanceFactory.GetInstance<IHastalikService>();
            _tetkikService = InstanceFactory.GetInstance<ITetkikService>();
            _resimYolService = InstanceFactory.GetInstance<IResimYolService>();
            _hastaService = InstanceFactory.GetInstance<IHastaService>();


            selectedMedicines = new List<string>();
            selectedDiagnosis = new List<string>();
        }

        private void frmMuayeneEkrani_Load(object sender, EventArgs e)
        {

            VeriCekme();
            MuayeneLabelLoad();
            #region AutoComplete için kaynak oluşturma
            var IlacAutoCompleteCollection = new AutoCompleteStringCollection();
            IlacAutoCompleteCollection.AddRange(ilacList.ToArray());
            cmbIlacList.AutoCompleteCustomSource = IlacAutoCompleteCollection;

            var TaniAutoCompleteCollection = new AutoCompleteStringCollection();
            TaniAutoCompleteCollection.AddRange(taniList.ToArray());
            cmbHastalikList.AutoCompleteCustomSource = TaniAutoCompleteCollection;
            #endregion
            ComboBoxAddData();            
        }

        private void ComboBoxAddData()
        {
            cmbIlacList.Items.AddRange(ilacList.ToArray());
            cmbHastalikList.Items.AddRange(taniList.ToArray());
            cbTetkikList.Items.AddRange(tetkikList.ToArray());
        }

        private void VeriCekme()
        {
            ilacList = _ilacService.GetAll().Data.Select(ilac => ilac.ad).ToList();
            taniList = _hastalikService.GetAll().Data.Select(hastalik => hastalik.ad).ToList();
            tetkikList = _tetkikService.GetAll().Data.Select(tetkik => tetkik.ad).ToList();
            _hasta = _hastaKayitService.GetAllHastaCagirmaByDoktorIDToDay(Program.Doktor.doktorID).Data.First();
        }

        private void MuayeneLabelLoad()
        {
            LblMuayeneTarihi.Text = DateTime.Now.ToString("yyyy/MM/dd");
            LblProtokolNo.Text = _hastaKayitService.GetById(_hasta.HastaKayitID.Value).Data.protokolNo.ToString();
            LblHastaAdi.Text = _hasta.HastaAd.ToString() + " " + _hasta.HastaSoyad.ToString();
            LblTcNo.Text = _hasta.HastaTc.ToString();
            LblIletisimNo.Text = _hasta.IletisimNo.ToString();
            LblHastaDogumTarihi.Text = _hasta.DogumTarih.Value.ToString("yyyy/MM/dd");
            LblHastaCinsiyet.Text = _hasta.Cinsiyet.ToString();

            var hasta = _hastaService.GetByIdentityNumber(_hasta.HastaTc).Data;
            var resimYol = _resimYolService.GetByHastaID(hasta.hastaID).Data;

            PctrBoxHasta.Image = Image.FromFile($"C:\\silinecekProjeler\\AileSaglikVize\\AileSaglikMerkezi\\WinFormUI\\Images\\{resimYol.yol}.jpg");
            PctrBoxHasta.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CmbIlacList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen ilacı ekle
            if (cmbIlacList.SelectedItem != null)
            {
                string selectedMedicine = cmbIlacList.SelectedItem.ToString();
                if (!selectedMedicines.Contains(selectedMedicine))
                {
                    selectedMedicines.Add(selectedMedicine);
                    lstSelectedMedicines.Items.Add(selectedMedicine);

                    // Seçimden sonra ComboBox'ı temizleyin
                    cmbIlacList.SelectedIndex = -1;
                    cmbIlacList.Text = string.Empty;
                }
            }
        }

        private void CmbIlacList_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter tuşuna basıldığında seçimi gerçekleştir
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter tuşunun ComboBox'da işlem yapmasını engelle
                if (cmbIlacList.SelectedItem == null && cmbIlacList.Text.Length > 0)
                {
                    // Eğer seçilen bir öğe yoksa ve yazılan metin varsa, ilk öneriyi seç
                    var firstSuggestion = ilacList.FirstOrDefault(m => m.StartsWith(cmbIlacList.Text, StringComparison.InvariantCultureIgnoreCase));
                    if (firstSuggestion != null)
                    {
                        cmbIlacList.SelectedItem = firstSuggestion;
                    }
                }
            }
        }

        private void CmbHastlikList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen hastalığı ekle
            if (cmbHastalikList.SelectedItem != null)
            {
                string selectedDiagnos = cmbHastalikList.SelectedItem.ToString();
                if (!selectedDiagnosis.Contains(selectedDiagnos))
                {
                    selectedDiagnosis.Add(selectedDiagnos);
                    lstselectedDiagnosis.Items.Add(selectedDiagnos);

                    // Seçimden sonra ComboBox'ı temizleyin
                    cmbHastalikList.SelectedIndex = -1;
                    cmbHastalikList.Text = string.Empty;
                }
            }
        }

        private void CmbHastalikList_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter tuşuna basıldığında seçimi gerçekleştir
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter tuşunun ComboBox'da işlem yapmasını engelle
                if (cmbHastalikList.SelectedItem == null && cmbHastalikList.Text.Length > 0)
                {
                    // Eğer seçilen bir öğe yoksa ve yazılan metin varsa, ilk öneriyi seç
                    var firstSuggestion = taniList.FirstOrDefault(m => m.StartsWith(cmbHastalikList.Text, StringComparison.InvariantCultureIgnoreCase));
                    if (firstSuggestion != null)
                    {
                        cmbHastalikList.SelectedItem = firstSuggestion;
                    }
                }
            }
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
