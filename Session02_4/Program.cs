using System;

namespace Session02_4
{
    /// <summary>
    /// Cấu trúc điều khiển lặp: (for) -> do...while, while, foreach,...
    /// for: (4 dạng khác nhau)
    /// syntax: tổng quát (for đầy đủ)
    /// for(init ; expressioon_condition ; step){
    ///     statement-block;
    /// }
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            //Nhập n
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            // For:
            //Dạng 1: for đầy đủ
            // ex: in ra các số nguyên dương <=n;
            Console.WriteLine();
            for (int i = 0; i <= n; i++)
            {
                if (i > 0)
                {
                    Console.Write(" {0} ", i);
                }
            }
            //ex: in ra các số nguyên chẵn <=n
            Console.WriteLine("\nSo nguyen chan:");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 ==0)
                {
                    Console.Write(" {0} ", i);
                }
            }
            Console.WriteLine("\nSo nguyen chan:");
            for (int i = 2; i <= n; i +=2)
            {
                Console.Write(" {0} ", i);
            }

            // Dạng 2: for khuyết
            // Khuyết một trong các thành phần của vòng lặp for (giữ nguyên 2 dấu ;)
            // ex: in ra các số nguyên <=n;

            // Khuyết: init
            Console.WriteLine("\nDay so nguyen:init");
            int dem = 0;
            for ( ;dem<=n; dem++)
            {
                Console.Write(" {0} ",dem);
            }
            // Khuyết: condition (mặc đinh không có thì nó là luôn dúngd
            Console.WriteLine("\nDay so nguyen:condition");
            for (dem = 0; ; dem++)
            {
                if (dem > n)
                    break;

                Console.Write(" {0} ", dem);
            }

            Console.WriteLine("\nDay so nguyen:step");
            for (dem = 0;dem<=n ; )
            {
                Console.Write(" {0} ", dem);
                dem++;
            }

            // Dạng 3: for khuyết toàn bộ => vẫn giữ nguyên 2 dấu ;)
            Console.WriteLine("\nDay so nguyen:");
            dem = 0;
            for (; ; )
            {
                if (dem > n)
                    break;
                Console.Write(" {0} ", dem);
                dem++;
            }

            // Dạng 4: for không thân
            //  for không than
            Console.WriteLine("\nDay so nguyen:");
            dem = 0;
            for (dem = 0; dem<=n ; Console.Write(" {0} ", dem), dem++ );
        
            // Cấu trúc lặp lồng nhau => bên trong cấu trúc lặp for, chứa cấu trúc lặp khác

            /*\
             
             n=5
             *
             * *
             * * * 
             * * * *
             * * * * *
             
             * 
             */
        }
    }
}
