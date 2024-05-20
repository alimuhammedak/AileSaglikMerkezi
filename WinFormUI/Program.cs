using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI.Forms;

namespace WinFormUI
{
    public static class Program
    {
        public static HastaKayit HastaKayit { get; set; }
        public static Kullanici Kullanici { get; set; }
        public static Doktor Doktor { get; set; }
        public static Personel Personel { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmGiris());
        }
    }
}
