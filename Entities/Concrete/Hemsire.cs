namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hemsire")]
    public partial class Hemsire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hemsire()
        {
            HastaKayits = new HashSet<HastaKayit>();
        }

        public int hemsireID { get; set; }

        public int? diplomaNo { get; set; }

        public int? odaID { get; set; }

        public int? saglikOcakID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaKayit> HastaKayits { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
