using Lab6.Repositories;
using System.Collections.Generic;
using System.Linq;
using Lab6.Domain;
using Lab6.Domain.Models;

namespace Lab6.Managers
{
    public class PointOfInterestManager : IPointOfInterestManager
    {
        private IPointOfInterestRepository _repository;

        public PointOfInterestManager()
        {
            _repository = new PointOfInterestRepository();
        }

        public void CreatePointOfInterest(PointOfInterest point)
        {
            _repository.CreatePointOfInterest(point);
        }

        public IList<PointOfInterestDTO> GetAllPointsOfInterest()
        {
            var allPointsInDb = _repository.GetAllPointsOfInterest();

            return allPointsInDb.Select(pointOfInterest => 
                new PointOfInterestDTO
                {
                    Coordinates = pointOfInterest.Coordinates,
                    Name = pointOfInterest.Name
                }).ToList();
        }
    }
}
