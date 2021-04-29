using BO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TP1_Module06.Models;

namespace TP1_Module06.Data
{
    public class TP1_Module06Context : DbContext
    {
    
        public TP1_Module06Context() : base("name=TP1_Module06Context")
        {
        }
        public System.Data.Entity.DbSet<BO.Arme> Armes { get; set; }

        public System.Data.Entity.DbSet<BO.Samourai> Samourais { get; set; }

        public System.Data.Entity.DbSet<BO.ArtMartial> ArtMartials { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Samourai>().HasOptional(s => s.Arme).WithOptionalPrincipal();
            modelBuilder.Entity<Samourai>().HasMany(x => x.ArtMartials).WithMany();
        }
    }
}
