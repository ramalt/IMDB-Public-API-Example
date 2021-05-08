using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imdb.Entities
{
    public class MovieCategory
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("Movie")]
        public Movie Movie { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("Category")]
        public Category Category { get; set; }
    }
}