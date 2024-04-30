using Entities.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public partial class SOContext : DbContext
    {
        public SOContext()
            : base("name = SOContext")
        {
        }

        public virtual DbSet<Cinsiyet> Cinsiyets { get; set; }
        public virtual DbSet<Doktor> Doktors { get; set; }
        public virtual DbSet<Hasta> Hastas { get; set; }
        public virtual DbSet<HastaDetay> HastaDetays { get; set; }
        public virtual DbSet<HastaDoktor> HastaDoktors { get; set; }
        public virtual DbSet<HastaHastalik> HastaHastaliks { get; set; }
        public virtual DbSet<HastaIlacRapor> HastaIlacRapors { get; set; }
        public virtual DbSet<HastaKayit> HastaKayits { get; set; }
        public virtual DbSet<HastaKayitDetay> HastaKayitDetays { get; set; }
        public virtual DbSet<Hastalik> Hastaliks { get; set; }
        public virtual DbSet<HastaYakin> HastaYakins { get; set; }
        public virtual DbSet<HastaYakinlikDerece> HastaYakinlikDereces { get; set; }
        public virtual DbSet<Hemsire> Hemsires { get; set; }
        public virtual DbSet<Il> Ils { get; set; }
        public virtual DbSet<Ilac> Ilacs { get; set; }
        public virtual DbSet<IlacOlcek> IlacOlceks { get; set; }
        public virtual DbSet<IlacRapor> IlacRapors { get; set; }
        public virtual DbSet<Ilce> Ilces { get; set; }
        public virtual DbSet<Mahalle> Mahalles { get; set; }
        public virtual DbSet<Oda> Odas { get; set; }
        public virtual DbSet<Olcek> Olceks { get; set; }
        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<Rapor> Rapors { get; set; }
        public virtual DbSet<Recete> Recetes { get; set; }
        public virtual DbSet<ReceteIlac> ReceteIlacs { get; set; }
        public virtual DbSet<ReceteTur> ReceteTurs { get; set; }
        public virtual DbSet<Sikayet> Sikayets { get; set; }
        public virtual DbSet<SikayetTur> SikayetTurs { get; set; }
        public virtual DbSet<Tahlil> Tahlils { get; set; }
        public virtual DbSet<TahlilBirim> TahlilBirims { get; set; }
        public virtual DbSet<TahlilTur> TahlilTurs { get; set; }
        public virtual DbSet<Tedarikci> Tedarikcis { get; set; }
        public virtual DbSet<Tetkik> Tetkiks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doktor>()
                .Property(e => e.diplomaNo)
                .IsUnicode(false);

            modelBuilder.Entity<Doktor>()
                .HasOptional(e => e.Personel)
                .WithRequired(e => e.Doktor);

            modelBuilder.Entity<Hasta>()
                .Property(e => e.sosyalGuvenlikNo)
                .IsUnicode(false);

            modelBuilder.Entity<Hasta>()
                .Property(e => e.identityNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Hasta>()
                .Property(e => e.iletisimNo)
                .IsUnicode(false);

            modelBuilder.Entity<Hasta>()
                .HasMany(e => e.HastaYakins)
                .WithOptional(e => e.Hasta)
                .HasForeignKey(e => e.hastaID);

            modelBuilder.Entity<Hasta>()
                .HasMany(e => e.HastaYakins1)
                .WithOptional(e => e.Hasta1)
                .HasForeignKey(e => e.yakinID);

            modelBuilder.Entity<HastaHastalik>()
                .Property(e => e.hastalikTani)
                .IsUnicode(false);

            modelBuilder.Entity<HastaIlacRapor>()
                .HasMany(e => e.IlacRapors)
                .WithOptional(e => e.HastaIlacRapor)
                .HasForeignKey(e => e.hastaRaporID);

            modelBuilder.Entity<HastaKayit>()
                .Property(e => e.protokolNo)
                .IsFixedLength();

            modelBuilder.Entity<HastaKayitDetay>()
                .Property(e => e.ates)
                .HasPrecision(2, 2);

            modelBuilder.Entity<HastaKayitDetay>()
                .Property(e => e.sysNabizUst)
                .IsFixedLength();

            modelBuilder.Entity<HastaKayitDetay>()
                .Property(e => e.diaNabizAlt)
                .IsFixedLength();

            modelBuilder.Entity<HastaKayitDetay>()
                .HasOptional(e => e.HastaKayit)
                .WithRequired(e => e.HastaKayitDetay);

            modelBuilder.Entity<Hemsire>()
                .HasOptional(e => e.Personel)
                .WithRequired(e => e.Hemsire);

            modelBuilder.Entity<Ilac>()
                .Property(e => e.barkod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Personel>()
                .Property(e => e.telefonNo)
                .IsUnicode(false);

            modelBuilder.Entity<Recete>()
                .Property(e => e.receteNo)
                .IsUnicode(false);

            modelBuilder.Entity<ReceteTur>()
                .HasMany(e => e.Ilacs)
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
                .HasMany(e => e.Tahlils)
                .WithOptional(e => e.TahlilBirim)
                .HasForeignKey(e => e.birimID);

            modelBuilder.Entity<TahlilTur>()
                .HasMany(e => e.Tahlils)
                .WithOptional(e => e.TahlilTur)
                .HasForeignKey(e => e.tetkikID);
        }
    }
}
