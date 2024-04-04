namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HastaDoktor")]
    public partial class HastaDoktor
    {
        public int hastaDoktorID { get; set; }

        public int? hastaID { get; set; }

        public int? doktorID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? kayitTarih { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ayrilmaTarih { get; set; }

        public bool? aktifMi { get; set; }

        public virtual Doktor Doktor { get; set; }
    }
}
