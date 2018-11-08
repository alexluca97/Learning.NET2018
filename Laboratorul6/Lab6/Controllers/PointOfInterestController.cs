using System.Collections.Generic;
using Lab6.Domain;
using Lab6.Handlers;
using Microsoft.AspNetCore.Mvc;
using Lab6.Domain.Models;

namespace Lab6.Controllers
{
    [Route("api/[controller]")]
    public class PointOfInterestController : Controller
    {
        private readonly PointOfInterestHandler _handler;

        public PointOfInterestController()
        {
            _handler = new PointOfInterestHandler();
        }

        [HttpGet]
        public IList<PointOfInterestDTO> Get()
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
