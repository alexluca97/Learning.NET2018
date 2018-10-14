using System;

namespace LibraryClass
{
    public class Architect : Employee
    {
        public Architect(int id, string firstName, string lastName, DateTime startDate, DateTime endDate, double salary) : base(1, firstName, lastName, endDate, startDate, salary)
        {
        }

        public override string Salutation()
        {
            return "Hello arhitect";
        }
    }
}
