using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Figure
    {
        private Point[] points;
        private string name;

        public Figure(Point[] points)
        {
            if (points.Length < 3 && points.Length > 5)
            {
                throw new ArgumentException("Out of range");
            }

            this.points = points;
        }

        public string Name
        {
            get
            {
                if (points.Length == 3)
                {
                    name = "Треугольник";
                    return name;
                }
                else if (points.Length == 4)
                {
                    name = "Четырехугольник";
                    return name;
                }
                else
                {
                    name = "Пятиугольник";
                    return name;
                }
            }
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimetr = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimetr += LengthSide(points[i], points[i + 1]);
            }

            perimetr += LengthSide(points[points.Length - 1], points[0]);

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Perimetr: {perimetr}");
        }
    }
}
