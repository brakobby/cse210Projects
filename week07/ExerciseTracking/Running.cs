using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthInMinutes) * 60; // mph
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance(); // min per mile
    }
}
