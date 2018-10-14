using System;

namespace LibraryClass
{
    public class Architect : Employee
    {
        public Architect(string firstName, string lastName, DateTime endDate, double salary) : base(firstName, lastName, endDate, salary)
        {
        }

        public virtual string Salutation()
        {
            return "Hello arhitect";
        }
    }
}
