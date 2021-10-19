using System;

namespace Session03_04
{
    /// <summary>
    /// Lệnh nhảy:
    /// break;
    /// continue;
    /// goto: (ít dùng)
    /// exit;
    /// return ;
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Tổng 1 + 2 = {0}", Add(1, 2));

            // break;
            // nhập số n, nếu n là số 5 thì kết thúc; ngược lại, in số đó
            int n;
            do
            {
                Console.Write("input n=");
                n = int.Parse(Console.ReadLine());
                if (n == 5)
                    break;

                Console.WriteLine(n);

            } while (true);

            Console.WriteLine("Kết thúc");

            //  continue;
            // int ra các số  từ 1 đến 10; nhưng không in số 5
            Console.WriteLine("==================");
            int i = 1;
            while (i <= 10)
            {
                if (i == 5)
                {
                    i++;
                    continue;
                }

                Console.Write("{0,5}", i);
                i++;
               
            }
            Console.WriteLine("\n OK");
        }

        // return
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
