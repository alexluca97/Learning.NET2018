using System.ComponentModel.DataAnnotations;
using Lab6.Domain.Domain.Models;

namespace Lab6.Core
{
    public class PointOfInterestDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Coordinates Coordinates { get; set; }
    }
}
