using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Используем индексатор для создания отказоустойчивого массива
namespace Indecsators
{
    class FailSoftArray
    {
        int[] a;  //ссылка на базовый массив

        public int length;
        public bool ErrFlag; //обозначает результат последней операции

        public  FailSoftArray(int size)e
        {
            a = new int[size];
            length = size;
        }

        public int this[int index]
        {
            get
            {
                if(ok(index))
                {
                    ErrFlag = false;
                    return  a[index];
                }
                else
                {
                    ErrFlag = true;
                    return 0;
                }
            }

            set 
            {
                if (ok(index))
                {
                    a[index] = value;
                    ErrFlag = false;
                }
                else
                {
                    ErrFlag = true;
                }
            }
        }

        private bool ok(int index)
        {
            if (index >= 0 & index < length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FailSoftArray fs = new FailSoftArray(5);
            int x;


            Console.WriteLine("Скрытый сбой\n");
            for (int i = 0; i < (fs.length * 2); i++)
            {
                fs[i] = i * 10;
            }

            

            for (int i = 0; i < (fs.length * 2); i++)
            {
                x = fs[i];
                if(x != -1)
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < (fs.length * 2); i++)
            {
                fs[i] = i * 10;
                if (fs.ErrFlag)
                {
                    Console.WriteLine("fs[" + i + "] вне границ");
                }
            }

            for (int i = 0; i < (fs.length * 2); i++)
            {
                x = fs[i];
                if (!fs.ErrFlag)
                {
                    Console.Write(x + " "); 
                }
                else
                {
                    Console.Write("\nfs[" + i + "] вне границ");
                }
            }
            Console.WriteLine();
        }


    }
}
