namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HastaHastalik")]
    public partial class HastaHastalik
    {
        public int hastaHastalikID { get; set; }

        public int? hastalikID { get; set; }

        public int? hastaID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? taniTarih { get; set; }

        public bool? aktifMi { get; set; }

        public string hastalikTani { get; set; }

        public virtual Hasta Hasta { get; set; }

        public virtual Hastalik Hastalik { get; set; }
    }
}
