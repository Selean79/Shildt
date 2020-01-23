using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideBaseName
{
    class A
    {
        public int i = 0;

        public void Show()
        {
            Console.WriteLine("Член i в базовом классе: " + i);
        }
    }

    class B : A
    {
       new int i;
        public B(int a, int b)
        {
            base.i = a;
            i = b;
        }

       new public void Show()
        {
            base.Show();
            Console.WriteLine("Член i в производном классе: " + i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B ob = new B(1, 2);
            ob.Show();
        }
    }
}
