using System;

namespace Session03_02
{
    /// <summary>
    /// Cấu trúc lặp do...while
    /// - Thực hiện câu lệnh trong vòng lặp ít nhất một lần
    /// - syntax:
    /// do{
    ///     statement;
    /// }while(condition);'
    /// 
    /// ex: in ra các sô từ 1 -> n;
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 10;
            int i = 1;
            do
            {
                Console.Write("{0,5}", i++);
            } while (i <= n);

            // kiểm tra yêu cầu nhập số nguyên n
            // - Phải là số có giá trị trong khoảng 10-99;
            // - Nếu không thỏa mãn => nhập lại (do...while): 5'

            do
            {
                Console.Write("Input n [10-99] =");
                n = int.Parse(Console.ReadLine());
            } while (n < 10 || n > 99);

            Console.WriteLine(n);

            
        }
    }
}
