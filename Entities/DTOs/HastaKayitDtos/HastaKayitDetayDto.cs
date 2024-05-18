using Core.Entity;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class HastaKayitDetayDto : IDto
    {
        public HastaKayit HastaKayit { get; set; }
        public Kullanici Kullanici { get; set; }
        public Doktor Doktor { get; set; }
        public Hasta Hasta { get; set; }
        public Hemsire Hemsire { get; set; }
    }
}
