using Lab6.DAL.Models;
using Lab6.Domain.Domain.Models;
using Lab6.Handlers;
using Lab6.Presentation.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lab6.Controllers
{
    [Route("api/[controller]")]
    public class PointOfInterestController : Controller
    {
        private readonly IPointOfInterestHandler _handler;

        public PointOfInterestController(IPointOfInterestHandler handler)
        {
            _handler = handler;
        }

        [HttpGet]
        public IList<PointOfInterestDto> Get()
        {
            return _handler.HandlePointOfInterestGet();
        }

        [HttpPost]
        public void Create()
        {
            _handler.HandlePointOfInterestPost(new PointOfInterest
            {
                Name = "test",
                Latitude = 12.5,
                Longitude = 12.5
            });
        }
    }
}
