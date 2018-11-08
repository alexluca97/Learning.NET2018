using System.ComponentModel.DataAnnotations;

namespace Lab6.Domain.Models
{
    public class PointOfInterest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Coordinates Coordinates { get; set; }
    }
}