using System.Collections.Generic;
using Lab6.Core;
using Lab6.DAL.Models;

namespace Lab6.Handlers
{
    public interface IPointOfInterestHandler
    {
        IList<PointOfInterestDto> HandlePointOfInterestGet();
        void HandlePointOfInterestPost(PointOfInterest point);
    }
}