using System;
using FracArray;
namespace FracArray;
public class FractionArray
{
    private Fraction[] arr;
    private int size;

    // Конструктор без параметров
    public FractionArray()
    {
        size = 0;
        arr = new Fraction[size];
    }

    // Конструктор с параметром для создания массива со случайными значениями
    public FractionArray(int size)
    {
        this.size = size;
        arr = new Fraction[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            int numerator = rand.Next(1, 10);
            int denominator = rand.Next(1, 10);
            arr[i] = new Fraction(numerator, denominator);
        }
    }

    // Конструктор для заполнения массива значениями, введенными пользователем
    public FractionArray(int size, bool userInput)
    {
        this.size = size;
        arr = new Fraction[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Введите числитель для дроби {i + 1}:");
            int numerator = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите знаменатель для дроби {i + 1}:");
            int denominator = int.Parse(Console.ReadLine());

            arr[i] = new Fraction(numerator, denominator);
        }
    }

    // Индексатор для доступа к элементам массива
    public Fraction this[int index]
    {
        get
        {
            if (index >= 0 && index < size)
                return arr[index];
            throw new IndexOutOfRangeException("Неверный индекс");
        }
        set
        {
            if (index >= 0 && index < size)
                arr[index] = value;
            else
                throw new IndexOutOfRangeException("Неверный индекс");
        }
    }

    // Метод для просмотра элементов массива
    public void DisplayArray()
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Элемент {i + 1}: {arr[i]}");
        }
    }
}
