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
            frmHastaDoktorEkle frmHastaKayit = new frmHastaDoktorEkle();
            frmHastaKayit.Show();
            this.Close();
        }

        private void PctrBxHastaCagirma_Click(object sender, EventArgs e)
        {
            var frm = new frmYeniKayit();
            frm.Show();
            this.Close();

        }

        private void PctrBxRapor_Click(object sender, EventArgs e)
        {
            frmRapor frmRapor = new frmRapor();
            frmRapor.Show();
            this.Close();
        }

        private void PctrBxHastaKayit_Click_1(object sender, EventArgs e)
        {
            var frm = new frmHastaDoktorEkle();
            frm.Show();
            this.Close();
        }

        private void PctrBxKayitListesi_Click(object sender, EventArgs e)
        {
            var frm = new frmHastaListe();
            frm.Show();
            this.Close();
        }
    }
}
