using System.ComponentModel.DataAnnotations;

namespace Lab6.Domain.Domain.Models
{
    public class Coordinates
    {
        public int Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}