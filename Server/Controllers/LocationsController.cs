using DAL;
using DAL.DALApi;
using DAL.DALObjects;
using DAL.DALImplementation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationsController : ControllerBase
    {
        IRepository<Location> LocationRepo;
        IConfiguration config;
        public LocationsController(IRepository<Location> repository, IConfiguration config)
        {
            this.LocationRepo = repository;
            this.config = config;
        }

        [HttpGet]
        public ActionResult<List<Location>> GetAllLocations()
        {
            //config.GetSection("AppSettings");
            return LocationRepo.GetAll();
        }
    }
}
