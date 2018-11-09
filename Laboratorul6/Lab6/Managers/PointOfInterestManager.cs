using Lab6.Repositories;
using System.Collections.Generic;
using System.Linq;
using Lab6.Core;
using Lab6.DAL.Models;

namespace Lab6.Managers
{
    public class PointOfInterestManager : IPointOfInterestManager
    {
        private readonly IPointOfInterestRepository _repository;

        public PointOfInterestManager(IPointOfInterestRepository repository)
        {
            _repository = repository;
        }

        public void CreatePointOfInterest(PointOfInterest point)
        {
            _repository.CreatePointOfInterest(point);
        }

        public IList<PointOfInterestDto> GetAllPointsOfInterest()
        {
            var allPointsInDb = _repository.GetAllPointsOfInterest();

            return allPointsInDb.Select(pointOfInterest => 
                new PointOfInterestDto
                {
                    Coordinates = pointOfInterest.Coordinates,
                    Name = pointOfInterest.Name
                }).ToList();
        }
    }
}
