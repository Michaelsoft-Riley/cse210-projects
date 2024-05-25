public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        // This will never return true. These goals are eternal.
        return false;
    }

    public override string GetStringRepresentation()
    {
        string goal = $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
        return goal;
    }
}