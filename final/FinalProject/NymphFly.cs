namespace FlyAnglerHelper
{
    public class NymphFly : Fly
    {
        public override string FlyType
        {
            get { return "Nymph"; }
        }

        public NymphFly(string name, string insectName, string seasonName, string lifeStageName)
            : base(name, insectName, seasonName, lifeStageName)
        {
        }

        public override string GetPresentationTip()
        {
            return "Fish this below the surface with a natural dead drift.";
        }

        public override string GetImitationDescription()
        {
            return "This fly imitates an immature insect below the water.";
        }
    }
}