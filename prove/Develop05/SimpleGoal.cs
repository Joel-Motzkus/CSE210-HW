using System;

class SimpleGoal : Goal
{
    private bool _done;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _done = false;
    }

    public SimpleGoal(string name, string description, int points, bool done)
        : base(name, description, points)
    {
        _done = done;
    }

    public override int RecordEvent()
    {
        if (_done == false)
        {
            _done = true;
            return GetPoints();
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        if (_done == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStatusText()
    {
        string mark = "[ ]";

        if (_done == true)
        {
            mark = "[X]";
        }

        return mark + " " + GetName() + " (" + GetDescription() + ")";
    }

    public override string GetSaveString()
    {
        return "SimpleGoal|" + GetName() + "|" + GetDescription() + "|" + GetPoints() + "|" + _done;
    }
}