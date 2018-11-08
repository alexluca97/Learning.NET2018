using System.Collections.Generic;
using Lab6.Domain;
using Lab6.Domain.Models;

namespace Lab6.Handlers
{
    public interface IPointOfInterestHandler
    {
        IList<PointOfInterestDTO> HandlePointOfInterestGet();
        void HandlePointOfInterestPost(PointOfInterest point);
    }
}