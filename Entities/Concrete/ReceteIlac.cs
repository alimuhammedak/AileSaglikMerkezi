namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceteIlac")]
    public partial class ReceteIlac
    {
        public int receteIlacID { get; set; }

        public int? ilacID { get; set; }

        public int? receteID { get; set; }

        public int? adet { get; set; }

        [StringLength(260)]
        public string notAciklama { get; set; }

        [StringLength(70)]
        public string kullanimTalimati { get; set; }

        public virtual Ilac Ilac { get; set; }

        public virtual Recete Recete { get; set; }
    }
}
