namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HastaDetay")]
    public partial class HastaDetay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int hastaID { get; set; }

        public bool? sigaraKullaniyorMu { get; set; }

        public bool? alkolKullaniyorMu { get; set; }

        public bool? uyusturucuKullanıyorMu { get; set; }
    }
}
