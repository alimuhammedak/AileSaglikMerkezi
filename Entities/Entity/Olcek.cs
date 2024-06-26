namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Olcek")]
    public partial class Olcek : Core.Entity.IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Olcek()
        {
            IlacOlceks = new HashSet<IlacOlcek>();
        }

        public int olcekID { get; set; }

        [Column("olcek")]
        public double? olcek1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlacOlcek> IlacOlceks { get; set; }
    }
}
