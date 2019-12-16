using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndecsatorWithOutArray
{
    class PwrofTwo
    {
        //Доступ к логическому массиву, содежащему степени числа 2 от 0 до 15

        public int this[int index]
        {
            get
            {
                if ((index >= 0) && (index < 16))
                {
                    return pwr(index);
                }
                else
                {
                    return -1;
                }
            }

        }

        int pwr(int p)
        {
            int result = 1;
            for (int i = 0; i < p; i++)
            {
                result *= 2;
            }

            return result;
        }
    }
    class UsePwrOfTwo
    {
        static void Main(string[] args)
        {
            PwrofTwo pwr = new PwrofTwo();

            Console.WriteLine("Первые 8 степеней числа 2:");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(pwr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Это ошибки:");
            Console.Write(pwr[-1] + " " + pwr[17]);

            Console.WriteLine();
        }
    }
}
