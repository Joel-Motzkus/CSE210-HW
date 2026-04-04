using System;

namespace FlyAnglerHelper
{
    public abstract class Fly
    {
        private string _name;
        private string _insectName;
        private string _seasonName;
        private string _lifeStageName;

        public string Name
        {
            get { return _name; }
        }

        public string InsectName
        {
            get { return _insectName; }
        }

        public string SeasonName
        {
            get { return _seasonName; }
        }

        public string LifeStageName
        {
            get { return _lifeStageName; }
        }

        public abstract string FlyType { get; }

        public Fly(string name, string insectName, string seasonName, string lifeStageName)
        {
            _name = name;
            _insectName = insectName;
            _seasonName = seasonName;
            _lifeStageName = lifeStageName;
        }

        public bool Matches(Insect insect, Season season, LifeStage stage)
        {
            return _insectName.Equals(insect.Name, StringComparison.OrdinalIgnoreCase)
                && _seasonName.Equals(season.Name, StringComparison.OrdinalIgnoreCase)
                && _lifeStageName.Equals(stage.Name, StringComparison.OrdinalIgnoreCase);
        }

        public abstract string GetPresentationTip();
        public abstract string GetImitationDescription();
    }
}