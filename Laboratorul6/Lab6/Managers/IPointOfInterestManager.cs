using System.Collections.Generic;
using Lab6.Domain;
using Lab6.Domain.Models;

namespace Lab6.Managers
{
    public interface IPointOfInterestManager
    {
        IList<PointOfInterestDTO> GetAllPointsOfInterest();
        void CreatePointOfInterest(PointOfInterest point);
    }
}