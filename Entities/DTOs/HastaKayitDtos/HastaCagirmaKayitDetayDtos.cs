using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.HastaKayitDtos
{
    public class HastaCagirmaKayitDetayDtos : IDto
    {
        public int? HastaKayitID { get; set; }
        public int DoktorID { get; set; }
        public string DoktorUnvan { get; set; }
        public string DoktorAdi { get; set; }
        public string KayitTarih { get; set; }
        public string HastaAd { get; set; }
        public string HastaTc { get; set; }
    }
}
