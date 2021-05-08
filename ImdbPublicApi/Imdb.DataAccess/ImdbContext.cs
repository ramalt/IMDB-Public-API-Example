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
                "Server=MACBETH;Database=IMDBDB;Trusted_Connection=True;");
        }

        public List<Movie> Movies { get; set; }
        public List<Category> Categories { get; set; }
        public List<MovieCategory> MovieCategories { get; set; }
        public List<MovieStar> MovieStars { get; set; }
    }
}