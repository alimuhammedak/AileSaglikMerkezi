using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.HastaKayitDtos
{
    public class HastaCagirmaKayitDetayDtos : IDto
    {
        public int? HastaKayitID { get; set; }
        public int DoktorID { get; set; }

        [DisplayName("Unvan")]
        public string DoktorUnvan { get; set; }
        [DisplayName("Doktor Ad")]
        public string DoktorAdi { get; set; }
        [DisplayName("Kayıt Tarih")]
        public string KayitTarih { get; set; }
        [DisplayName("Hasta Ad")]
        public string HastaAd { get; set; }
        [DisplayName("Hasta TC")]
        public string HastaTc { get; set; }
    }
}
