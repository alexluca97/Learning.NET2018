using Lab6.Repositories;
using Lab6.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using Lab6.Presentation.ViewModel;

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
                    Name = pointOfInterest.Name,
                    Longitude = 12.5,
                    Latitude = 13.5
                }).ToList();
        }
    }
}
