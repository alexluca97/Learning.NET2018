using System.Collections.Generic;
using Lab6.DAL.Models;

namespace Lab6.Repositories
{
    public interface IPointOfInterestRepository
    {
        IEnumerable<PointOfInterest> GetAllPointsOfInterest();
        PointOfInterest GetPointsOfInterestById(int id);
        void DeletePointOfInterestById(int id);
        void UpdatePointOfInterest(PointOfInterest point);
        void CreatePointOfInterest(PointOfInterest point);
    }
}