using System.Text.Json;
public class GoalManager
{
    public List<Goal> Goals { get; set; }
    public int Score { get; private set; }

    public GoalManager()
    {
        Goals = new List<Goal>();
        Score = 0;
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(string goalDescription)
    {
        foreach (var goal in Goals)
        {
            if (goal.Description == goalDescription)
            {
                goal.RecordEvent();
                Score += goal.Points;
                break;
            }
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {Score}");
    }

    public void ShowGoals()
    {
        foreach (var goal in Goals)
        {
            Console.WriteLine(goal.Display());
        }
    }

    public void SaveProgress(string filePath)
    {
        using (Stream stream = File.Open(filePath, FileMode.Create))
        {
             Serializer.Serialize(stream, this);
        }
    }

    public static GoalManager LoadProgress(string filePath)
    {
        using (Stream stream = File.Open(filePath, FileMode.Open))
        {
             return Serializer.Deserialize<GoalManager>(stream);
        }
    }
}

internal class Serializer
{
    internal static T Deserialize<T>(Stream stream)
    {
        if (stream == null)
            throw new ArgumentNullException(nameof(stream));

        return JsonSerializer.Deserialize<T>(new StreamReader(stream).ReadToEnd());
    }

    internal static void Serialize(Stream stream, GoalManager goalManager)
    {
        if (stream == null)
            throw new ArgumentNullException(nameof(stream));
        if (goalManager == null)
            throw new ArgumentNullException(nameof(goalManager));

        var options = new JsonSerializerOptions
        {
            WriteIndented = true // For better readability of the output JSON
        };

        string jsonString = JsonSerializer.Serialize(goalManager, options);
        using (var writer = new StreamWriter(stream))
        {
            writer.Write(jsonString);
        }
    }
}
