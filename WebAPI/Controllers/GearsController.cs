using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GearsController : ControllerBase
    {
        private IGearService _gearService;

        public GearsController(IGearService gearService)
        {
            _gearService = gearService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _gearService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
