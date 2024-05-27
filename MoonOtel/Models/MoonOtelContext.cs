using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MoonOtel.Models
{
    public partial class MoonOtelContext : DbContext
    {
        public MoonOtelContext()
            : base("name=MoonOtelContext")
        {
        }

        public virtual DbSet<Hizmet> Hizmet { get; set; }
        public virtual DbSet<Lokanta> Lokanta { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MusteriHesap> MusteriHesap { get; set; }
        public virtual DbSet<MusteriKayit> MusteriKayit { get; set; }
        public virtual DbSet<Oda> Oda { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Servis> Servis { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                .HasMany(e => e.Lokanta)
                .WithOptional(e => e.Menu)
                .HasForeignKey(e => e.tuketilen);

            modelBuilder.Entity<MusteriKayit>()
                .HasMany(e => e.Oda1)
                .WithOptional(e => e.MusteriKayit1)
                .HasForeignKey(e => e.rezerveID);

            modelBuilder.Entity<Oda>()
                .HasMany(e => e.MusteriKayit)
                .WithOptional(e => e.Oda)
                .HasForeignKey(e => e.odaID);

            modelBuilder.Entity<Personel>()
                .HasMany(e => e.Oda)
                .WithOptional(e => e.Personel)
                .HasForeignKey(e => e.personelID);
        }
    }
}
