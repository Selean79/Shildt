using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoirtualMethods
{
    class Base
    {
        //Создаем виртуальный метод в базовом классе
        public virtual void Who()
        {
            Console.WriteLine("М етод Who() в классе Base");
        }
      
    }

    class Derived1 : Base
    {
        public override void Who()
        {
            Console.WriteLine("Метод Who() в классе Derived1");
        }
    }

    class Derived2 : Base
    {
        public override void Who()
        {
            Console.WriteLine("Метод Who() в классе Derived2");
        }
    }
    class OverrideDemo
    {
        static void Main(string[] args)
        {
            Base baseOb = new Base();
            Derived1 dob1 = new Derived1();
            Derived2 dob2 = new Derived2();

            Base baseRef;

            baseRef = baseOb;
            baseRef.Who();

            baseRef = dob1;
            baseRef.Who();

            baseRef = dob2;
            baseRef.Who();

        }
    }
}
