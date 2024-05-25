using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class DoktorDto:IDto
    {
        public int doktorID { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string unvan { get; set; }
    }
}
