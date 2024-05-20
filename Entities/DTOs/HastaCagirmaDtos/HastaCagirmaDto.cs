using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class HastaCagirmaDto
    {
        public string DoktorAdi { get; set; }
        public int DoktorID { get; set; }
        public string  DoktorUnvan { get; set; }
        public int? HastaKayitID { get; set; }
        public string HastaAd { get; set; }
        public DateTime? DogumTarih { get; set; }
        public string Cinsiyet { get; set; }
        public string HastaSoyad { get; set; }
        public string HastaTc { get; set; }
        public int? HastaSira { get; set; }
        public string IletisimNo { get; set; }
        public DateTime? HastaKayitTarih { get; set; }
    }
}
