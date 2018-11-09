using System.ComponentModel.DataAnnotations;

namespace Lab6.Presentation.ViewModel
{
    public class PointOfInterestDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public double Latitude { get; set; }
    }
}
