using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону прямоугольника");
            double userSide1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоугольника");
            double userSide2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rect1 = new Rectangle(23.5, 45.2);

            Console.WriteLine("Площадь:");
            Console.WriteLine(rect1.Area);
            Console.WriteLine("Периметр:");
            Console.WriteLine(rect1.Perimeter);

            Console.ReadKey();
        }
    }
}
