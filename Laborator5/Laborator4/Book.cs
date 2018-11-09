using System.ComponentModel.DataAnnotations;

namespace Laborator4
{
    public class Book
    {
        public int Id { get; set; } 

        [Required]
        [MinLength(50)]
        [MaxLength(100)]
        public string Title { get; set; }
    }
}