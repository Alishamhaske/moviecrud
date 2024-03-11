using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moviecrud.Models
{
    [Table("Movie")]
    public class Movie
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }


        [Required]
        public string? Type { get; set; }

        [Required]
        public string? Actor { get; set; }

        [Required]
        public string? Actress { get; set; }


    }
}
