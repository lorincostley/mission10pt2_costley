
namespace APIfun.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlingcontext;
        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _bowlingcontext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlingcontext.Bowlers;
    }
}