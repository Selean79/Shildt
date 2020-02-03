using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            ByTwos ob = new ByTwos();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее число равно " + ob.Next);

            }
            Console.WriteLine("\nНачать с числа 21");
            ob.Next = 21;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее число равно " + ob.Next);

            }





        }
    }
}
