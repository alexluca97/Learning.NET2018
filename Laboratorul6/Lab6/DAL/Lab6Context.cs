using Lab6.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6.DAL
{
    public class Lab6Context : DbContext
    {
        public Lab6Context()
        {
        }

        public DbSet<PointOfInterest> PointOfInterest { get; set; }
    }
}