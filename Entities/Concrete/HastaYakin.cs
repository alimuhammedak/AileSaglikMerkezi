namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HastaYakin")]
    public partial class HastaYakin
    {
        public int hastaYakinID { get; set; }

        public int? hastaID { get; set; }

        public int? yakinID { get; set; }

        public int? yakinlikDereceID { get; set; }

        public virtual Hasta Hasta { get; set; }

        public virtual Hasta Hasta1 { get; set; }

        public virtual HastaYakinlikDerece HastaYakinlikDerece { get; set; }
    }
}
