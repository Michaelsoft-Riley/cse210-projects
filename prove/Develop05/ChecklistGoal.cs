public class ChecklistGoal : Goal
{
    // These attributes aren't private because RecurringChecklistGoal needs access to them
    protected int _completionCount;
    protected int _targetCount;
    protected int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
    : base(name, description, points)
    {
        _completionCount = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    // Used when loading from file
    public ChecklistGoal(string name, string description, int points,int completionCount, int targetCount, int bonusPoints) 
    : base(name, description, points)
    {
        _completionCount = completionCount;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
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
        
        else
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
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
        string goal = $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_completionCount},{_targetCount},{_bonusPoints}";
        return goal;
    }
}