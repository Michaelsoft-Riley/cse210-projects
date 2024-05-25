public class GoalManager
{
    private List<Goal> _goals = [];
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        // Menu
        string choice;
        do
        {
            // TODO: Make sure that the score is loaded before this?
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  2. Load Goals");
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

            }

            else if (choice == "4")
            {

            }

            else if (choice == "5")
            {

            }

            else if (choice == "6")
            {

            }
        } while (choice != "6");
    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    // Display a list of goal details to the console
    {
        int goalNumber = 1;
        foreach (Goal goal in _goals)
        {
            string details = goal.GetDetailsString();
            Console.WriteLine($"{goalNumber}. " + details);
        }
    }

    public void CreateGoal()
    // Create a new goal from user input, and add it to _goals
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("How many points should you recieve for completion? ");
            int points = int.Parse(Console.ReadLine());

            _goals.Add(new SimpleGoal(name, description, points));
        }

        else if (choice == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with it? ");
            int points = int.Parse(Console.ReadLine());

            _goals.Add(new EternalGoal(name, description, points));
        }

        else if (choice == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with it?");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be completed for a bonus? ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for completing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonus));
        }
    }

    public void RecordEvent()
    {
        
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}