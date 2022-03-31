using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsSetSln
{
    public class LinQProgs
    {

        public void Arrayreverse(int[] intArray) {

            //int[] intArray = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };
            Console.WriteLine("Before Reverse the Data");
            foreach (var number in intArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            IEnumerable<int> ArrayReversedData = intArray.Reverse();
            Console.WriteLine("After Reverse the Data");
            foreach (var number in ArrayReversedData)
            {
                Console.Write(number + " ");
            }
        }

        public Boolean numSearchArray(int [] IntArray,int a) {


          //  int[] IntArray = { 11, 22, 33, 44, 55 };
            //Using Method Syntax
            var IsExistsMS = IntArray.Contains(33);
            //Using Query Syntax
            var IsExistsQS = (from num in IntArray
                              select num).Contains(a);

            return IsExistsQS;
        }

        public void ListMethod(string Str) { 
        

            String[] strArr= Str.Split(' ');

            List<String> list = new List<String>();
            list.AddRange(strArr);

            IEnumerable<String> list2 = from str in strArr
                                        where str[0]=='T'
                                        select str;

            Console.WriteLine("THe STrings which are starts with T");
            foreach (String str in list2)
            {
                Console.Write(str+" ");
            }

        }

    }
}
