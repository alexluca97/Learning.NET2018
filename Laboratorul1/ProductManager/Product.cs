using System;

namespace ProductManager
{
    public class Product
    {
        Guid Id;
        string Name;
        string Description;
        DateTime StartDate;
        DateTime EndDate;
        double Price;
        double VAT;

        public Product( string _Name, string _Description, DateTime _EndDate, double _Price)
        {
            Id = Guid.NewGuid();
            Name = _Name;
            Description = _Description;
            StartDate = DateTime.Now;
            EndDate = _EndDate;
            Price = _Price;
            VAT = ComputeVAT();
        }
       public bool IsValid()
        {
            if (StartDate < EndDate)
            {
                return true;
            }
            return false;
        }

       public double ComputeVAT()
        {
            VAT = (25 * Price) / 100;
            return VAT;
        }

    }
}