using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI.Forms;

namespace WinFormUI
{
    public partial class frmPersonelAnasayfa : Form
    {
        public frmPersonelAnasayfa()
        {
            InitializeComponent();
        }

        private void PctrBxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PctrBxHastaKayit_Click(object sender, EventArgs e)
        {
            frmHastaKayit frmHastaKayit = new frmHastaKayit();
            frmHastaKayit.Show();
            this.Hide();
        }

        private void PctrBxHastaCagirma_Click(object sender, EventArgs e)
        {
            frmMuayeneEkrani frmMuayeneEkrani = new frmMuayeneEkrani();
            frmMuayeneEkrani.Show();
            this.Hide();

        }

        private void PctrBxMuayeneEkrani_Click(object sender, EventArgs e)
        {
            frmDoktorHastaCagirma frmDoktorHastaCagirma = new frmDoktorHastaCagirma();
            frmDoktorHastaCagirma.Show();
            this.Hide();

            
        }

        private void PctrBxRapor_Click(object sender, EventArgs e)
        {
            frmRapor frmRapor = new frmRapor();
            frmRapor.Show();
            this.Hide();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
