namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IlacOlcek")]
    public partial class IlacOlcek
    {
        public int ilacOlcekID { get; set; }

        public int? ilacID { get; set; }

        public int? olcekID { get; set; }

        public virtual Ilac Ilac { get; set; }

        public virtual Olcek Olcek { get; set; }
    }
}
