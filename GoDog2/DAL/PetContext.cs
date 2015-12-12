using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using GoDog2.Models;

namespace GoDog2.DAL
{
    public class PetContext : DbContext
    {
        public PetContext() : base("PetContext")
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetLog> Petlogs { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}