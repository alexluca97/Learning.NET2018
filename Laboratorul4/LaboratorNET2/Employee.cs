using System;
using System.ComponentModel.DataAnnotations;

namespace LaboratorNET2
{
    public class Employee
    {
        public Employee(Guid id, string firstName, string lastName, DateTime startDate, bool isActive, double salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            IsActive = isActive;
            Salary = salary;
        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(70)]
        public string LastName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsActive { get; set; }

        public double Salary { get; set; }
    }
}
