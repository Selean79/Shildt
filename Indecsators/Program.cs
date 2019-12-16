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
        int len; // длина массива
        bool ErrFlag;

       // public int length;
       // public bool ErrFlag; //обозначает результат последней операции

        public FailSoftArray(int size)
        {
            a = new int[size];
            len = size;
        }

        public int Lebght
        {
            get
            {
                return len;
            }
        }

        public bool Error
        {
            get
            {
                return ErrFlag;
            }
        }


        public int this[int index]
        {
            get
            {
                if (ok(index))
                {
                    ErrFlag = false;
                    return a[index];
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

        public int this[double idx]
        {
            get
            {
                int index;

                if ((idx - (int)idx) < 0.5)
                {
                    index = (int)idx;
                }
                else
                {
                    index = (int)idx + 1;
                }

                if (ok(index))
                {
                    ErrFlag = false;
                    return a[index];
                }
                else
                {
                    ErrFlag = true;
                    return 0;
                }
            }

            set
            {
                int index;

                if ((idx - (int)idx) < 0.5)
                {
                    index = (int)idx;
                }
                else
                {
                    index = (int)idx + 1;
                }


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
            if (index >= 0 & index < Lebght)
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
            for (int i = 0; i < (fs.Lebght * 2); i++)
            {
                fs[i] = i * 10;
            }

            

            for (int i = 0; i < (fs.Lebght * 2); i++)
            {
                x = fs[i];
                if(x != -1)
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < (fs.Lebght * 2); i++)
            {
                fs[i] = i * 10;
                if (fs.Error)
                {
                    Console.WriteLine("fs[" + i + "] вне границ");
                }
            }

            for (int i = 0; i < (fs.Lebght * 2); i++)
            {
                x = fs[i];
                if (!fs.Error)
                {
                    Console.Write(x + " "); 
                }
                else
                {
                    Console.Write("\nfs[" + i + "] вне границ");
                }
            }
            Console.WriteLine(); tests
        }


    }
}
