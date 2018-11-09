using System;
using System.Collections.Generic;
using Lab6.DAL.Context;
using Lab6.DAL.Models;

namespace Lab6.Repositories
{
    public class PointOfInterestRepository : IPointOfInterestRepository
    {
        private readonly Lab6Context _context;

        public PointOfInterestRepository(Lab6Context context)
        {
            _context = context;
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
