using System;
using System.Collections.Generic;
using Lab6.Domain.Models;
using Lab6.DAL;

namespace Lab6.Repositories
{
    public class PointOfInterestRepository : IPointOfInterestRepository
    {
        Lab6Context _context;

        public PointOfInterestRepository()
        {
            _context = new Lab6Context();
        }

        public IEnumerable<PointOfInterest> GetAllPointsOfInterest()
        {
            throw new NotImplementedException();
        }

        public PointOfInterest GetPointsOfInterestById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeletePointOfInterestById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePointOfInterest(PointOfInterest point)
        {
            throw new NotImplementedException();
        }

        public void CreatePointOfInterest(PointOfInterest point)
        {
            _context.PointOfInterest.Add(point);
        }
    }
}
