using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imdb.Entities
{
    public class Movie
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [StringLength(50)]
        [Required]
        public string Director { get; set; }
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
        public string Year { get; set; }
        public string Subject { get; set; }
        public string Cover { get; set; }

        public List<MovieCategory> MovieCategories { get; set; }
        public List<MovieStar> MovieStars { get; set; }
    }
}