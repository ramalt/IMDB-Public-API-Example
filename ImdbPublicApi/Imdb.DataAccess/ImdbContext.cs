using System.Collections.Generic;
using Imdb.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imdb.DataAccess
{
    public class ImdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Server=MACBETH;Database=IMDBDb;Trusted_Connection=True;");
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Star> Stars { get; set; }
       
    }
}