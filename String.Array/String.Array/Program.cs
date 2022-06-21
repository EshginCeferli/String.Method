using System;

namespace String.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = a;
            //Console.WriteLine( a + "-" + b);

            //int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] arr2 = arr1;
            //arr2[0] = 100;

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);

            //int n =6 ;
            //CheckNums(ref n);
            //Console.WriteLine(n);
            //static void CheckNums(ref int num )
            //{
            //    num= 5;
            //    Console.WriteLine(num);
            //}

            //string name1 = "Orxan";
            //string name2 = name1;
            //name2 = "Emil";
            //Console.WriteLine( name1 + " " + name2);

            //string name = "Mirsamir";
            //name = string.Empty;
            //if (string.IsNullOrEmpty(name))
            //{
            //    Console.WriteLine("He");

            //}
            //else
            //{
            //    Console.WriteLine("Yox");
            //}
            //Console.WriteLine(name.Replace("E","n"));


            //foreach( var item in name)
            //{
            //    Console.WriteLine( item);
            //}

            Console.WriteLine(ReverseWord("SettarBehlulzade"));
            static string ReverseWord(string name)
            {
                string result = "";
                for (int i = name.Length - 1; i >= 0; i--)
                    result += name[i];
                return result;
            }
        } 


    }
}
