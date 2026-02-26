using System;

class Program
{
    static void Main()
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            choice = Console.ReadLine();

            if (choice == null)
            {
                choice = "";
            }

            if (choice == "1")
            {
                Activity a = new BreathingActivity();
                a.Run();
            }
            else if (choice == "2")
            {
                Activity a = new ReflectionActivity();
                a.Run();
            }
            else if (choice == "3")
            {
                Activity a = new ListingActivity();
                a.Run();
            }
            else if (choice == "4")
            {
                // leave loop
            }
            else
            {
                Console.WriteLine("That was not a valid menu option.");
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
            }
        }

        Console.WriteLine("Bye.");
    }
}