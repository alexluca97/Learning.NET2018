using System.Collections.Generic;
using Lab6.Core;
using Lab6.DAL.Models;

namespace Lab6.Managers
{
    public interface IPointOfInterestManager
    {
        IList<PointOfInterestDto> GetAllPointsOfInterest();
        void CreatePointOfInterest(PointOfInterest point);
    }
}