public class RecurringChecklistGoal : ChecklistGoal
// This class is a checklist goal that resets once the target completion count is reached, 
// allowing the user to obtain bonus points more than once.
// This could just be added to ChecklistGoal, but this seemed like the easiest way to add to ChecklistGoal
// without changing its behavior in a way that would require additional user input. (also, I wanted to try doing this)
{
    // TODO: is there a way that I could use the constructors in ChecklistGoal to simplify this?
    public RecurringChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
    : base(name, description, points, targetCount, bonusPoints)
    {
        
    }

    // This is used when loading from file
    public RecurringChecklistGoal(string name, string description, int points, int completionCount, int targetCount, int bonusPoints) 
    : base(name, description, points, completionCount, targetCount, bonusPoints)
    {
        
    }

    public override int RecordEvent()
    {
        int basePoints = GetPoints();

        // If the goal was complete the last time that it was recorded, then it is reset to one.
        if (IsComplete())
        {
            _completionCount = 1;
            return basePoints;
        }
        else
        {
            _completionCount ++;
            if (IsComplete())
            {
                return basePoints + _bonusPoints;
            }
            else
            {
                return basePoints;
            }
        }
    }

    public override string GetStringRepresentation()
    {
        string goal = $"RecurringChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_completionCount},{_targetCount},{_bonusPoints}";
        return goal;
    }
}