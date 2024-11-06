using System;
namespace FracArray;
public class Time
{
    private static int count = 0;
    private int hours;
    private int minutes;

    public Time(int hours = 0, int minutes = 0)
    {
        Hours = hours;
        Minutes = minutes;
        count++;
    }

    public int Hours
    {
        get { return hours; }
        set
        {
            if (value >= 0)
                hours = value;
            else
                throw new ArgumentException("Часы не могут быть меньше 0");
        }
    }

    public int Minutes
    {
        get { return minutes; }
        set
        {
            if (value >= 0)
                minutes = value;
            else
                throw new ArgumentException("Минуты не могут быть меньше 0");
        }
    }

    // Метод для отображения времени
    public void Display()
    {
        Console.WriteLine($"{hours} часов, {minutes} минут");
    }

    // Метод для получения времени в минутах (вспомогательный)
    public int ToMinutes()
    {
        return hours * 60 + minutes;
    }

    // Статический метод для поиска максимального значения среди массива Time
    public static Time Max(Time[] times)
    {
        if (times == null || times.Length == 0)
        {
            throw new ArgumentException("Массив не может быть пустым");
        }

        Time maxTime = times[0];
        foreach (var time in times)
        {
            if (time.ToMinutes() > maxTime.ToMinutes())
            {
                maxTime = time;
            }
        }
        return maxTime;
    }

    public static int GetObjectCount()
    {
        return count;
    }
}
