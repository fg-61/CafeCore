using CafeCore.Model;
using CafeCore.Model.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CafeCore.Data
{
    public class CafeContext : DbContext
    {
        public CafeContext()
            : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CafeDb;Integrated Security=True;");
            }
        }
        //public override int SaveChanges()
        //{
        //    var entiries = ChangeTracker.Entries()
        //        .Where(x => x.Entity is BaseEntity && x.State == EntityState.Added);

        //    foreach (var item in entiries)
        //    {
        //        ((BaseEntity)item.Entity).CreatedDate = DateTime.Now;
        //    }

            //entiries = ChangeTracker.Entries()
            //    .Where(x => x.Entity is BaseEntity && x.State == EntityState.Modified);

            //foreach (var item in entiries)
            //{
            //    ((BaseEntity)item.Entity).UpdatedDate = DateTime.Now;
            //}


            // Deleted eklenecek 
        //    entiries = ChangeTracker.Entries()
        //        .Where(x => x.Entity is BaseEntity && x.State == EntityState.Deleted);

        //    foreach (var item in entiries)
        //    {
        //        ((BaseEntity)item.Entity).DeletedDate = DateTime.Now;
        //        ((BaseEntity)item.Entity).IsDeleted = true;
        //        item.State = EntityState.Modified;
        //    }

        //    return base.SaveChanges();
        //}

        public DbSet<Kat> Katlar { get; set; }
        public DbSet<Masa> Masalar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Urun>()
                .Property(x => x.Fiyat)
                .HasPrecision(8, 2);
            modelBuilder.Entity<Siparis>()
                .Property(x => x.Fiyat)
                .HasPrecision(8, 2);
            modelBuilder.Entity<Siparis>()
                .Property(x => x.AraToplam)
                .HasPrecision(11, 2);
        }

    }
}
