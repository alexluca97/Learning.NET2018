using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager
{
    public abstract class Employee
    {
       protected Guid Id;
       protected string FirstName;
       protected string LastName;
       protected DateTime StartDate;
       protected DateTime EndDate;
       protected double Salary;

        public Employee(string _FirstName, string _LastName, DateTime _EndDate, double _Salary)
        {
            Id = Guid.NewGuid();
            FirstName = _FirstName;
            LastName = _LastName;
            StartDate = DateTime.Now;
            EndDate = _EndDate;
            Salary = _Salary;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public bool IsActive()
        {
            if (DateTime.Now < EndDate)
            {
                return true;
            }
            return false;
        }
    }
}
