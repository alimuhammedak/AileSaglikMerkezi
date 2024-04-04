namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sikayet")]
    public partial class Sikayet
    {
        public int sikayetID { get; set; }

        [StringLength(10)]
        public string kodu { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? yayinTarih { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string soyad { get; set; }

        [StringLength(50)]
        public string telefon { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public int? sikayetTurID { get; set; }

        public string konu { get; set; }

        public virtual SikayetTur SikayetTur { get; set; }
    }
}
