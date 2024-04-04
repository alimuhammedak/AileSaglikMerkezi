namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mahalle")]
    public partial class Mahalle
    {
        [Key]
        public int mahalledID { get; set; }

        public int? ilceID { get; set; }

        [StringLength(100)]
        public string ad { get; set; }

        public virtual Ilce Ilce { get; set; }
    }
}
