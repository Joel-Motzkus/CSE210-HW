using System;
using System.Threading;

class Activity
{
    private string _name;
    private string _description;
    private int _duration; // seconds

    public Activity(string name, string desc)
    {
        _name = name;
        _description = desc;
        _duration = 0;
    }

    public void Run()
    {
        StartStuff();
        DoActivity();
        EndStuff();
    }

    protected virtual void DoActivity()
    {

    }

    protected int GetDurationSeconds()
    {
        return _duration;
    }

    protected void StartStuff()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine(_name);
        Console.WriteLine("====================================");
        Console.WriteLine(_description);
        Console.WriteLine();

        int seconds = 0;
        bool ok = false;

        while (ok == false)
        {
            Console.Write("How long, in seconds? ");
            string s = Console.ReadLine();

            if (s == null) s = "";

            if (int.TryParse(s, out seconds))
            {
                if (seconds > 0)
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("It has to be > 0.");
                }
            }
            else
            {
                Console.WriteLine("That isn't a number.");
            }
        }

        _duration = seconds;

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        Spinner(3);
        Console.WriteLine();
    }

    protected void EndStuff()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        Spinner(3);

        Console.WriteLine();
        Console.WriteLine("You finished: " + _name);
        Console.WriteLine("Time: " + _duration + " seconds");
        Spinner(4);
        Console.WriteLine();
        Console.WriteLine("Press Enter to go back to menu...");
        Console.ReadLine();
    }

    protected void Spinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        int ms = seconds * 1000;

        int passed = 0;
        int i = 0;

        while (passed < ms)
        {
            Console.Write(frames[i]);
            Thread.Sleep(200);
            Console.Write("\b");

            passed += 200;
            i++;

            if (i >= frames.Length)
            {
                i = 0;
            }
        }

        Console.Write(" ");
        Console.Write("\b");
    }

    protected void Countdown(int seconds)
    {
        int x = seconds;

        while (x > 0)
        {
            Console.Write(x);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            x = x - 1;
        }
    }
}