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

        public TwoDShape(TwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
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

        public Triangle(string s, double w, double h) : base(w, h)
        {
            style = s;
        }

        public Triangle(double x) : base(x)
        {
            style = "Равнобедренный";
        }

        public  Triangle(Triangle ob): base(ob)
        {
            style = ob.style;
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

    
    class Shapes7
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle("прямоугольный", 8.0, 12.0);
            Triangle t2 = new Triangle(t1);

           
            Console.WriteLine("Сведения об объекте t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Площадь равна: " + t1.Area());
           
            Console.WriteLine();
            
            Console.WriteLine("Сведения об объекте t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Площадь равна: " + t2.Area());
        }
    }
}
