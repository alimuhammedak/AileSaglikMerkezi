using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.DoktorHastaListeDtos
{
    public class HastaListeDto
    {
        public int hastaID { get; set; }

        public string ad { get; set; }

        public string soyad { get; set; }

        public string sosyalGuvenlikNo { get; set; }

        public string identityNumber { get; set; }

        public string iletisimNo { get; set; }

        public string cinsiyet { get; set; }

        public string dogumYer { get; set; }

        public string adres { get; set; }

        public string email { get; set; }

        public DateTime? dogumTarih { get; set; }
    }
}
