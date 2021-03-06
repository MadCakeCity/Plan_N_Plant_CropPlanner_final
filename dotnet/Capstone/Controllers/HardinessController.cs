using Capstone.DAO;
using Capstone.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HardinessController : ControllerBase
    {
        private readonly IHardinessDao HardinessSqlDao;
        public HardinessController(IHardinessDao hardinessDao)
        {
            HardinessSqlDao = hardinessDao;
        }

        //get list of all zones
        [HttpGet()]
        public ActionResult<List<Hardiness>> ListAllZones()
        {
            return HardinessSqlDao.GetAllHardinessZones();
        }

        public int GetUserIdFromToken()
        {
            int userId = -1;
            try
            {
                userId = int.Parse(User.FindFirst("sub")?.Value);
            }
            catch
            {

            }
            return userId;
        }
    }


}
