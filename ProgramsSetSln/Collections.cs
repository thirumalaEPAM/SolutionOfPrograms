using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsSetSln
{
    public  class Collections
    {

        public static  List<string> GetFruits()
        {
            {

                var fruitList = new List<string>() { "apple", "pineapple", "pear", "cherry", "cucumber" };

                var updateFruitList = new List<string>();

                foreach (string fruit in fruitList)
                {


                    if (fruit.Contains("a"))
                    {

                        updateFruitList.Add(fruit);
                    }



                }

                return updateFruitList;

            }
        }
            public static void DictionaryMethod()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "thiru");
            dict.Add(2, "Sai");
            dict.Add(3, "thiru");
            dict.Add(4, "Sai Prashasty");
            dict.Add(5, "Sai baba");

            foreach (var key in dict)
            {
                Console.WriteLine("Key: " + key.Key + " " + key.Value);
            }

            Console.WriteLine("Remove Dictionary values which are matches to String Thiru");
            foreach (var item in dict.Where(kvp => kvp.Value == "thiru").ToList())
            {
                Console.WriteLine("Key: " + item.Key + " " + item.Value);

                dict.Remove(item.Key);

            }

            Console.WriteLine("Remaning Dictionary data after the removal");
            foreach (var key in dict)
            {
                Console.WriteLine("Key: " + key.Key + " " + key.Value);
            }

        }
        public static void RevSentence(String str) {
            string[] words = str.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                sb.Append(words[i]);
                sb.Append(" ");
            }

            Console.WriteLine(" Reverse Sentence : ");
            Console.WriteLine(sb);

        }

        public static void RevWord(String str) {
            string[] words = str.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                sb.Append(Reverse(words[i]));
                sb.Append(" ");
            }

            Console.WriteLine(" Reverse Sentence : ");
            Console.WriteLine(sb);
        }


        public static string Reverse(String str) {
            String result=null;
            for (int i = str.Length - 1; i >=0; i--) { 
            result=result+str[i];
            }

            return result;
        }
    }
}
