public class ChecklistGoal : Goal
{
    private int _completionCount;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
    : base(name, description, points)
    {
        _completionCount = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    // TODO: make sure that this wont do anything if it's already been completed to the bonus amount
    {
        _completionCount ++;

        int basePoints = GetPoints();
        if (IsComplete())
        {
            return basePoints + _bonusPoints;
        }

        else
        {
            return basePoints;
        }
    }

    public override bool IsComplete()
    {
        if (_completionCount == _targetCount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        // TODO: Double check that this works
        string baseDetails = base.GetDetailsString();
        return baseDetails + $" -- Currently Completed: {_completionCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        // TODO
        return "";
    }
}