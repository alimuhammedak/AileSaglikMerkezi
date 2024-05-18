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
    public partial class frmDoktorAnasayfa : Form
    {
        public frmDoktorAnasayfa()
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
            this.Close();
        }

        private void PctrBxHastaCagirma_Click(object sender, EventArgs e)
        {
            frmMuayeneEkrani frmMuayeneEkrani = new frmMuayeneEkrani();
            frmMuayeneEkrani.Show();
            this.Close();

        }

        private void PctrBxMuayeneEkrani_Click(object sender, EventArgs e)
        {
            frmDoktorHastaCagirma frmDoktorHastaCagirma = new frmDoktorHastaCagirma();
            frmDoktorHastaCagirma.Show();
            this.Close();

            
        }

        private void PctrBxRapor_Click(object sender, EventArgs e)
        {
            frmRapor frmRapor = new frmRapor();
            frmRapor.Show();
            this.Close();
        }

        private void PctrBxMuayeneSira_Click(object sender, EventArgs e)
        {
            var frm = new frmHastaCagirma();
            frm.Show();
            this.Close();
        }

        private void PctrBxHastaListe_Click(object sender, EventArgs e)
        {
            var frm = new frmDoktorHastaListe();
            frm.Show();
            this.Close();
        }
    }
}
