using Lab6.DAL.Models;
using Lab6.Presentation.ViewModel;
using System.Collections.Generic;

namespace Lab6.Handlers
{
    public interface IPointOfInterestHandler
    {
        IList<PointOfInterestDto> HandlePointOfInterestGet();
        void HandlePointOfInterestPost(PointOfInterest point);
    }
}