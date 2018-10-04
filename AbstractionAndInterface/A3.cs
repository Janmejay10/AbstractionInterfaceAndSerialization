using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterface
{
    abstract class A3
    {
        public void test1()
        {
            Console.WriteLine("from A.test1()");
        }
        public abstract void test2();
    }

    class L : A3
    {
       public override void test2()

        {
            Console.WriteLine("from L.test2()");
        }


        static void main(String[] args)
        {
            L obj = new L();
            obj.test1();
            Console.WriteLine("............");
            obj.test2();
        }
    }
}

