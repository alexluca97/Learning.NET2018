using Lab6.DAL.Models;
using Lab6.Presentation.ViewModel;
using System.Collections.Generic;

namespace Lab6.Managers
{
    public interface IPointOfInterestManager
    {
        IList<PointOfInterestDto> GetAllPointsOfInterest();
        void CreatePointOfInterest(PointOfInterest point);
    }
}