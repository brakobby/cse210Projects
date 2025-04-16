// SimpleGoal.cs
class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _completed = false;
    }

    public override void RecordEvent()
    {
        _completed = true;
        Console.WriteLine($"You earned {_points} points!");
    }

    public override bool IsComplete() => _completed;
    public override string GetStatus() => IsComplete() ? "[X]" : "[ ]";
    public override string GetStringRepresentation() => $"SimpleGoal|{_name}|{_description}|{_points}|{_completed}";
}
