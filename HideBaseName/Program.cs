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
    }

    class B : A
    {
       new int i;
        public B(int b)
        {
            i = b;
        }

        public void Show()
        {
            Console.WriteLine("Член i в производном классе: " + i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B ob = new B(2);
            ob.Show();
        }
    }
}
