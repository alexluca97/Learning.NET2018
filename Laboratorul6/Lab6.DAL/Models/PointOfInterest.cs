using System.ComponentModel.DataAnnotations;
using Lab6.Domain.Domain.Models;

namespace Lab6.DAL.Models
{
    public class PointOfInterest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Coordinates Coordinates { get; set; }
    }
}