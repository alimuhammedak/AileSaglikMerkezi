namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rapor")]
    public partial class Rapor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rapor()
        {
            HastaKayits = new HashSet<HastaKayit>();
        }

        public int raporID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? kayitTarih { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? baslangicTarih { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? bitisTarih { get; set; }

        public string aciklama { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaKayit> HastaKayits { get; set; }
    }
}
