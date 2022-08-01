using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.Context
{
    public class DataContext:IdentityDbContext<AppUser,AppRole,int>
    {
        public DataContext(DbContextOptions options):base(options)
        {
        }

        public DataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//connection string tanımlasını yaptığımız yer 
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;Integrated Security=True;database=AccounCardDb;");//bağlantı adresimizi yazdığımız yer 
            }
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountCardSubGroup>()
            .HasOne(b => b.AccountCardGroup)
            .WithMany(a => a.AccountCardSubGroup)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AccountCardGroup>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<AccountCardKind>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<AccountCardType>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<AccountCard>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd();

            });

            base.OnModelCreating(modelBuilder); 
        }
        public DbSet<AccountCard> AccountCards { get; set; }//Hesap kartları
        public DbSet<AccountCardGroup> AccountCardGroups { get; set; }//hesap kart grupları
        public DbSet<AccountCardType> AccountCardTypes { get; set; }//hesap kart tipi
        public DbSet<AccountCardKind> AccountCardKinds { get; set; }//hesap kart türü
        public DbSet<AccountCardSubGroup> AccountCardSubGroups { get; set; }//hesap kart alt grup


    }
}
