using APICours.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICours.Data
{
    public class LmsContext : DbContext
    {
          public LmsContext(DbContextOptions<LmsContext> options) : base(options)
          {
          }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Lecon>()
                .HasOne<Cours>(l => l.Cours)
                .WithMany(c => c.leslecons)
                .HasForeignKey(l => l.coursId)
                .IsRequired();

        }

        public DbSet<Cours> Cours { get; set; }
        public DbSet<Lecon> Lecons { get; set; }



    }
    
}
