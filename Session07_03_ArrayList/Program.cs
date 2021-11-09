using System;
using System.Collections;

namespace Session07_03_ArrayList
{
    /// <summary>
    /// Collection: 
    ///     - Properties
    ///     - Method
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            // properties:
            Console.WriteLine("Count : " + arr.Count);
            Console.WriteLine("Capacity : " + arr.Capacity);

            // Method
            arr.Add("Chung Trinh");
            Console.WriteLine("Count : " + arr.Count);
            Console.WriteLine("Capacity : " + arr.Capacity);

            arr.Add("10");
            arr.Add("20");
            arr.Add("10");

            arr.Add("15");
            Console.WriteLine("Count : " + arr.Count);
            Console.WriteLine("Capacity : " + arr.Capacity);

            // duyet
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            // sort

            arr.Sort();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            // remove


            // contain

            //....
        }
    }
}
