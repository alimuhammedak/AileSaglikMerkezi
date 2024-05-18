namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HastaIlacRapor")]
    public partial class HastaIlacRapor : Core.Entity.IEntity
    {
        public int HastaIlacRaporID { get; set; }

        public int? hastaID { get; set; }

        public bool? kronikHastalikMi { get; set; }

        public int? doktorID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? verilisTarih { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? gecerlilikTarih { get; set; }

        public int? hastalikID { get; set; }

        public virtual Doktor Doktor { get; set; }

        public virtual Hasta Hasta { get; set; }

        public virtual Hastalik Hastalik { get; set; }
    }
}
