namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HastaDetay")]
    public partial class HastaDetay : Core.Entity.IEntity
    {
        public int hastaDetayID { get; set; }

        public int? hastaID { get; set; }

        public bool? sigaraKullaniyorMu { get; set; }

        public bool? alkolKullaniyorMu { get; set; }

        public bool? uyusturucuKullanıyorMu { get; set; }

        public virtual Hasta Hasta { get; set; }
    }
}
