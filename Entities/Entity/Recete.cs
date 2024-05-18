namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recete")]
    public partial class Recete : Core.Entity.IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recete()
        {
            HastaKayit = new HashSet<HastaKayit>();
            ReceteIlac = new HashSet<ReceteIlac>();
        }

        public int receteID { get; set; }

        [StringLength(15)]
        public string receteNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? verilisTarih { get; set; }

        public bool? gecerliMi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaKayit> HastaKayit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceteIlac> ReceteIlac { get; set; }
    }
}
