using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
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
        public TwoDShape()
        {
            Width = Height = 0;
        }

        public TwoDShape(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public TwoDShape(double x)
        {
            Width = Height = x;
        }

        public void ShowDim()
        {
            Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
        }
    }

    class Triangle : TwoDShape
    {
        private string style;

        public Triangle()
        {
            style = "null";
        }

        public Triangle(string s, double w, double h): base(w, h)
        {
            style = s;
        }

        public Triangle(double x): base(x)
        {
            style = "Равнобедренный";
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

    class ColorTriangle:Triangle
    {
        string color;

        public ColorTriangle(string c, string s, double w, double h):base(s,w,h)
        {
            color = c;
        }
        public void ShowColor()
        {
            Console.WriteLine("Цвет " + color);
        }
    }
    class Shapes6
    {
        static void Main(string[] args)
        {
            ColorTriangle t1 = new ColorTriangle("синий", "прямоугольный", 8.0, 12.0);
            ColorTriangle t2 = new ColorTriangle("красный", "равнобедренный", 2.0, 2.0);

            Console.WriteLine("Сведения об объекте t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            t1.ShowColor();
            Console.WriteLine("Площадь равна: " + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Сведения об объекте t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            t2.ShowColor();
            Console.WriteLine("Площадь равна: " + t2.Area());
        }
    }
}
