using System;

namespace Session03_03
{
    /// <summary>
    ///  Cấu trúc lặp while
    ///  - Kiểm tra điều kiện => điều kiện đúng thì thực hiện lệnh trong vòng lặp
    ///  - syntax:
    ///  while(expression_condition){ // true | false
    ///     statement_block;
    ///  }
    /// ..... 
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 10;
            int i = 1;
            while (i <= n)
            {
                Console.Write("{0,5}", i);
                i++; // nếu không tăng i thì vòng lặp vô hạn
            }

            // test:
            bool flag = false;
            while (flag=!flag)
            {
                Console.WriteLine(flag); // output: true
            }
            flag = true;
            while (flag = !flag)
            {
                Console.WriteLine(flag); // output: nothing
            }

        }
    }
}
