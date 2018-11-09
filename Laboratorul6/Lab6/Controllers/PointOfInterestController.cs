using System.Collections.Generic;
using Lab6.Core;
using Lab6.DAL.Models;
using Lab6.Domain.Domain.Models;
using Lab6.Handlers;
using Microsoft.AspNetCore.Mvc;

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
                Id = 1,
                Name = "test",
                Coordinates = new Coordinates
                {
                    Latitude = 12.5,
                    Longitude = 12.5
                }
            });
        }
    }
}
