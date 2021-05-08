using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imdb.Entities
{
    public class MovieStar
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("Movie")]
        public Movie Movie { get; set; }

        public int StarId { get; set; }
        [ForeignKey("Star")]
        public Star Star { get; set; }

    }
}