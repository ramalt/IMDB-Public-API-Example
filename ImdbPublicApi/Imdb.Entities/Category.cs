using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace Imdb.Entities
{
    public class Category
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string CategoryName { get; set; }
        public List<MovieCategory> MovieCategories { get; set; }
        
    }

}