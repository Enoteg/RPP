using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassAbstract
{
    class Program
    {
        static void Main()
        {
            Goods moloko = new Toy("Робот", "дед максим", 6, 2500);
            Goods hleb = new Book("Война и мир", "Л.Н.Толстой", 300000000, "какое-то издательство хз",18);

            hleb.Display();
            moloko.Display();
        }
    }
}
