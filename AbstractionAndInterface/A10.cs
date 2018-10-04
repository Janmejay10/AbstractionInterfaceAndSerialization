using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterface
{
    interface A10
    {
        void test1();
    }

    class B12
    {
       public void test2()
        {
            Console.WriteLine("from test2");
        }
    }

    class C12 : B12, A10
    {

        public void test1()
        {
            Console.Write("from test2");
        }
    
            static void main(String[] args)
            {
                C12 c1 = new C12();
                c1.test1();
                c1.test2();
                Console.WriteLine("done");
            }
        
    }
}
