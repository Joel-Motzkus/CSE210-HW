using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _r;

    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _r = new Random();
        _prompts = new List<string>();

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    protected override void DoActivity()
    {
        Console.WriteLine();
        Console.WriteLine("List as many as you can for this prompt:");
        Console.WriteLine("  " + _prompts[_r.Next(_prompts.Count)]);
        Console.WriteLine();

        Console.Write("Starting in: ");
        Countdown(5);
        Console.WriteLine();
        Console.WriteLine("Type an item and press Enter each time:");

        int duration = GetDurationSeconds();
        DateTime start = DateTime.Now;

        int count = 0;

        // not clean: counts even blank lines, doesn’t store list, etc.
        while (true)
        {
            TimeSpan passed = DateTime.Now - start;
            if (passed.TotalSeconds >= duration)
            {
                break;
            }

            Console.Write("> ");
            string item = Console.ReadLine();
            if (item == null) item = "";

            // still count it no matter what (simple)
            count = count + 1;
        }

        Console.WriteLine();
        Console.WriteLine("You listed " + count + " items.");
        Spinner(2);
    }
}