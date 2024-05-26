public class GoalManager
{
    private List<Goal> _goals = [];
    private int _score = 0;

    public GoalManager()
    {}

    public void Start()
    {
        // Menu
        string choice;
        do
        {
            // TODO: Make sure that the score is loaded before this?
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }

            else if (choice == "2")
            {
                ListGoalDetails();
            }

            else if (choice == "3")
            {
                SaveGoals();
            }

            else if (choice == "4")
            {
                LoadGoals();
            }

            else if (choice == "5")
            {
                RecordEvent();
            }

            else if (choice == "6")
            {

            }
        } while (choice != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void ListGoalNames()
    {
        int goalNumber = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goalNumber}. {goal.GetName()}");
            goalNumber ++;
        }
    }

    public void ListGoalDetails()
    // Display a list of goal details to the console
    {
        Console.WriteLine("The goals are:");

        int goalNumber = 1;
        foreach (Goal goal in _goals)
        {
            string details = goal.GetDetailsString();
            Console.WriteLine($"{goalNumber}. " + details);
            goalNumber ++;
        }
    }

    public void CreateGoal()
    // Create a new goal from user input, and add it to _goals
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("  4. Recurring Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with it? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }

        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }

        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be completed for a bonus? ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for completing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonus));
        }

        else if (choice == "4")
        {
            Console.Write("How many times does this goal need to be completed for a bonus? ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for completing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new RecurringChecklistGoal(name, description, points, targetCount, bonus));
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The Goals are:");

        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        string choice = Console.ReadLine();

        // convert user choice to goal index value
        int goalIndex = int.Parse(choice) - 1;

        // Mark goal as completed once, get points earned from completion, and add points to overall score.
        int earnedPoints = _goals[goalIndex].RecordEvent();
        _score += earnedPoints;

        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        Console.WriteLine($"You now have {_score} points");
    }

    public void SaveGoals()
    // Save score and goals to file
    {
        using (StreamWriter file = new StreamWriter("goals.txt"))
        {
            file.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    // This loads a score and goals from goals.txt
    // Goals are expected to start with the format "Type:name,description,points"
    {
        string[] lines = File.ReadAllLines("goals.txt");

        // Get _score from the first line
        _score += int.Parse(lines[0]);

        foreach (string line in lines)
        {
            // Any lines that do not specify a goal type will be skipped
            if (!line.Contains(':'))
            {
                continue;
            }

            string[] parts = line.Split(":");
            string[] goalDetails = parts[1].Split(",");

            string name = goalDetails[0];
            string description = goalDetails[1];
            int points = int.Parse(goalDetails[2]);

            if (parts[0] == "SimpleGoal")
            {
                bool isComplete = bool.Parse(goalDetails[3]);
                _goals.Add(new SimpleGoal(name, description, points, isComplete));
            }

            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }

            else if (parts[0] == "ChecklistGoal")
            {
                int completionCount = int.Parse(goalDetails[3]);
                int targetCount = int.Parse(goalDetails[4]);
                int bonusPoints = int.Parse(goalDetails[5]);

                _goals.Add(new ChecklistGoal(name, description, points, completionCount, targetCount, bonusPoints));
            }

            else if (parts[0] == "RecurringChecklistGoal")
            {
                int completionCount = int.Parse(goalDetails[3]);
                int targetCount = int.Parse(goalDetails[4]);
                int bonusPoints = int.Parse(goalDetails[5]);

                _goals.Add(new RecurringChecklistGoal(name, description, points, completionCount, targetCount, bonusPoints));
            }
        }
    }
}