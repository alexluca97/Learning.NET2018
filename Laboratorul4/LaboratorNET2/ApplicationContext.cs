using Microsoft.EntityFrameworkCore;

namespace LaboratorNET2
{
    public class ApplicationContext : DbContext
    {
        private readonly string _phoneNumberRegEx;
        private readonly string _connectionString;

        public ApplicationContext()
        {
            _phoneNumberRegEx =
                @"/^(\+4|)?(07[0-8]{1}[0-9]{1}|02[0-9]{2}|03[0-9]{2}){1}?(\s|\.|\-)?([0-9]{3}(\s|\.|\-|)){2}$/igm";

            _connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(c => c.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.Address).IsRequired().HasMaxLength(300);
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
    }
}