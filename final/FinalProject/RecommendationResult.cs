using System.Collections.Generic;

namespace FlyAnglerHelper
{
    public class RecommendationResult
    {
        private List<Fly> _flies;

        public List<Fly> Flies
        {
            get { return _flies; }
        }

        public RecommendationResult(List<Fly> flies)
        {
            _flies = flies;
        }
    }
}