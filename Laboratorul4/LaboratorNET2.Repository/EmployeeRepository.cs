using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LaboratorNET2.Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private readonly ApplicationContext _applicationContext;

        public EmployeeRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void Create(Employee creationModel)
        {
            _applicationContext.Employee.Add(creationModel);
            _applicationContext.SaveChanges();
        }

        public void Update(Guid id, Employee updateModel)
        {
            _applicationContext.Entry(updateModel).State = EntityState.Modified;
            _applicationContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var employeeToDelete = _applicationContext.Employee.FirstOrDefault(c => c.Id == id);

            if (employeeToDelete != null)
            {
                _applicationContext.Employee.Remove(employeeToDelete);
                _applicationContext.SaveChanges();
            }
        }

        public Employee GetById(Guid id)
        {
            var employee = _applicationContext.Employee.FirstOrDefault(c => c.Id == id);

            return employee;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _applicationContext.Employee.AsEnumerable();
        }

        public IEnumerable<Employee> GetEmployeeSBySalary(double salary)
        {
            var employees = _applicationContext.Employee.Where(c => c.Salary == salary);

            return employees;
        }
    }
}