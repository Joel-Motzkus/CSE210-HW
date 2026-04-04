using System.Collections.Generic;

namespace FlyAnglerHelper
{
    public class FlyDatabase
    {
        private List<Fly> _flies;

        public FlyDatabase()
        {
            _flies = new List<Fly>();
            LoadFlies();
        }

        private void LoadFlies()
        {
            AddMidgeFlies();
            AddMayflyFlies();
            AddStoneflyFlies();
            AddCaddisFlies();
            AddScudFlies();
            AddTerrestrialFlies();
        }

        private void AddMidgeFlies()
        {
            AddNymphForAllSeasons("Zebra Midge", "Midge");
            AddNymphForAllSeasons("Demon Midge", "Midge");

            _flies.Add(new EmergerFly("CDC Midge", "Midge", "Winter", "Emerger"));
            _flies.Add(new EmergerFly("CDC Midge", "Midge", "Spring", "Emerger"));
            _flies.Add(new EmergerFly("CDC Midge", "Midge", "Summer", "Emerger"));
            _flies.Add(new EmergerFly("CDC Midge", "Midge", "Fall", "Emerger"));

            _flies.Add(new DryFly("Griffith's Gnat", "Midge", "Winter", "Dun/Adult"));
            _flies.Add(new DryFly("Griffith's Gnat", "Midge", "Spring", "Dun/Adult"));
            _flies.Add(new DryFly("Griffith's Gnat", "Midge", "Summer", "Dun/Adult"));
            _flies.Add(new DryFly("Griffith's Gnat", "Midge", "Fall", "Dun/Adult"));
        }

        private void AddMayflyFlies()
        {
            AddNymphForAllSeasons("Pheasant Tail", "Mayfly");
            AddNymphForAllSeasons("Frenchie", "Mayfly");
            AddNymphForAllSeasons("Copper John", "Mayfly");

            _flies.Add(new EmergerFly("RS2", "Mayfly", "Spring", "Emerger"));
            _flies.Add(new EmergerFly("RS2", "Mayfly", "Summer", "Emerger"));
            _flies.Add(new DryFly("Parachute Adams", "Mayfly", "Spring", "Dun/Adult"));
            _flies.Add(new DryFly("Sparkle Dun", "Mayfly", "Spring", "Dun/Adult"));
            _flies.Add(new DryFly("Comparadun", "Mayfly", "Summer", "Dun/Adult"));
        }

        private void AddStoneflyFlies()
        {
            AddNymphForAllSeasons("Pat's Rubber Legs", "Stonefly");
            AddNymphForAllSeasons("Stonefly Nymph", "Stonefly");

            _flies.Add(new DryFly("Foam Stonefly", "Stonefly", "Spring", "Dun/Adult"));
            _flies.Add(new DryFly("Foam Stonefly", "Stonefly", "Summer", "Dun/Adult"));
        }

        private void AddCaddisFlies()
        {
            AddNymphForAllSeasons("Green Rock Worm", "Caddis");

            _flies.Add(new EmergerFly("Soft Hackle Caddis", "Caddis", "Spring", "Emerger"));
            _flies.Add(new EmergerFly("Soft Hackle Caddis", "Caddis", "Summer", "Emerger"));

            _flies.Add(new DryFly("Elk Hair Caddis", "Caddis", "Spring", "Dun/Adult"));
            _flies.Add(new DryFly("Elk Hair Caddis", "Caddis", "Summer", "Dun/Adult"));
            _flies.Add(new DryFly("X-Caddis", "Caddis", "Summer", "Dun/Adult"));
        }

        private void AddScudFlies()
        {
            AddNymphForAllSeasons("Orange Scud", "Scud");
            AddNymphForAllSeasons("Gray Scud", "Scud");
        }

        private void AddTerrestrialFlies()
        {
            _flies.Add(new DryFly("Foam Ant", "Terrestrials", "Summer", "Dun/Adult"));
            _flies.Add(new DryFly("Foam Ant", "Terrestrials", "Fall", "Dun/Adult"));
            _flies.Add(new DryFly("Hopper", "Terrestrials", "Summer", "Dun/Adult"));
            _flies.Add(new DryFly("Beetle", "Terrestrials", "Summer", "Dun/Adult"));
            _flies.Add(new DryFly("Beetle", "Terrestrials", "Fall", "Dun/Adult"));
        }

        private void AddNymphForAllSeasons(string flyName, string insectName)
        {
            _flies.Add(new NymphFly(flyName, insectName, "Winter", "Larva/Nymph"));
            _flies.Add(new NymphFly(flyName, insectName, "Spring", "Larva/Nymph"));
            _flies.Add(new NymphFly(flyName, insectName, "Summer", "Larva/Nymph"));
            _flies.Add(new NymphFly(flyName, insectName, "Fall", "Larva/Nymph"));
        }

        public List<Fly> GetAllFlies()
        {
            return _flies;
        }
    }
}