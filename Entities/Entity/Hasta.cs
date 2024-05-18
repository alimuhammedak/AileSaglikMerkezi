namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hasta")]
    public partial class Hasta : Core.Entity.IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hasta()
        {
            HastaDetay = new HashSet<HastaDetay>();
            HastaHastalik = new HashSet<HastaHastalik>();
            HastaIlacRapor = new HashSet<HastaIlacRapor>();
            HastaKayit = new HashSet<HastaKayit>();
        }

        public int hastaID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string soyad { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(20)]
        public string sosyalGuvenlikNo { get; set; }

        [StringLength(20)]
        public string identityNumber { get; set; }

        [StringLength(15)]
        public string iletisimNo { get; set; }

        public int? cinsiyetID { get; set; }

        [StringLength(50)]
        public string dogumYer { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dogumTarih { get; set; }

        [StringLength(50)]
        public string adres { get; set; }

        public virtual Cinsiyet Cinsiyet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaDetay> HastaDetay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaHastalik> HastaHastalik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaIlacRapor> HastaIlacRapor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaKayit> HastaKayit { get; set; }
    }
}
