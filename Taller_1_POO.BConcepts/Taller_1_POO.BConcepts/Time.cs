namespace Taller_1_POO.BConcepts.Core;

public class Time
{

    //Fields
    private int _hour;
    private int _millisecond;
    private int _minute;
    private int _second;


    //Constructors
    public Time()
    {
        Hour = 0;
        Minute = 0;
        Second = 0;
        Millisecond = 0;
    }

    public Time(int hour)
    {
        Hour = hour;
    }

    public Time(int hour, int minute)
    {
        Hour = hour;
        Minute = minute;
    }

    public Time(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public Time(int hour, int minute, int second, int millisecond)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = millisecond;
    }


    //Public Properties
    public int Hour
    {
        get => _hour;
        set
        {
            _hour = value;
        }
    }

    public int Millisecond
    {
        get => _millisecond;
        set
        {
            _millisecond = value;
        }
    }

    public int Minute
    {
        get => _minute;
        set
        {
            _minute = value;
        }
    }

    public int Second
    {
        get => _second;
        set
        {
            _second = value;
        }
    }


    //Methods

    public override string ToString()
    {
        return $"{Hour:00}:{Minute:00}:{Second:00}.{Millisecond:000}";
    }



}
