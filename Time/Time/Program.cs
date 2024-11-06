using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите часы для первого времени:");
        int hours1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите минуты для первого времени:");
        int minutes1 = int.Parse(Console.ReadLine());

        Time time1 = new Time(hours1, minutes1);

        Console.WriteLine("Введите часы для второго времени:");
        int hours2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите минуты для второго времени:");
        int minutes2 = int.Parse(Console.ReadLine());

        Time time2 = new Time(hours2, minutes2);

        Console.WriteLine("\nВремя 1:");
        time1.Display();

        Console.WriteLine("Время 2:");
        time2.Display();

        Console.WriteLine("\nРезультат вычитания (статическая функция):");
        Time resultStatic = Time.Subtract(time1, time2);
        resultStatic.Display();

        Console.WriteLine("Результат вычитания (метод класса):");
        Time resultMethod = time1.SubtractTime(time2);
        resultMethod.Display();

        Console.WriteLine("Количество созданных объектов: " + Time.GetObjectCount());
    }
}
