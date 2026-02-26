using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _r;

    public ReflectionActivity()
        : base("Reflection Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
               "This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _r = new Random();

        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    protected override void DoActivity()
    {
        Console.WriteLine();
        int pick = _r.Next(_prompts.Count);
        Console.WriteLine("Prompt:");
        Console.WriteLine("  " + _prompts[pick]);
        Console.WriteLine();

        Console.WriteLine("Think about it. Press Enter when ready...");
        Console.ReadLine();

        Console.WriteLine("Now answer these in your head:");
        Spinner(2);
        Console.WriteLine();

        int seconds = GetDurationSeconds();

        DateTime start = DateTime.Now;

        while (true)
        {
            TimeSpan diff = DateTime.Now - start;
            if (diff.TotalSeconds >= seconds)
            {
                break;
            }

            int qi = _r.Next(_questions.Count);
            Console.Write("> " + _questions[qi] + " ");
            Spinner(6);
            Console.WriteLine();
        }
    }
}