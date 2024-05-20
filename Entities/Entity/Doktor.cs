namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doktor")]
    public partial class Doktor : Core.Entity.IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doktor()
        {
            HastaIlacRapors = new HashSet<HastaIlacRapor>();
            HastaKayits = new HashSet<HastaKayit>();
        }

        public int doktorID { get; set; }

        public int? kullaniciID { get; set; }

        [StringLength(20)]
        public string diplomaNo { get; set; }

        public int? odaID { get; set; }

        public int? unvanID { get; set; }

        public int? saglikOcakID { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Oda Oda { get; set; }

        public virtual SaglikOcak SaglikOcak { get; set; }

        public virtual Unvan Unvan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaIlacRapor> HastaIlacRapors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaKayit> HastaKayits { get; set; }
    }
}
