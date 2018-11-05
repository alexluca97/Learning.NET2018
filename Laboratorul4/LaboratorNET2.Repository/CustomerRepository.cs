using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LaboratorNET2.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly ApplicationContext _applicationContext;

        public CustomerRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void Create(Customer creationModel)
        {
            _applicationContext.Customer.Add(creationModel);
            _applicationContext.SaveChanges();
        }

        public void Update(Guid id, Customer updateModel)
        {
            _applicationContext.Entry(updateModel).State = EntityState.Modified;
            _applicationContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var customerToDelete = _applicationContext.Customer.AsEnumerable().FirstOrDefault(c => c.Id == id);

            if (customerToDelete != null)
            {
                _applicationContext.Customer.Remove(customerToDelete);
                _applicationContext.SaveChanges();
            }
        }

        public Customer GetById(Guid id)
        {
            var customer = _applicationContext.Customer.AsEnumerable().FirstOrDefault(c => c.Id == id);

            return customer;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _applicationContext.Customer.AsEnumerable();
        }

        public Customer GetCustomerByEmail(string email)
        {
            var customer = _applicationContext.Customer.First(c => c.Email == email);

            return customer;
        }
    }
}
