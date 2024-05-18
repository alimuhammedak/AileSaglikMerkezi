using Business.Abstract;
using Business.DependencyResolvers.Autofac;
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
        private readonly IHastaService _hastaService;
        public frmMuayeneEkrani()
        {
            InitializeComponent();
            _hastaService = InstanceFactory.GetInstance<IHastaService>();
        }

        private void frmMuayeneEkrani_Load(object sender, EventArgs e)
        {

        }

        private void PctrBxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxHastalik_SelectedIndexChanged(object sender, EventArgs e)
        {
            string arananMetin = comboBoxHastalik.Text.ToLower();

            // ComboBox içindeki öğeler arasında dolaşarak arama yap
            for (int i = 0; i < comboBoxHastalik.Items.Count; i++)
            {
                string item = comboBoxHastalik.Items[i].ToString().ToLower();
                if (item.Contains(arananMetin))
                {
                    comboBoxHastalik.SelectedIndex = i; // Bulunan öğeyi seçili hale getir
                    return;
                }
            }
            comboBoxHastalik.SelectedIndex = -1;
        }

        private void PctrBxCReturn_Click(object sender, EventArgs e)
        {
            frmDoktorAnasayfa frmAnaSayfa = new frmDoktorAnasayfa();
            frmAnaSayfa.Show();
            this.Hide();
        }
    }
}
