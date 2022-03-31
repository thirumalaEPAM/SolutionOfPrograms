using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsSetSln
{
    public class Polymorpism
    {

        public double Add(double a, double b) {
            return a + b;
        }
        public int Add(int a,int b, int c=0, int d=0) {
        return a+b+c+d;
        }
    }
   public class baseClass
    {
        public virtual void Swap(int a, int b)
        {
            Console.WriteLine("Base class");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a: {0} and b= {1}", a, b);
        }
    }
    public class derived : baseClass
    {
        public override void Swap(int a, int b)
        {
            Console.WriteLine("Derived class");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a: {0} and b= {1}", a, b);
        }
    }
}
