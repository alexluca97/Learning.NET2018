using System;
using System.ComponentModel.DataAnnotations;

namespace LaboratorNET2
{
    public class Customer
    {
        public Customer(Guid id, string name, string address, string phoneNumber, string email)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        [Required]
        public Guid Id { get; private set; }

        [Required]
        [StringLength(70)]
        public string Name { get; private set; }

        [Required]
        [StringLength(100)]
        public string Address { get; private set; }

        [Required]
        [StringLength(12)]
        public string PhoneNumber { get; private set; }

        [Required]
        [StringLength(30)]
        public string Email { get; private set; }
    }
}