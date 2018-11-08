using System.Collections.Generic;
using Lab6.Domain;
using Lab6.Managers;
using Lab6.Domain.Models;

namespace Lab6.Handlers
{
    public class PointOfInterestHandler : IPointOfInterestHandler
    {
        private readonly IPointOfInterestManager _manager;

        public PointOfInterestHandler()
        {
            _manager = new PointOfInterestManager();
        }

        public IList<PointOfInterestDTO> HandlePointOfInterestGet()
        {
            return _manager.GetAllPointsOfInterest();
        }

        public void HandlePointOfInterestPost(PointOfInterest point)
        {
            _manager.CreatePointOfInterest(point);
        }
    }
}