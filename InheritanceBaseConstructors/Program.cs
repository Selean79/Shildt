//Добавление  дополнительных конструкторов  в базовый класс

using System;

namespace InheritanceBaseConstruct
{
    class TwoDShape
    {
        private double pri_width;
        private double pri_height;

        public TwoDShape()  //конструктор по умолчанию
        {
            Width = Height = 0;
        }

        public TwoDShape(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public TwoDShape(double x) //Сконструировать объект равной ширине и высоте
        {
            Width = Height = x;
        }

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

        public Triangle()
        {
            style = "null";
        }

        public Triangle(string s, double w, double h)// : base(w, h)
        {
          //  Width = w;
         //   Height = h;
            style = s;
        }

        public Triangle(double x) : base(x)
        {
            style = "равноберенный";
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
            Triangle t1 = new Triangle();
           // Triangle t2 = new Triangle("равнобедренный", 4.0, 4.0);
            Triangle t2 = new Triangle("прямоугольный", 8.0, 12.0);
            Triangle t3 = new Triangle(4.0);

            t1 = t2;

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

            Console.WriteLine("Сведения об объекте t3:");
            t3.ShowStyle();
            t3.ShowDim();
            Console.WriteLine("Площадь треугольника равна: " + t3.Area());
            Console.WriteLine();

        }
    }
}
