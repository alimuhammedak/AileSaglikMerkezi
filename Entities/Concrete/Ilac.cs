using Core.Entity;
namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ilac")]

    public partial class Ilac:IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ilac()
        {
            IlacOlceks = new HashSet<IlacOlcek>();
            ReceteIlacs = new HashSet<ReceteIlac>();
        }

        public int ilacID { get; set; }

        [StringLength(13)]
        public string barkod { get; set; }

        [StringLength(200)]
        public string ad { get; set; }

        public int? tedarikciID { get; set; }

        public int? receteTurID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? kayitTarih { get; set; }

        public string prospektus { get; set; }

        [StringLength(200)]
        public string kullanimTalimati { get; set; }

        public virtual ReceteTur ReceteTur { get; set; }

        public virtual Tedarikci Tedarikci { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlacOlcek> IlacOlceks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceteIlac> ReceteIlacs { get; set; }
    }
}
