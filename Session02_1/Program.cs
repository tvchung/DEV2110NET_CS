using System;

namespace Session02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // review: variable, const, data type, expression, statement, block statment, ....
            // Console: read, ReadLine,  ReadKey, Write, WriteLine,....
            int x, y;
           // float a, b = 100.12f;
            // Nhập dữ liệu từ bàn phìm (thiết bị nhập chuẩn)
            Console.Write("Nhap x=");
            x = int.Parse(Console.ReadLine());

            Console.Write("Nhap y=");
            y = Convert.ToInt32(Console.ReadLine());

            int kq;
            kq = x + y;
            Console.WriteLine("{0} + {1} = {2}", x, y, kq);


        }
    }
}
