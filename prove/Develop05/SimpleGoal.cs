public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // used for loading from file
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
            return GetPoints();
        }
        else
        {
            Console.WriteLine("This goal has already been completed");
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string goal = $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
        return goal;
    }
}