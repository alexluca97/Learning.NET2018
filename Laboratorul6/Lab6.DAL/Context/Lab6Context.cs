using Lab6.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6.DAL.Context
{
    public sealed class Lab6Context : DbContext 
    {
        public Lab6Context(DbContextOptions<Lab6Context> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<PointOfInterest> PointOfInterest { get; set; }
    }
}