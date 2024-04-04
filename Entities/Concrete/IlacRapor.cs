namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IlacRapor")]
    public partial class IlacRapor
    {
        public int ilacRaporID { get; set; }

        public int? ilacID { get; set; }

        public int? hastaRaporID { get; set; }

        public virtual HastaIlacRapor HastaIlacRapor { get; set; }
    }
}
