using System;
class Program

{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        string input = "";

        while (input != "6")
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine();
            Console.WriteLine("You have " + manager.GetScore() + " points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            input = Console.ReadLine();

            if (input == "1")
            {
                manager.CreateGoal();
            }
            else if (input == "2")
            {
                manager.ListGoals();
            }
            else if (input == "3")
            {
                manager.SaveGoals();
            }
            else if (input == "4")
            {
                manager.LoadGoals();
            }
            else if (input == "5")
            {
                manager.RecordEvent();
            }
            else if (input == "6")
            {
                Console.WriteLine("Goodbye.");
            }
            else
            {
                Console.WriteLine("That is not a valid option.");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
            }
        }
    }
}