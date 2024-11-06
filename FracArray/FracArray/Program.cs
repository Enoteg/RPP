namespace FracArray;
public class Program
{
    public static void Main(string[] args)
    {
        Time[] times = new Time[]
        {
            new Time(2, 30),
            new Time(3, 45),
            new Time(1, 50),
            new Time(4, 10)
        };

        Console.WriteLine("Список времени:");
        foreach (var time in times)
        {
            time.Display();
        }

        // Поиск максимального значения
        Time maxTime = Time.Max(times);
        Console.WriteLine("\nМаксимальное значение времени:");
        maxTime.Display();

        // Подсчет количества созданных объектов Time
        Console.WriteLine("\nКоличество созданных объектов Time: " + Time.GetObjectCount());
    }
}
