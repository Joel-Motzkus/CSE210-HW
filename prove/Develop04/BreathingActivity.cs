using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by walking you through breathing in and out slowly. " +
               "Clear your mind and focus on your breathing.")
    {
    }

    protected override void DoActivity()
    {
        Console.WriteLine("Let's do breathing.");
        Spinner(2);
        Console.WriteLine();

        int total = GetDurationSeconds();
        int used = 0;

        while (used < total)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.WriteLine();
            used = used + 4;

            if (used >= total)
            {
                break;
            }

            Console.Write("Breathe out... ");
            Countdown(4);
            Console.WriteLine();
            used = used + 4;
        }
    }
}