using Entities.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class HastaCagirmaDto
    {
        [DisplayName("Doktor Ad")]
        public string DoktorAdi { get; set; }
        public int DoktorID { get; set; }
        [DisplayName("Unvan")]
        public string DoktorUnvan { get; set; }
        public int? HastaKayitID { get; set; }
        [DisplayName("Hasta Ad")]
        public string HastaAd { get; set; }

        [DisplayName("Dogum Tarih")]
        public DateTime? DogumTarih { get; set; }
        public string Cinsiyet { get; set; }
        [DisplayName("Hasta Soyad")]
        public string HastaSoyad { get; set; }
        [DisplayName("Hasta TC")]
        public string HastaTc { get; set; }
        [DisplayName("Sıra No")]
        public int? HastaSira { get; set; }
        [DisplayName("İletişim No")]
        public string IletisimNo { get; set; }
        [DisplayName("Kayıt Tarih")]
        public DateTime? HastaKayitTarih { get; set; }
    }
}
