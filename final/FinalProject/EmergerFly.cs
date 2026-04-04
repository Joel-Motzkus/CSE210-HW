namespace FlyAnglerHelper
{
    public class EmergerFly : Fly
    {
        public override string FlyType
        {
            get { return "Emerger"; }
        }

        public EmergerFly(string name, string insectName, string seasonName, string lifeStageName)
            : base(name, insectName, seasonName, lifeStageName)
        {
        }

        public override string GetPresentationTip()
        {
            return "Fish this just under the surface during a hatch.";
        }

        public override string GetImitationDescription()
        {
            return "This fly imitates an insect transitioning into its adult stage.";
        }
    }
}