using System;

class ChecklistGoal : Goal
{
    private int _amountDone;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountDone = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountDone)
        : base(name, description, points)
    {
        _amountDone = amountDone;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_amountDone < _target)
        {
            _amountDone = _amountDone + 1;

            if (_amountDone == _target)
            {
                return GetPoints() + _bonus;
            }
            else
            {
                return GetPoints();
            }
        }

        return 0;
    }

    public override bool IsComplete()
    {
        if (_amountDone >= _target)
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

        if (IsComplete())
        {
            mark = "[X]";
        }

        return mark + " " + GetName() + " (" + GetDescription() + ") -- Completed " + _amountDone + "/" + _target + " times";
    }

    public override string GetSaveString()
    {
        return "ChecklistGoal|" + GetName() + "|" + GetDescription() + "|" + GetPoints() + "|" + _target + "|" + _bonus + "|" + _amountDone;
    }
}