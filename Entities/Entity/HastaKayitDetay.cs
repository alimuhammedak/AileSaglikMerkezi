namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HastaKayitDetay")]
    public partial class HastaKayitDetay : Core.Entity.IEntity
    {
        public int hastaKayitDetayID { get; set; }

        public int? hastaKayitID { get; set; }

        public double? ates { get; set; }

        public int? nabiz { get; set; }

        public int? sysNabizUst { get; set; }

        public int? diaNabizAlt { get; set; }

        public double? bmi { get; set; }
        public virtual HastaKayit HastaKayit { get; set; }
    }
}
