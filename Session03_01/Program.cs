using System;

namespace Session03_01
{
    /// <summary>
    /// Cấu trúc lặp lồng nhau 
    /// - Bên trong cấu trúc lặp, lại chứa một cấu trúc lặp khác
    /// - Syntax:
    ///     for(...;...;...){
    ///         statement;
    ///         for(...;...;....){....}
    ///     }
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In bảng cửu chương");
            // 5'
            /* 2 x 1 = 2
             * 2 x 2 = 4
             * 
             * 
             * 2 x 9 = 10
             * 2 x10 = 20
             * 
             */
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine("Bang cuu chuong thu " + i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }
            }


            // nhập n (Ví dụ n=5)
            // In ra tam giac 
            /*
             n=5;
             * 
             * * 
             * * *
             * * * *
             * * * * *
             
             */
            int n = 5;
            Console.WriteLine("Tam giac *");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

            /*
             n=5; (3')
             
             * * * * *
             * * * *
             * * *
             * *
             * 
             
             */
            Console.WriteLine("Tam giac *");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

            /*
             n=5; (3')
             
             * * * * *
               * * * *
                 * * *
                   * *
                     * 
             
             */

            // Bài tập:
            /*  Nhập vào số nguyên dương n
             *  In ra theo mẫu sau
             *  n=10
             *  => in
             *  1
             *  2 3
             *  4 5 6
             *  7 8 9 10
             * 
             */
        }
    }
}
