using System;
using LaboratorNET2;
using LaboratorNET2.Repository;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationContext();
            var repository = new CustomerRepository(context);

            var entity = new Customer(Guid.NewGuid(), "Nume test 1", "Adresa test 1", "0748692100", "test@yahoo.ro");

            repository.Create(entity);
        }
    }
}
