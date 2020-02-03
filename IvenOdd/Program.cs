using System;

namespace IvenOdd
{
    interface IEven
    {
        bool IsOdd(int x);
        bool IsEven(int x);
    }

    class MyClass:IEven
    {
        bool IEven.IsOdd(int x)
        {
            if ((x % 2) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public  bool IsEven(int x)
        {
            IEven o = this;
            return o.IsOdd(x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            bool result;

            result = ob.IsEven(4);
            if (result)
            {
                Console.WriteLine("4 - четное число.");
            }

            IEven iRef = (IEven)ob;
            result = iRef.IsOdd(3);
            if (result)
            {
                Console.WriteLine("3 - нечетное число.");
            }
        }
    }
}
