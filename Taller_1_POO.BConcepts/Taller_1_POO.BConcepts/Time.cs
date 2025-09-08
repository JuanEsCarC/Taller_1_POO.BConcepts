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
            _hour = ValidHour(value);
        }
    }

    public int Minute
    {
        get => _minute;
        set
        {
            _minute = ValidMinute(value);
        }
    }

    public int Second
    {
        get => _second;
        set
        {
            _second = ValidSecond(value);
        }
    }

    public int Millisecond
    {
        get => _millisecond;
        set
        {
            _millisecond = ValidMillisecond(value);
        }
    }


    //Methods

    public Time Add(Time otherTime)
    {
        long totalMilliseconds = this.Millisecond + otherTime.Millisecond;
        long newMillisecond = totalMilliseconds % 1000;
        long carrySeconds = totalMilliseconds / 1000;

        long totalSeconds = this.Second + otherTime.Second + carrySeconds;
        long newSecond = totalSeconds % 60;
        long carryMinutes = totalSeconds / 60;

        long totalMinutes = this.Minute + otherTime.Minute + carryMinutes;
        long newMinute = totalMinutes % 60;
        long carryHours = totalMinutes / 60;

        long totalHours = this.Hour + otherTime.Hour + carryHours;
        long newHour = totalHours % 24;

        return new Time((int)newHour, (int)newMinute, (int)newSecond, (int)newMillisecond);
    }

    public bool IsOtherDay(Time otherTime)
    {
        long totalMilliseconds = this.ToMilliseconds() + otherTime.ToMilliseconds();
        return totalMilliseconds >= 24 * 60 * 60 * 1000;
    }

    public long ToMilliseconds()
    {
        return (long)Hour * 60 * 60 * 1000 + (long)Minute * 60 * 1000 + (long)Second * 1000 + Millisecond;
    }

    public long ToSeconds()
    {
        return ToMilliseconds() / 1000;
    }

    public long ToMinutes()
    {
        return ToSeconds() / 60;
    }

    public override string ToString()
    {

        int _Hour = Hour % 12;
        if (_Hour == 0)
        {
            _Hour = 0;
        }

        string tt = (Hour >= 12) ? "PM" : "AM";

        return $"{_Hour:00}:{Minute:00}:{Second:00}.{Millisecond:000} {tt}";
    }

    private int ValidHour(int hour)
    {
        if (hour < 0 || hour > 23)
        {
            throw new Exception($"The hour: {hour}, is not valid.");
        }
        return hour;
    }

    private int ValidMinute(int minute)
    {
        if (minute < 0 || minute > 59)
        {
            throw new Exception($"The minute: {minute}, is not valid.");
        }
        return minute;
    }

    private int ValidSecond(int second)
    {
        if (second < 0 || second > 59)
        {
            throw new Exception($"The second: {second}, is not valid.");
        }
        return second;
    }

    private int ValidMillisecond(int millisecond)
    {
        if (millisecond < 0 || millisecond > 999)
        {
            throw new Exception($"The millisecond: {millisecond}, is not valid.");
        }
        return millisecond;
    }

}