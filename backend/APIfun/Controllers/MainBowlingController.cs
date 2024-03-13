using APIfun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIfun.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MainBowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public MainBowlingController(IBowlingRepository temp) 
        { 
            _bowlingRepository = temp;
        }
        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _bowlingRepository.Bowlers.ToArray();

            return bowlerData;
        }
    }
}
