using System;

namespace ProductManager
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public double VAT { get; set; }

        public Product( int _Id, string _Name, string _Description, DateTime _StartDate, DateTime _EndDate, double _Price)
        {
            Id = _Id;
            Name = _Name;
            Description = _Description;
            StartDate = _StartDate;
            EndDate = _EndDate;
            Price = _Price;
            VAT = ComputeVAT();
        }
       public bool IsValid()
        {
            if (StartDate < EndDate && Description != null && Id > 0)
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