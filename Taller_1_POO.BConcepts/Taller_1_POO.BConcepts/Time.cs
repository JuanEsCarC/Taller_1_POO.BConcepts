namespace Taller_1_POO.BConcepts.Core;

public class Time
{

    //Fields
    private int _hour;
    private int _millisecond;
    private int _minute;
    private int _second;



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






}
