namespace FlyAnglerHelper
{
    public class Season
    {
        private string _name;

        public string Name
        {
            get { return _name; }
        }

        public Season(string name)
        {
            _name = name;
        }
    }
}