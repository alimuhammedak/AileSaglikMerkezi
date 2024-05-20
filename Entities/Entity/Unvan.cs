namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Unvan")]
    public partial class Unvan : Core.Entity.IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unvan()
        {
            Doktors = new HashSet<Doktor>();
        }

        public int unvanID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? olusturulmaTarih { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doktor> Doktors { get; set; }
    }
}
