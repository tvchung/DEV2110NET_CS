using System;

namespace Session03_07
{
    /// <summary>
    ///  Xử lý với mảng 2 chiều
    ///  1. Nhập mảng (Sinh ngẫu nhiên)
    ///  2. Xuất mảng
    ///  3. Tính tổng các phần tử chẵn.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            // 1. Nhập mảng (Sinh ngẫu nhiên)
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Random rand = new Random();
                    arr[i, j] =rand.Next(100);
                }
            }
            // Xuất mảng
            Console.WriteLine("Mang");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write("{0,5}", arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Tong");
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] % 2 == 0)
                        sum += arr[i, j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
