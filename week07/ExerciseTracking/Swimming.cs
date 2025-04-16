using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000; // km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthInMinutes) * 60; // km/h
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance(); // min per km
    }
}
