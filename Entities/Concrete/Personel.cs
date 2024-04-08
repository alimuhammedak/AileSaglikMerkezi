using Core.Entity;

namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personel")]
    public partial class Personel:IEntity
    {
        public int personelID { get; set; }

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

        public string adres { get; set; }

        public virtual Doktor Doktor { get; set; }

        public virtual Hemsire Hemsire { get; set; }
    }
}
