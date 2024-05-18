namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hemsire")]
    public partial class Hemsire : Core.Entity.IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hemsire()
        {
            HastaKayit = new HashSet<HastaKayit>();
        }

        public int hemsireID { get; set; }

        public int? kullaniciID { get; set; }

        [StringLength(10)]
        public string diplomaNo { get; set; }

        public int? odaID { get; set; }

        public int? saglikOcakID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaKayit> HastaKayit { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual SaglikOcak SaglikOcak { get; set; }
    }
}
