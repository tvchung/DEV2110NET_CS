using System;

namespace Session03_00
{
    /// <summary>
    /// Review về cấu trúc lặp for
    /// for(init ; expression_condition ; step){
    ///     statement;
    /// }
    /// * 4 dạng for:
    /// - for đầy đủ,
    /// - for khuyết: init; condition ; step
    /// - for khuyết toàn bộ
    /// - for không thân
    /// 
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // ex: in ra các số nguyên dương từ 1->n
            int n;
            Console.Write("Input n=");
            n = int.Parse(Console.ReadLine());
            int i;
            Console.WriteLine("\n Day cac so nguyen:");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0,5}", i);
            }

            Console.WriteLine("\n Day cac so nguyen:");
            i = 1;
            for (; i <= n; i++)
            {
                Console.Write("{0,5}", i);
            }
            Console.WriteLine("\n Day cac so nguyen:");
            i = 1;
            for (; ; i++) // true
            {
                Console.Write("{0,5}", i);
                if (i == 10) // nếu không có điều kiện => vòng lặp vô hạn
                    break;
            }

            Console.WriteLine("\n Day cac so nguyen:");
            for (i = 1;  ; ) // true
            {
                Console.Write("{0,5}", i);
                if (i == 10)
                    break;
                i++; // nếu không có lệnh này, thì vòng lặp vô hạn
            }

            Console.WriteLine("\n Day cac so nguyen:");
            i = 1;
            for (;;) // true ; khuyết toàn bộ
            {
                Console.Write("{0,5}", i);
                if (i == 10)
                    break;
                i++; // nếu không có lệnh này, thì vòng lặp vô hạn
            }
            Console.WriteLine("\n Day cac so nguyen:");
            for (i = 1; i <= n; Console.Write("{0,5}", i), i++) ;// không thân


        }
    }
}
