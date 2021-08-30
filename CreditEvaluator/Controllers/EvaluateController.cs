using CreditEvaluator.Bll.Interfaces;
using CreditIssuer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CreditEvaluator.Controllers
{
    [ApiController]
    [Route("api/scoring/")]
    public class EvaluateController : ControllerBase
    {
        IService service;
        public EvaluateController(IService service)
        {
            this.service = service;
        }

        [HttpPost("evaluate")]
        public async Task<ActionResult> Evaluate([FromBody] CreditRequest creditRequest)
        {            
            return Ok(service.Evaluate(creditRequest));
        }
    }
}