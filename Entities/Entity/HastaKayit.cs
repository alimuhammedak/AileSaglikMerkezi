namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HastaKayit")]
    public partial class HastaKayit : Core.Entity.IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HastaKayit()
        {
            HastaKayitDetay = new HashSet<HastaKayitDetay>();
            Tahlil = new HashSet<Tahlil>();
        }

        public int hastaKayitID { get; set; }

        public int? doktorID { get; set; }

        public int? personelID { get; set; }

        public int? hemsireID { get; set; }

        public int? hastaID { get; set; }

        public int? receteID { get; set; }

        public int? raporID { get; set; }

        [StringLength(25)]
        public string protokolNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? kayitTarih { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? taburcuTarih { get; set; }

        public int? hastaSira { get; set; }

        public bool? aktifMi { get; set; }

        public virtual Doktor Doktor { get; set; }

        public virtual Hasta Hasta { get; set; }

        public virtual Hemsire Hemsire { get; set; }

        public virtual Personel Personel { get; set; }

        public virtual Rapor Rapor { get; set; }

        public virtual Recete Recete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaKayitDetay> HastaKayitDetay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tahlil> Tahlil { get; set; }
    }
}
