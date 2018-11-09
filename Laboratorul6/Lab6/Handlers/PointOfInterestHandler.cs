using Lab6.DAL.Models;
using Lab6.Managers;
using Lab6.Presentation.ViewModel;
using System.Collections.Generic;

namespace Lab6.Handlers
{
    public class PointOfInterestHandler : IPointOfInterestHandler
    {
        private readonly IPointOfInterestManager _manager;

        public PointOfInterestHandler(IPointOfInterestManager manager)
        {
            _manager = manager;
        }

        public IList<PointOfInterestDto> HandlePointOfInterestGet()
        {
            return _manager.GetAllPointsOfInterest();
        }

        public void HandlePointOfInterestPost(PointOfInterest point)
        {
            _manager.CreatePointOfInterest(point);
        }
    }
}