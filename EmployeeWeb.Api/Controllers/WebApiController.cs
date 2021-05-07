using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Api.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllData()
        {
            return null;
        }
    }
}