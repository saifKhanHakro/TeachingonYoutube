using System;
using System.Collections.Generic;

namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Addition
            List<string> names = new List<string>();
            names.Add("saif");
            names.Add("ali");
            names.Add("khan");

            //Access
            Console.WriteLine("Add");
            PrintList(names);


            //Delete 

            Console.WriteLine("RemoveAll");

            names.RemoveAll(x=>x.StartsWith("s"));

            //Print Again
            PrintList(names);

            names.Clear();

            Console.WriteLine("Clear");

            //Print Again
            PrintList(names);



            Console.ReadKey();
        }

        public static void PrintList(List<string> list)
        {
            //Access

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

        }
    }
}
