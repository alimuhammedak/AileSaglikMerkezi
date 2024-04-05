namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HastaKayitDetay")]
    public partial class HastaKayitDetay
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int hastaKayitDetayID { get; set; }

        public decimal? ates { get; set; }

        public int? nabiz { get; set; }

        [StringLength(10)]
        public string sysNabizUst { get; set; }

        [StringLength(10)]
        public string diaNabizAlt { get; set; }

        public int? bmi { get; set; }

        public string sikayet { get; set; }

        public virtual HastaKayit HastaKayit { get; set; }
    }
}
