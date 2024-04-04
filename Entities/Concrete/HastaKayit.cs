namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HastaKayit")]
    public partial class HastaKayit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HastaKayit()
        {
            Tahlils = new HashSet<Tahlil>();
        }

        public int hastaKayitID { get; set; }

        public int? doktorID { get; set; }

        public int? hemsireID { get; set; }

        public int? hastaID { get; set; }

        public int? receteID { get; set; }

        [StringLength(25)]
        public string protokolNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? kayitTarih { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? taburcuTarih { get; set; }

        public int? raporID { get; set; }

        public virtual Doktor Doktor { get; set; }

        public virtual Hasta Hasta { get; set; }

        public virtual HastaKayitDetay HastaKayitDetay { get; set; }

        public virtual Hemsire Hemsire { get; set; }

        public virtual Rapor Rapor { get; set; }

        public virtual Recete Recete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tahlil> Tahlils { get; set; }
    }
}
