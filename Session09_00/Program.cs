using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Session09_00
{
    /// <summary>
    /// T-SQL:
    /// SELECT      -5
    /// FROM        -1
    /// WHERE       -2
    /// GROUP BY    -3
    /// HAVING      -4
    /// ORDER BY    -6
    /// 
    /// 
    /// LINQ:
    /// FROM
    /// SELECT
    /// ....
    /// ORDER BY
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ.... DEMO");
            //List<string> list = new List<string>() { "Hung", "Dung", "Sang", "Trong" };
            string[] list = { "Hung", "Dung", "Sang", "Trong" };
            // in
            IEnumerable<string>  result = from a in list 
                                          where a.StartsWith("H") //a.Contains("u")
                                          select a;
            // Are you missing required assembly references or a using directive for 'System.Linq'?
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
