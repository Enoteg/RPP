using System;

public class Time
{
    private static int count = 0;
    private int hours;
    private int minutes;

    // Основной конструктор
    public Time(int hours = 0, int minutes = 0, bool incrementCount = true)
    {
        Hours = hours;
        Minutes = minutes;

        // Увеличиваем счетчик только если это необходимо
        if (incrementCount)
        {
            count++;
        }
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

    public void Display()
    {
        Console.WriteLine($"{hours} часов, {minutes} минут");
    }

    public static Time Subtract(Time time1, Time time2)
    {
        int resultHours = time1.Hours - time2.Hours;
        int resultMinutes = time1.Minutes - time2.Minutes;

        if (resultMinutes < 0)
        {
            resultMinutes += 60;
            resultHours -= 1;
        }
        if (resultHours < 0)
        {
            resultHours = 0;
            resultMinutes = 0;
        }

        // Создаем новый объект Time без увеличения счетчика
        return new Time(resultHours, resultMinutes, incrementCount: false);
    }

    public Time SubtractTime(Time otherTime)
    {
        int resultHours = this.Hours - otherTime.Hours;
        int resultMinutes = this.Minutes - otherTime.Minutes;

        if (resultMinutes < 0)
        {
            resultMinutes += 60;
            resultHours -= 1;
        }
        if (resultHours < 0)
        {
            resultHours = 0;
            resultMinutes = 0;
        }

        // Создаем новый объект Time без увеличения счетчика
        return new Time(resultHours, resultMinutes, incrementCount: false);
    }

    public static int GetObjectCount()
    {
        return count;
    }

    // Перегрузка оператора ++ для добавления минуты
    public static Time operator ++(Time t)
    {
        t.minutes++;
        if (t.minutes >= 60)
        {
            t.minutes = 0;
            t.hours++;
        }
        return t;
    }

    // Перегрузка оператора -- для вычитания минуты
    public static Time operator --(Time t)
    {
        if (t.minutes > 0)
        {
            t.minutes--;
        }
        else if (t.hours > 0)
        {
            t.minutes = 59;
            t.hours--;
        }
        return t;
    }

    // Неявное приведение типа Time к int (всего минут)
    public static implicit operator int(Time t)
    {
        return t.hours * 60 + t.minutes;
    }

    // Явное приведение типа Time к bool
    public static explicit operator bool(Time t)
    {
        return t.hours != 0 || t.minutes != 0;
    }

    // Перегрузка оператора < для сравнения двух объектов Time
    public static bool operator <(Time t1, Time t2)
    {
        return (int)t1 < (int)t2;
    }

    // Перегрузка оператора > для сравнения двух объектов Time
    public static bool operator >(Time t1, Time t2)
    {
        return (int)t1 > (int)t2;
    }
}
