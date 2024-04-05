namespace Entities.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tahlil")]
    public partial class Tahlil
    {
        public int tahlilID { get; set; }

        public int? hastaKayitID { get; set; }

        public int? tetkikID { get; set; }

        public int? doktorID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? istekTarih { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? kabulTarih { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? onayTarih { get; set; }

        public decimal? sonuc { get; set; }

        public decimal? referansDeger { get; set; }

        public int? birimID { get; set; }

        public virtual Doktor Doktor { get; set; }

        public virtual HastaKayit HastaKayit { get; set; }

        public virtual TahlilBirim TahlilBirim { get; set; }

        public virtual TahlilTur TahlilTur { get; set; }

        public virtual Tetkik Tetkik { get; set; }
    }
}
