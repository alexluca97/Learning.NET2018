using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager
{
    public class Manager : Employee
    {
        public Manager(string _FirstName, string _LastName, DateTime _EndDate, double _Salary) : base(_FirstName, _LastName, _EndDate, _Salary)
        {
            Id = Guid.NewGuid();
            FirstName = _FirstName;
            LastName = _LastName;
            StartDate = DateTime.Now;
            EndDate = _EndDate;
            Salary = _Salary;
        }
    }
}
