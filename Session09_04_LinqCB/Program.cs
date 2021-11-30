using System;
using System.Linq;
namespace Session09_04_LinqCB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq cơ bản");

            int[] nums = { 10, 20, 12, 34, 23, 14, 16, 39 };

            // lay ra cac so <=15
            var res = from x in nums
                      where x < 15
                      select x;

            foreach (var item in res )
            {
                Console.WriteLine(item);
            }

            res = nums.Where(x => x < 15);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            // count

            var count = nums.Count();
            Console.WriteLine(count);
        }
    }
}
