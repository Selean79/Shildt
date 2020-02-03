using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISeries
{
    class Interfacedemo
    {
        static void Main(string[] args)
        {
            ByTwos twoOb = new ByTwos();
            Primes primeOb = new Primes();
            ISeries ob;

            for (int i = 0; i < 5; i++)
            {
                ob = twoOb;
                Console.WriteLine("Следующее четное число равно " + ob.GetNext());
                ob = primeOb;
                Console.WriteLine("Следующее простое число равно " + ob.GetNext());
            }

         /*  Console.WriteLine("\nСбросить");
            ob.Reset();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее число равно " + ob.GetNext());
            }

            Console.WriteLine("\nНачать с числа 100");
            ob.SetStart(100);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее число равно " + ob.GetNext());
            }

            Console.WriteLine("Предыдущее число: " + ob.GetPrevious());*/

        }
    }
}
