using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Laborator4
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MinLength(50)]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(50)]
        [MaxLength(150)]
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
