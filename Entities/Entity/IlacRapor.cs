namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IlacRapor")]
    public partial class IlacRapor : Core.Entity.IEntity
    {
        public int ilacRaporID { get; set; }

        public int? ilacID { get; set; }

        public int? hastaRaporID { get; set; }

        public virtual Ilac Ilac { get; set; }
    }
}
