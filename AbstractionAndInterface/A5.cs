using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterface
{
    abstract class A5
    {
       public abstract void test1();
       public abstract void test2();
       public abstract void test3();
    }

    abstract class B1 : A5
    {
	public override void test1()

    {
            Console.WriteLine("B.test1()");
        }
    }

    abstract class C : B1
    {
	public override void test2()

    {
           Console.WriteLine("C.test2()");
        }
    }

    class D : C
    {
	public override void test3()

    {
            Console.WriteLine("D.test3()");
        }
    }

    class O
    {
        static void main(String[] args)
        {
            //	A a1 = new A();
            //	B b1 = new B();
            //	C c1 = new C();            // we are not creating objetc to A,B and C because they are abstract
            D d1 = new D();

            d1.test1();
            d1.test2();
            d1.test3();

            Console.WriteLine("done");
        }
    }


}
