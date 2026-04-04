using System.Collections.Generic;

namespace FlyAnglerHelper
{
    public class RecommendationEngine
    {
        private FlyDatabase _database;

        public RecommendationEngine()
        {
            _database = new FlyDatabase();
        }

        public RecommendationResult GetRecommendations(Insect insect, Season season, LifeStage stage)
        {
            List<Fly> matchingFlies = new List<Fly>();

            foreach (Fly fly in _database.GetAllFlies())
            {
                if (fly.Matches(insect, season, stage))
                {
                    matchingFlies.Add(fly);
                }
            }

            return new RecommendationResult(matchingFlies);
        }
    }
}