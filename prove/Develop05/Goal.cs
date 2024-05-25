public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string checkmark;

        // Check box in string output if the goal is complete
        if (IsComplete())
        {checkmark = "X";}
        else
        {checkmark = " ";}

        return $"[{checkmark}] {_name} ({_description})";
    }
    public abstract string GetStringRepresentation();
}