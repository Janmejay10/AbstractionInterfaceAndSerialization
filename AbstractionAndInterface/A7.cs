using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterface
{
    interface A7
    {
        void test1();
    }

   public class E : A7
    {

    public void test1()
    {
        Console.WriteLine("from E.A()");
    }

    public static void main(String[] args)
    {
        E k1 = new E();
        k1.test1();
        Console.WriteLine("done");
    }
}
}
