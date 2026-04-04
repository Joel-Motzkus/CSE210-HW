namespace FlyAnglerHelper
{
    public class LifeStage
    {
        private string _name;

        public string Name
        {
            get { return _name; }
        }

        public LifeStage(string name)
        {
            _name = name;
        }
    }
}