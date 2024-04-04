namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tani")]
    public partial class Tani
    {
        public int taniID { get; set; }

        public int? hastaID { get; set; }
    }
}
