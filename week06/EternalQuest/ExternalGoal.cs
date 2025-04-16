// EternalGoal.cs
class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) {}

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {_points} points!");
    }

    public override bool IsComplete() => false;
    public override string GetStatus() => "[∞]";
    public override string GetStringRepresentation() => $"EternalGoal|{_name}|{_description}|{_points}";
}
