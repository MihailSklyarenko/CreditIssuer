using CreditIssuer.Bll.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CreditIssuer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationController : ControllerBase
    {

        [HttpPost("create")]
        public IEnumerable<string> Create([FromBody] CreditRequestDto request)
        {
            return null;
        }

        [HttpGet("status")]
        public IEnumerable<string> Status([FromQuery] string applicationNum)
        {
            return null;
        }
    }
}