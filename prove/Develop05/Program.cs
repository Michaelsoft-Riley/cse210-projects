using System;

class Program
// Added a recurring checklist goal that resets its completion count to 1 once it is ran after
// reaching its target count. This class inherits from ChecklistGoal.
{
    static void Main(string[] args)
    {
        GoalManager goalManager= new();
        goalManager.Start();
    }
}