using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterface
{
    interface A8
    {
        void test1();
        void test2();
    }

    public class F : A8
    {

    public void test1()
    {
        Console.WriteLine("from 1F.A()");
    }

    public void test2()
    {
        Console.WriteLine("from 2F.A()");
    }

    public static void main(String[] args)
    {
        
        
        F f1 = new F();
        f1.test1();
        f1.test2();
        Console.WriteLine("done");
    }
}
}
