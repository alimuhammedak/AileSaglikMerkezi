using Entities.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public partial class SODBContext : DbContext
    {
        public SODBContext()
            : base("name=SODBContext")
        {
        }

        public virtual DbSet<Cinsiyet> Cinsiyet { get; set; }
        public virtual DbSet<Doktor> Doktor { get; set; }
        public virtual DbSet<Hasta> Hasta { get; set; }
        public virtual DbSet<HastaDetay> HastaDetay { get; set; }
        public virtual DbSet<HastaHastalik> HastaHastalik { get; set; }
        public virtual DbSet<HastaIlacRapor> HastaIlacRapor { get; set; }
        public virtual DbSet<HastaKayit> HastaKayit { get; set; }
        public virtual DbSet<HastaKayitDetay> HastaKayitDetay { get; set; }
        public virtual DbSet<Hastalik> Hastalik { get; set; }
        public virtual DbSet<Hemsire> Hemsire { get; set; }
        public virtual DbSet<Ilac> Ilac { get; set; }
        public virtual DbSet<IlacOlcek> IlacOlcek { get; set; }
        public virtual DbSet<IlacRapor> IlacRapor { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Oda> Oda { get; set; }
        public virtual DbSet<Olcek> Olcek { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Rapor> Rapor { get; set; }
        public virtual DbSet<Recete> Recete { get; set; }
        public virtual DbSet<ReceteIlac> ReceteIlac { get; set; }
        public virtual DbSet<ReceteTur> ReceteTur { get; set; }
        public virtual DbSet<SaglikOcak> SaglikOcak { get; set; }
        public virtual DbSet<Sikayet> Sikayet { get; set; }
        public virtual DbSet<SikayetTur> SikayetTur { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tahlil> Tahlil { get; set; }
        public virtual DbSet<TahlilBirim> TahlilBirim { get; set; }
        public virtual DbSet<TahlilTur> TahlilTur { get; set; }
        public virtual DbSet<Tedarikci> Tedarikci { get; set; }
        public virtual DbSet<Tetkik> Tetkik { get; set; }
        public virtual DbSet<Unvan> Unvan { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doktor>()
                .Property(e => e.diplomaNo)
                .IsUnicode(false);

            modelBuilder.Entity<Hasta>()
                .Property(e => e.sosyalGuvenlikNo)
                .IsUnicode(false);

            modelBuilder.Entity<Hasta>()
                .Property(e => e.identityNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Hasta>()
                .Property(e => e.iletisimNo)
                .IsUnicode(false);

            modelBuilder.Entity<HastaKayit>()
                .Property(e => e.protokolNo)
                .IsFixedLength();

            modelBuilder.Entity<Hemsire>()
                .Property(e => e.diplomaNo)
                .IsFixedLength();

            modelBuilder.Entity<Ilac>()
                .Property(e => e.barkod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.telefonNo)
                .IsUnicode(false);

            modelBuilder.Entity<Recete>()
                .Property(e => e.receteNo)
                .IsUnicode(false);

            modelBuilder.Entity<ReceteTur>()
                .HasMany(e => e.Ilac)
                .WithOptional(e => e.ReceteTur)
                .HasForeignKey(e => e.receteTurID);

            modelBuilder.Entity<Sikayet>()
                .Property(e => e.kodu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sikayet>()
                .Property(e => e.telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Tahlil>()
                .Property(e => e.sonuc)
                .HasPrecision(3, 2);

            modelBuilder.Entity<Tahlil>()
                .Property(e => e.referansDeger)
                .HasPrecision(3, 2);

            modelBuilder.Entity<TahlilBirim>()
                .HasMany(e => e.Tahlil)
                .WithOptional(e => e.TahlilBirim)
                .HasForeignKey(e => e.birimID);

            modelBuilder.Entity<TahlilTur>()
                .HasMany(e => e.Tahlil)
                .WithOptional(e => e.TahlilTur)
                .HasForeignKey(e => e.tetkikID);
        }
    }
}
