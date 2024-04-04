namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HastaIlacRapor")]
    public partial class HastaIlacRapor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HastaIlacRapor()
        {
            IlacRapors = new HashSet<IlacRapor>();
        }

        public int HastaIlacRaporID { get; set; }

        public int? hastaID { get; set; }

        public bool? kronikHastalikMi { get; set; }

        public int? doktorID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? verilisTarih { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? gecerlilikTarih { get; set; }

        public int? hastalikID { get; set; }

        public virtual Doktor Doktor { get; set; }

        public virtual Hasta Hasta { get; set; }

        public virtual Hastalik Hastalik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlacRapor> IlacRapors { get; set; }
    }
}
