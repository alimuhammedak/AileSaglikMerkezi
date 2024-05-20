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
        private readonly ITahlilService _tahlilService;
        private readonly IHastalikService _hastalikService;
        private readonly IResimYolService _resimYolService;
        private readonly IReceteService _receteService;
        private readonly IReceteIlacService _receteIlacService;
        private readonly IHastaHastalikService _hastaHastalikService;
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
            _tahlilService = InstanceFactory.GetInstance<ITahlilService>();
            _resimYolService = InstanceFactory.GetInstance<IResimYolService>();
            _hastaService = InstanceFactory.GetInstance<IHastaService>();
            _receteService = InstanceFactory.GetInstance<IReceteService>();
            _receteIlacService = InstanceFactory.GetInstance<IReceteIlacService>();
            _hastaHastalikService = InstanceFactory.GetInstance<IHastaHastalikService>();

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
            Program.HastaKayit = _hastaKayitService.GetById(_hasta.HastaKayitID.Value).Data;

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

        private void pbSave_Click(object sender, EventArgs e)
        {
            SaveRecete();
            SaveDiagnosis();
            SaveTetkikler();
            SaveSikayet();
            MessageBox.Show("Tanılar başarıyla kaydedildi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var frm = new frmDoktorAnasayfa();
            frm.Show();
            this.Close();
        }

        private void SaveSikayet()
        {
            Program.HastaKayit.sikayet = TxtBxHastaSikayeti.Text;
            var result = _hastaKayitService.Update(Program.HastaKayit);
        }

        private void SaveTetkikler()
        {
            try
            {
                var hastaKayitID = _hasta.HastaKayitID.Value;
                var birimID = new Random().Next(1, 20);

                foreach (var selectedItem in cbTetkikList.CheckedItems)
                {
                    var tetkik = _tetkikService.GetByName(selectedItem.ToString()).Data;

                    Tahlil tahlil = new Tahlil
                    {
                        hastaKayitID = hastaKayitID,
                        tetkikID = tetkik.tetkikID,
                        istekTarih = DateTime.Now,
                        kabulTarih = DateTime.Now,
                        onayTarih = DateTime.Now,
                        sonuc = 0, // Başlangıç değeri olarak 0 giriyoruz
                        referansDeger = 0, // Başlangıç değeri olarak 0 giriyoruz
                        birimID = birimID
                    };

                    var result = _tahlilService.Add(tahlil);
                    if (!result.IsSuccess)
                    {
                        MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tetkikler kaydedilirken bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveRecete()
        {
            try
            {
                #region Reçete oluştur
                var receteNo = ReceteNumarasiOlustur();
                Recete createdRecete = new Recete
                {
                    receteNo = receteNo
                };
                // Recete tablosuna ekle
                _receteService.Add(createdRecete);
                #endregion

                #region Recete ilaç tablosuna ilaçları ekle
                var recete = _receteService.GetByReceteNo(receteNo).Data;

                foreach (var selectedMedicine in selectedMedicines)
                {
                    // İlaç adından ilaç ID'sini bulma
                    var ilac = _ilacService.GetByName(selectedMedicine).Data;
                    if (ilac != null)
                    {
                        ReceteIlac receteIlac = new ReceteIlac
                        {
                            ilacID = ilac.ilacID,
                            receteID = recete.receteID,
                            adet = 1, // Bu değeri ihtiyacınıza göre ayarlayın
                            notAciklama = "", // Bu değeri ihtiyacınıza göre ayarlayın
                            kullanimTalimati = "" // Bu değeri ihtiyacınıza göre ayarlayın
                        };
                        _receteIlacService.Add(receteIlac);
                    }
                    else
                    {
                        MessageBox.Show($"İlaç bulunamadı: {selectedMedicine}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveDiagnosis()
        {
            try
            {
                var hasta = _hastaService.GetByIdentityNumber(LblTcNo.Text).Data;

                foreach (var selectedDiagnosis in lstselectedDiagnosis.Items)
                {
                    var hastalik = _hastalikService.GetByName(selectedDiagnosis.ToString()).Data;

                    HastaHastalik hastaHastalik = new HastaHastalik
                    {
                        hastalikID = hastalik.hastalikID,
                        hastaID = hasta.hastaID,
                        taniTarih = DateTime.Now,
                        aktifMi = true
                    };

                    var result = _hastaHastalikService.Add(hastaHastalik);
                    if (!result.IsSuccess)
                    {
                        MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tanılar kaydedilirken bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string ReceteNumarasiOlustur()
        {
            // Yeni bir GUID oluşturur ve ilk 8 karakterini alır
            return Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        }


    }
}
