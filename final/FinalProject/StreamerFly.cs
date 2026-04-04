namespace FlyAnglerHelper
{
    public class StreamerFly : Fly
    {
        public override string FlyType
        {
            get { return "Streamer"; }
        }

        public StreamerFly(string name, string insectName, string seasonName, string lifeStageName)
            : base(name, insectName, seasonName, lifeStageName)
        {
        }

        public override string GetPresentationTip()
        {
            return "Strip or swing this fly to imitate movement.";
        }

        public override string GetImitationDescription()
        {
            return "This fly represents larger food sources or active movement in the water.";
        }
    }
}