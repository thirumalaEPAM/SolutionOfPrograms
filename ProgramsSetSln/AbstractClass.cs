using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsSetSln
{
    public abstract class AbstractClass
    {
        int x;
        int y;
       public int X { get { return x; } set { x = value; } }    
       public int Y { get { return y; } set { y = value; } }
        public abstract int Area(int a,int b);
        public void Display()
        {

            Console.WriteLine("Area : " + Area(X,Y));
        }

    }
    public class Square : AbstractClass
    {
        public override int Area(int a, int b)
        {
            return a * b;
        }
    }
        public class Shape : AbstractClass
        {
            public override int Area(int a, int b)
            {
                return 4*a*b;
            }
        }


    public interface Iinterface1
    {
        void SecondMax(int[] arr);
        void PrimeNumDisplay(int n);
    }
    public class SubClass : Iinterface1
    {
        public void SecondMax(int[] arr)
        {
            int m1 = 0;
            int m2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > m1 && arr[i]>m2)
                {
                    m1 = arr[i];
                    m2 = m1;
                }
                if(arr[i] < m2)
                {
                    m2 = arr[i];
                }
            }

            Console.WriteLine("2nd largest number is :  " + m2);
           
        }
        public void PrimeNumDisplay( int n)
        {
            Console.WriteLine("All primenumbers with in range 1 to 100");

            for (int i = 1; i <= n; i++)
            { 
              if(Prime(i)==1)
                    Console.Write(i + " ");
            }
        }

        private int Prime(int N)
        {
            int count=0;
            for(int i = 2; i <= N; i++)
            {
                if(N%i==0) count++;
            }
            return count;
        }
    }
}
