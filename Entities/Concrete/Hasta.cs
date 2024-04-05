using Core.Entity;

namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hasta")]
    public partial class Hasta:IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hasta()
        {
            HastaHastaliks = new HashSet<HastaHastalik>();
            HastaIlacRapors = new HashSet<HastaIlacRapor>();
            HastaKayits = new HashSet<HastaKayit>();
            HastaYakins = new HashSet<HastaYakin>();
            HastaYakins1 = new HashSet<HastaYakin>();
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

        public int? adresID { get; set; }

        public int? cinsiyetID { get; set; }

        [StringLength(50)]
        public string dogumYer { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dogumTarih { get; set; }

        public string adres { get; set; }

        [StringLength(50)]
        public string ulke { get; set; }

        public virtual Cinsiyet Cinsiyet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaHastalik> HastaHastaliks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaIlacRapor> HastaIlacRapors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaKayit> HastaKayits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaYakin> HastaYakins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaYakin> HastaYakins1 { get; set; }
    }
}
