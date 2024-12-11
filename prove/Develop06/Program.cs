public class Program
{
    public static List<Achievement> achievements = new List<Achievement>
    {
        new Achievement("Goal Master", "Complete 5 goals to unlock this achievement."),
        new Achievement("Checklist Champion", "Complete a checklist goal to unlock this achievement."),
        new Achievement("Completionist", "Complete all available goals to unlock this achievement.")
    };

    public static void Main()
    {
        var goals = new List<Goal>();
        int totalPoints = 0;

        string command;
        do
        {
            Console.WriteLine("1. Add a Simple Goal");
            Console.WriteLine("2. Add an Eternal Goal");
            Console.WriteLine("3. Add a Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Show Goals");
            Console.WriteLine("6. Show Total Score");
            Console.WriteLine("7. Show Achievements");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");
            command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    AddSimpleGoal(goals);
                    break;
                case "2":
                    AddEternalGoal(goals);
                    break;
                case "3":
                    AddChecklistGoal(goals);
                    break;
                case "4":
                    totalPoints += RecordEvent(goals);
                    break;
                case "5":
                    ShowGoals(goals);
                    break;
                case "6":
                    Console.WriteLine($"Total Score: {totalPoints}");
                    break;
                case "7":
                    ShowAchievements();
                    break;
                case "8":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        } while (command != "8");
    }

    private static void ShowAchievements()
    {
        foreach (var achievement in achievements)
        {
            Console.WriteLine(achievement.DisplayAchievement());
        }
    }

    private static int RecordEvent(List<Goal> goals)
    {
        Console.WriteLine("Select the goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].DisplayGoal()}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();

            
            if (goals[index] is ChecklistGoal checklistGoal && checklistGoal.IsComplete)
            {
                achievements[1].Unlock(); 
            }

           
            if (goals.Count(g => g.IsComplete) >= 5)
            {
                achievements[0].Unlock(); 
            }

            if (goals.All(g => g.IsComplete))
            {
                achievements[2].Unlock(); // Unlock Completionist achievement
            }

            return goals[index].PointValue + (goals[index] is ChecklistGoal checklist ? checklist.GetBonusPoints() : 0);
        }

        Console.WriteLine("Invalid goal selection.");
        return 0;
    }

    private static void AddSimpleGoal(List<Goal> goals)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter point value: ");
        int pointValue = int.Parse(Console.ReadLine());
        goals.Add(new SimpleGoal(name, pointValue));
    }

    private static void AddEternalGoal(List<Goal> goals)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter point value: ");
        int pointValue = int.Parse(Console.ReadLine());
        goals.Add(new EternalGoal(name, pointValue));
    }

    private static void AddChecklistGoal(List<Goal> goals)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter point value: ");
        int pointValue = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of times needed to complete: ");
        int requiredTimes = int.Parse(Console.ReadLine());
        goals.Add(new ChecklistGoal(name, pointValue, requiredTimes));
    }

    private static void ShowGoals(List<Goal> goals)
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayGoal());
        }
    }
}
