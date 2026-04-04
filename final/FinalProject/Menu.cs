using System;

namespace FlyAnglerHelper
{
    public class Menu
    {
        private RecommendationEngine _engine;

        public Menu()
        {
            _engine = new RecommendationEngine();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to the Beginner Fly Selection Helper!");
            Console.WriteLine("This program helps beginner fly anglers choose a fly.");
            Console.WriteLine();

            bool running = true;

            while (running)
            {
                Console.WriteLine("What insects are you seeing?");
                Console.WriteLine("1. Midge");
                Console.WriteLine("2. Mayfly");
                Console.WriteLine("3. Stonefly");
                Console.WriteLine("4. Caddis");
                Console.WriteLine("5. Scud");
                Console.WriteLine("6. Terrestrials");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");
                string insectChoice = Console.ReadLine();

                if (insectChoice == "7")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                Insect insect = BuildInsect(insectChoice);

                if (insect == null)
                {
                    Console.WriteLine("Invalid insect choice.");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("What time of year is it?");
                Console.WriteLine("1. Winter");
                Console.WriteLine("2. Spring");
                Console.WriteLine("3. Summer");
                Console.WriteLine("4. Fall");
                Console.Write("Enter choice: ");
                string seasonChoice = Console.ReadLine();

                Season season = BuildSeason(seasonChoice);

                if (season == null)
                {
                    Console.WriteLine("Invalid season choice.");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("What stage of life are the insects in?");
                Console.WriteLine("1. Larva / Nymph");
                Console.WriteLine("2. Emerger");
                Console.WriteLine("3. Dun / Adult");
                Console.Write("Enter choice: ");
                string stageChoice = Console.ReadLine();

                LifeStage stage = BuildLifeStage(stageChoice);

                if (stage == null)
                {
                    Console.WriteLine("Invalid life stage choice.");
                    Console.WriteLine();
                    continue;
                }

                RecommendationResult result = _engine.GetRecommendations(insect, season, stage);

                Console.WriteLine();
                Console.WriteLine("----- Recommendation Results -----");
                Console.WriteLine("Insect: " + insect.Name);
                Console.WriteLine("Season: " + season.Name);
                Console.WriteLine("Life Stage: " + stage.Name);
                Console.WriteLine();

                if (result.Flies.Count == 0)
                {
                    Console.WriteLine("No exact matches were found.");
                    Console.WriteLine("Try changing the season or life stage.");
                }
                else
                {
                    Console.WriteLine("Recommended flies:");

                    foreach (Fly fly in result.Flies)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Name: " + fly.Name);
                        Console.WriteLine("Fly Type: " + fly.FlyType);
                        Console.WriteLine("Imitates: " + fly.InsectName);
                        Console.WriteLine("Season: " + fly.SeasonName);
                        Console.WriteLine("Life Stage: " + fly.LifeStageName);
                        Console.WriteLine("Presentation: " + fly.GetPresentationTip());
                        Console.WriteLine("Why this fly: " + fly.GetImitationDescription());
                    }
                }

                Console.WriteLine();
                Console.Write("Would you like to search again? (y/n): ");
                string again = Console.ReadLine();

                if (again.ToLower() != "y")
                {
                    running = false;
                    Console.WriteLine("Goodbye!");
                }

                Console.WriteLine();
            }
        }

        private Insect BuildInsect(string choice)
        {
            switch (choice)
            {
                case "1":
                    return new Insect("Midge");
                case "2":
                    return new Insect("Mayfly");
                case "3":
                    return new Insect("Stonefly");
                case "4":
                    return new Insect("Caddis");
                case "5":
                    return new Insect("Scud");
                case "6":
                    return new Insect("Terrestrials");
                default:
                    return null;
            }
        }

        private Season BuildSeason(string choice)
        {
            switch (choice)
            {
                case "1":
                    return new Season("Winter");
                case "2":
                    return new Season("Spring");
                case "3":
                    return new Season("Summer");
                case "4":
                    return new Season("Fall");
                default:
                    return null;
            }
        }

        private LifeStage BuildLifeStage(string choice)
        {
            switch (choice)
            {
                case "1":
                    return new LifeStage("Larva/Nymph");
                case "2":
                    return new LifeStage("Emerger");
                case "3":
                    return new LifeStage("Dun/Adult");
                default:
                    return null;
            }
        }
    }
}