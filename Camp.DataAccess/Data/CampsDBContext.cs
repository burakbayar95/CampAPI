using Camp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Movies.DataAccess.Data
{
    public class CampsDBContext : DbContext
    {
        

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Login> Logins { get; set; }

        public DbSet<Camp.Models.Camp> Camps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Camp.Models.Camp>().HasOne(c => c.Genre).WithMany(m => m.Camps).HasForeignKey(m=>m.GenreId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
