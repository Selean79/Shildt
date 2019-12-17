using System;

namespace ClassRangeArray
{
    class RangeArray
    {
        int[] a;
        int lowerbound, upperbound; // наибольший и наименьший индекс

        //автоматическое свойство доступное только для чтения
        public int Length
        {
            get;
            private set;
        }

        public bool Error
        {
            get;
            private set;
        }

        public RangeArray(int low, int high)
        {
            high++;
            if (high <= low)
            {
                Console.WriteLine("Неверные индексы");
                high = 1; // создание для надежности минимальный массив
                low = 0;
            }

            a = new int[high - low];
            Length = high - low;

            lowerbound = low;
            upperbound = --high;
        }

        public int this[int index]
        {
            get
            {
                if (ok(index))
                {
                    Error = false;
                    return a[index - lowerbound];
                }
                else
                {
                    Error = true;
                    return 0;
                }
            }

            set
            {
                if (ok(index))
                {
                    a[index - lowerbound] = value;
                    Error = false;
                }
                else
                {
                    Error = true;
                }
            }
        }

        private bool ok(int index)
        {
            if (index >= lowerbound & index <= upperbound)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    class RangeArraydemo
    {
        static void Main(string[] args)
        {
            RangeArray ra = new RangeArray(-5, 5);
            RangeArray ra2 = new RangeArray(1, -5);
          //  RangeArray ra3 = new RangeArray(-20, -12);

            Console.WriteLine("Длина массива ra: " + ra.Length);
            for (int i = -5; i <= 5; i++)
            {
                ra[i] = i;
            }

            Console.Write("Содержимое массива ra: ");
            for (int i = -5; i <= 5; i++)
            {
                Console.Write(ra[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Длина массива ra2: " + ra2.Length);
            for (int i = 1; i <= -5; i++)
            {
                ra2[i] = i;
            }

            Console.Write("Содержимое массива ra2: ");
            for (int i = 1; i <= -5; i++)
            {
                Console.Write(ra2[i] + " ");
            }

        }
    }
}
