namespace FlyAnglerHelper
{
    public class DryFly : Fly
    {
        public override string FlyType
        {
            get { return "Dry Fly"; }
        }

        public DryFly(string name, string insectName, string seasonName, string lifeStageName)
            : base(name, insectName, seasonName, lifeStageName)
        {
        }

        public override string GetPresentationTip()
        {
            return "Fish this on the surface and watch for rising trout.";
        }

        public override string GetImitationDescription()
        {
            return "This fly imitates an adult insect floating on the water.";
        }
    }
}