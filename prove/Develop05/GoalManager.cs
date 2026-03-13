using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Types of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("How many points is it worth? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            Goal g = new SimpleGoal(name, description, points);
            _goals.Add(g);
            Console.WriteLine("Simple goal created.");
        }
        else if (type == "2")
        {
            Goal g = new EternalGoal(name, description, points);
            _goals.Add(g);
            Console.WriteLine("Eternal goal created.");
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be completed? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for finishing it? ");
            int bonus = int.Parse(Console.ReadLine());

            Goal g = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(g);
            Console.WriteLine("Checklist goal created.");
        }
        else
        {
            Console.WriteLine("That was not a valid goal type.");
        }

        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    public void ListGoals()
    {
        Console.Clear();

        if (_goals.Count == 0)
        {
            Console.WriteLine("You do not have any goals yet.");
        }
        else
        {
            Console.WriteLine("Your goals are:");
            Console.WriteLine();

            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + _goals[i].GetStatusText());
            }
        }

        Console.WriteLine();
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    public void RecordEvent()
    {
        Console.Clear();

        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals to record.");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("The goals are:");
        Console.WriteLine();

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + _goals[i].GetName());
        }

        Console.WriteLine();
        Console.Write("Which goal did you accomplish? ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 1 && num <= _goals.Count)
        {
            int pointsEarned = _goals[num - 1].RecordEvent();
            _score = _score + pointsEarned;

            if (pointsEarned > 0)
            {
                Console.WriteLine("You earned " + pointsEarned + " points!");
                Console.WriteLine("Your total score is now " + _score + ".");
            }
            else
            {
                Console.WriteLine("No points earned for that goal.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }

        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    public void SaveGoals()
    {
        Console.Clear();
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(file))
        {
            output.WriteLine(_score);

            for (int i = 0; i < _goals.Count; i++)
            {
                output.WriteLine(_goals[i].GetSaveString());
            }
        }

        Console.WriteLine("Saved.");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    public void LoadGoals()
    {
        Console.Clear();
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();

        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);

            _goals.Clear();

            if (lines.Length > 0)
            {
                _score = int.Parse(lines[0]);
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                string kind = parts[0];

                if (kind == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool done = bool.Parse(parts[4]);

                    Goal g = new SimpleGoal(name, description, points, done);
                    _goals.Add(g);
                }
                else if (kind == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    Goal g = new EternalGoal(name, description, points);
                    _goals.Add(g);
                }
                else if (kind == "ChecklistGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int amountDone = int.Parse(parts[6]);

                    Goal g = new ChecklistGoal(name, description, points, target, bonus, amountDone);
                    _goals.Add(g);
                }
            }

            Console.WriteLine("Loaded.");
        }
        else
        {
            Console.WriteLine("That file does not exist.");
        }

        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }
}