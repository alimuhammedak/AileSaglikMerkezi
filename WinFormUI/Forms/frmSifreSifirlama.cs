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
    public partial class frmSifreSifirlama : Form
    {
        public frmSifreSifirlama()
        {
            InitializeComponent();
        }

        private void TxtBxYeniSfr_TextChanged(object sender, EventArgs e)
        {

        }

        private void PctrBxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
