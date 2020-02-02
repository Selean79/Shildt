// Создание абстактного класса

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    abstract class TwoDShape
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

        public string Name { get; set; }

        public TwoDShape()
        {
            Width = Height = 0.0;
            Name = "null";
        }

        public TwoDShape(double w, double h, string n)
        {
            Width = w;
            Height = h;
            Name = n;
        }

        public TwoDShape(double x, string n)
        {
            Width = Height = x;
            Name = n;
        }

        public TwoDShape(TwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
            Name = ob.Name;
        }

        public void ShowDim()
        {
            Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
        }

        public abstract double Area();

        
    }

    class Triangle : TwoDShape
    {
        private string style;

        public Triangle()
        {
            style = "null";
        }

        public Triangle(string s, double w, double h) : base(w, h, "треугольник")
        {
            style = s;
        }

        public Triangle(double x) : base(x, "треугольник")
        {
            style = "Равнобедренный";
        }

        public Triangle(Triangle ob) : base(ob)
        {
            style = ob.style;
        }

        public override double Area()
        {
            return Width * Height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Треугольник " + style);
        }

         public virtual void Sealedmethod()
        { 
        }
        
    }

    class B : Triangle
    {
        public sealed override void Sealedmethod()
        {
            //base.Sealedmethod();    
        }
    }


    class Rectangle : TwoDShape
    {
        
       
        public Rectangle(double w, double h) : base(w, h, "прямоугольник")
        {
           
        }

        public Rectangle(double x) : base(x, "прямоугольник")
        {
            
        }

        public Rectangle(Rectangle ob) : base(ob)
        {
            
        }

        public override double Area()
        {
            return Width * Height;
        }

        public  bool IsSquare()
        {
            if (Width == Height)
            {
                return true;
            }
            return false;
        }
    }

    class Shapes7
    {
        static void Main(string[] args)
        {
            TwoDShape[] shapes = new TwoDShape[4];

            shapes[0] = new Triangle("прямоугольный", 8.0, 12.0);
            shapes[1] = new Rectangle(10);
            shapes[2] = new Rectangle(10.0, 4.0);
            shapes[3] = new Triangle(7.0);

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("Объект - " + shapes[i].Name);
                Console.WriteLine("Площадь равна " + shapes[i].Area());
                Console.WriteLine();
            }

            // Console.WriteLine(shapes[2].ShowDim());
        }
    }
}
