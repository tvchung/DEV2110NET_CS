using System;

namespace Session01_2
{
    /// <summary>
    /// Nhập/xuất trong C#
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Xuất ra màn hình: Write; WriteLine
            // Write: xuât ra màn hình => con trỏ ở cuối dòng
            // WriteLine: xuất ra màn hình => con trỏ ở dòng tiếp theo

            Console.WriteLine("Hello World!");
            Console.Write("Hello ");
            Console.Write("World!");

            int x, y, z;
            x = 100; 
            y = 200;
            z = x * y + 1000;
            Console.WriteLine("La la la la: {0} * {1} + {2} = {3}", x, y, 1000, z);

            Console.WriteLine("x=" + x);

            // Nhập chuẩn: 
            // Read() => đọc một ký tự alphabeta
            // ReadKey() => đọc một ký tự bất kỳ
            // ReadLine() => đọc một chuỗi ký tự 

            int ch;
            Console.Write("Nhap mot ky tu:");
            ch = Console.Read();
            Console.WriteLine(ch);

            Console.ReadLine();
            string Name;
            Console.WriteLine("Nhap ten cua ban:");
            Name = Console.ReadLine();

            Console.WriteLine("Welcome to, " + Name);
            Console.WriteLine("Welcome to, {0}" , Name);

            Console.Write("Nhap x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x);
            Console.Write("Nhap x = ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(x);

        }
    }
}
