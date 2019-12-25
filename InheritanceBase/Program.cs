//Добавление конструктора в производный класс

using System;

namespace InheritanceBase
{
    class TwoDShape
    {
        private double pri_width;
        private double pri_height;

        public double Width
        {
            get
            {
                return pri_width;
            }
            set
            {
                pri_width = value < 0 ? -value : value;
            }
        }

        public double Height
        {
            get
            {
                return pri_height;
            }

            set
            {
                pri_height = value < 0 ? -value : value;
            }
        }

        public void ShowDim()
        {
            Console.WriteLine("Ширина и длина равны " + Width + " и " + Height);
        }
    }

    class Triangle : TwoDShape
    {
        string style;

        public Triangle(string s, double w, double h)
        {
            Width = w;
            Height = h;
            style = s;
        }

        public double Area()
        {
            return Width * Height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Треугольник " + style);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle("равнобедренный", 4.0, 4.0);
            Triangle t2 = new Triangle("прямоугольный", 8.0, 12.0);

            Console.WriteLine("Сведения об объекте t1:");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Площадь треугольника равна: " + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Сведения об объекте t2:");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Площадь треугольника равна: " + t2.Area());
            Console.WriteLine();

        }
    }
}
