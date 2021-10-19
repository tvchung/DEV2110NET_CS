using System;

namespace Session03_05
{
    /// <summary>
    /// Cấu trúc lặp tập hợp: foreach
    /// - Lặp trong tập hợp
    /// - Syntax:
    ///     foreach(<<datatype>> item in <<collection>>){
    ///         statement;
    ///     }
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] ArrName = { "Hung", "Dung", "Sang", "Trong" };
            Console.WriteLine("Names:");
            foreach (var item in ArrName)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Names:");
            for (int i = 0; i < ArrName.Length; i++)
            {
                Console.WriteLine(ArrName[i]);
            }
        }
    }
}
