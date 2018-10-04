using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterface
{
    abstract class A4
    {
       public void test1()
        {
            Console.WriteLine("from A.test1()");
        }
      public abstract void test2();                 // here we have one concrete and 2 abstracts
      public abstract void test3();
    }

    abstract class B : A4
    {
    public override void test2()

    {
            Console.WriteLine("from B.test2()");   // all three inherited to B but only test2 became conctere but not test3 so clas B is declared abstract
        }                                           // (or in other words B is implementing only test2)
    }

    class M : B
    {
	public override void test3()

    {
           Console.WriteLine("from M.test3()");    // here all three are concrete test3 also became concrete no need to declare class M as abstarct
        }

    public static void main(String[] args)
    {
        M obj = new M();
        obj.test1();
        Console.WriteLine("...........");
        obj.test2();
        Console.WriteLine("...........");
        obj.test3();


    }
}

}
