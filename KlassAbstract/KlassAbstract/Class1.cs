using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KlassAbstract
{
    public abstract class Goods
    {
        public string Type { get; set; }

        public abstract void Display();

        public bool IsOfType(string type)
        {
            return Equals(type, Type);
        }
    }
    public class Toy : Goods
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public int Age { get; set; }

        public Toy(string name, string manufacturer, int price, int age)
        {
            Type = "Игрушка";
            Name = name;
            Price = price;
            Age = age;
            Manufacturer = manufacturer;
        }
        public override void Display()
        {
            Console.WriteLine($"Тип:{Type}");
            Console.WriteLine($"Название:{Name}");
            Console.WriteLine($"Производитель:{Manufacturer}");
            Console.WriteLine($"Возраст:{Age}");
            Console.WriteLine($"Цена:{Price}");
        }
    }
    public class Book : Goods
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public string Publisher { get; set; }
        public int Age { get; set; }

        public Book(string name, string author, int price, string publisher, int age)
        {
            Type = "Книга";
            Name = name;
            Author = author;
            Price = price;
            Publisher = publisher;
            Age = age;
        }
        public override void Display()
        {
            Console.WriteLine($"Тип:{Type}");
            Console.WriteLine($"Название:{Name}");
            Console.WriteLine($"Автор:{Author}");
            Console.WriteLine($"Цена:{Price}");
            Console.WriteLine($"Издательство:{Publisher}");
            Console.WriteLine($"Возраст:{Age}");
        }
    }
    public class SportsEquipment : Goods
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public int Age { get; set; }

        public SportsEquipment(string name, int price, string manufacturer, int age)
        {
            Type = "Спортивная экипировка";
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Age = age;
        }
        public override void Display() 
        {
            Console.WriteLine($"Тип: {Type}");
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Производитель: {Manufacturer}");
            Console.WriteLine($"Возраст: {Age}");
        }
    }
}

            

