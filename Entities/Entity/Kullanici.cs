namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici : Core.Entity.IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            Doktors = new HashSet<Doktor>();
            Hemsires = new HashSet<Hemsire>();
            Personels = new HashSet<Personel>();
            ResimYolus = new HashSet<ResimYolu>();
        }

        public int kullaniciID { get; set; }

        public int? yetkiID { get; set; }

        [StringLength(50)]
        public string identityNumber { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string soyad { get; set; }

        [StringLength(20)]
        public string telefonNo { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        [StringLength(50)]
        public string kullaniciAd { get; set; }

        [StringLength(50)]
        public string passwordHash { get; set; }

        [StringLength(50)]
        public string passwordSalt { get; set; }

        [StringLength(500)]
        public string adres { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dogumTarih { get; set; }

        public bool? aktifMi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doktor> Doktors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hemsire> Hemsires { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personel> Personels { get; set; }

        public virtual Yetki Yetki { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResimYolu> ResimYolus { get; set; }
    }
}
