using APIfun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IEnumerable<BowlerWithTeam> Get()
        {
            var bowlersWithTeam = from bowler in _bowlingRepository.Bowlers
                                  join team in _bowlingRepository.Teams on bowler.TeamId equals team.TeamId
                                  where team.TeamName is "Marlins" or "Sharks"
                                  select new BowlerWithTeam
                                  {
                                      BowlerId = bowler.BowlerId,
                                      BowlerFirstName = bowler.BowlerFirstName,
                                      BowlerLastName = bowler.BowlerLastName,
                                      BowlerMiddleInit = bowler.BowlerMiddleInit,
                                      BowlerAddress = bowler.BowlerAddress,
                                      BowlerCity = bowler.BowlerCity,
                                      BowlerState = bowler.BowlerState,
                                      BowlerZip = bowler.BowlerZip,
                                      BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                                      TeamName = team.TeamName
                                  };

            var bowlerData1 = bowlersWithTeam.ToArray();

            return bowlerData1;
        }
    }
}
