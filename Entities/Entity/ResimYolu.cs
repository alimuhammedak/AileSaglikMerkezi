namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResimYolu")]
    public partial class ResimYolu : Core.Entity.IEntity
    {
        public int resimYoluID { get; set; }

        [StringLength(700)]
        public string yol { get; set; }

        public int? kullaniciID { get; set; }

        public int? hastaID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tarih { get; set; }

        public virtual Hasta Hasta { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
