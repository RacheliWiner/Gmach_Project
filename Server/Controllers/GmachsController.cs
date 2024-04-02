using BL.BLApi;
using BL.BLObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Server.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class GmachsController : ControllerBase
        {
            IGmachDetailsForClient GmachDetailsForClientRepo;
            IConfiguration config;
            public GmachsController(IGmachDetailsForClient repository, IConfiguration config)
            {
                this.GmachDetailsForClientRepo = repository;
                this.config = config;
            }

            [HttpGet]
            public ActionResult<List<GmachDetailsForClient>> GetAllGmachs()
            {
                //config.GetSection("AppSettings");
                return GmachDetailsForClientRepo.GetAllGmachs();
            }
        }

}
