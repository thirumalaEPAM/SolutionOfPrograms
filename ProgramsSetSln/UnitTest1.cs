using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProgramsSetSln
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CollectionMethods()
        {
            Collections.DictionaryMethod();

            Collections.RevSentence("My Name is Thirumala");

            Collections.RevWord("My Name is Thirumala");

            foreach (var list in Collections.GetFruits()) { 
            Console.WriteLine(list);    
           }
        }

        [TestMethod]
        public void ObjectOrientedMethods()
        {
            baseClass obj;            
            obj = new baseClass();
            obj.Swap(10,20);
            obj = new derived(); 
            obj.Swap(10,20);
        }

        [TestMethod]
        public void AbstractandInterfaceMethods() {
            /** Abstract class Methods**/
            AbstractClass ch;
            ch=new Square();
            ch.X = 10;
            ch.Y = 20;
            ch.Display();
            ch = new Shape();
            ch.X=100;
            ch.Y=200;
            ch.Display();

            /**Interface Methods**/

            int[] arr = { 20, 1, 30, 15, 24, 56 };
            SubClass sub= new SubClass();
            sub.PrimeNumDisplay(100);
            sub.SecondMax(arr);

        }

        [TestMethod]
        public void PolymorpismMethods() {

            Polymorpism pm = new Polymorpism();           
            Console.WriteLine("Adding 2 numbers:"+pm.Add(4.5, 5.88));
            Console.WriteLine("Adding 4 numbers" + pm.Add(4, 5,6,7));


        }
        [TestMethod]
       // [ExpectedException(typeof(ArgumentNullException))]
        public void GetTestData() {
           DataDrivenExcel.ExcelCommonMethods excel = new DataDrivenExcel.ExcelCommonMethods();
            excel.AllEmployeesLocation(@"C:\Users\Thirumala_Rajolu\source\repos\ProgramsSetSln\DataDrivenExcel\TestData\TestData4.xlsx", "Sheet1");

        }

        [TestMethod]
        public void LinQTestMethods()
        {
            LinQProgs lq = new LinQProgs();
            string str = "This is Thirumala";
            int[] intArray = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };
            lq.ListMethod(str);
            lq.Arrayreverse(intArray);
            Assert.IsTrue(lq.numSearchArray(intArray,40));

        }

    }
}

