namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hastalik")]
    public partial class Hastalik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hastalik()
        {
            HastaHastaliks = new HashSet<HastaHastalik>();
            HastaIlacRapors = new HashSet<HastaIlacRapor>();
        }

        public int hastalikID { get; set; }

        [StringLength(250)]
        public string ad { get; set; }

        public bool? kronikMi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaHastalik> HastaHastaliks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaIlacRapor> HastaIlacRapors { get; set; }
    }
}
