class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"You earned {_points} points!");
        if (_currentCount == _targetCount)
        {
            Console.WriteLine($"Bonus! You completed the goal and earned {_bonusPoints} extra points!");
        }
    }

    public override bool IsComplete() => _currentCount >= _targetCount;
    public override string GetStatus() => IsComplete() ? "[X]" : $"[{_currentCount}/{_targetCount}]";
    public override string GetStringRepresentation() => $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetCount}|{_currentCount}|{_bonusPoints}";
}
