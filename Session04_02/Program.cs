using System;

namespace Session04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculator calc = new Calculator();
            calc.X = 100;
            //calc.Y = 200; // error
            Calculator.Y = 200; //ok

            calc.Show(); // gọi phương thức không trả về giá trị xác định
            int kq= calc.Add(100, 200);
            Console.WriteLine("Ket qua:" + kq);

            calc.Add(100, 200, 300);

            Calculator.sum(111, 222);

            Console.WriteLine("Doi cho");
            int x = 123, y = 456;
            Console.WriteLine("Truoc: X={0} -> Y= {1}", x, y);
            calc.swap(x, y);
            Console.WriteLine("Truoc: X={0} -> Y= {1}", x, y);


            Console.WriteLine("Doi cho ref");
            Console.WriteLine("Truoc: X={0} -> Y= {1}", x, y);
            calc.swap(ref x, ref y);
            Console.WriteLine("Truoc: X={0} -> Y= {1}", x, y);

            Console.WriteLine("Bien kieu out");
            int tong=0, tc=0;
            Console.WriteLine("Tong = {0}, tong chan={1}", tong, tc);

            calc.Tinh(10, out tong, out tc);
            Console.WriteLine("Tong = {0}, tong chan={1}", tong, tc);
        }
    }
    /// <summary>
    /// Phương thức
    /// </summary>
    class Calculator
    {
        // properties
        public int X { get; set; }
        public static int Y { get; set; }

        // phương thức không trả về giá trị, không có tham số
        public void Hello()
        {
            Console.WriteLine("Hello, Devmaster");
        }

        // Phương thức có tham số
        public int Add(int a, int b)
        {
            return a + b;
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("{0} + {1} +{2}= {3}", a, b,c, a + b+c);
        }

        // phương thức static
        public static void sum(int a, int b)
        {
            Console.WriteLine("{0} + {1} =  {2}", a, b, a + b );
        }

        public void Show()
        {
            Console.WriteLine("X=" + X);
            Console.WriteLine("Y=" + Y);
        }


        // biến kiểu ref
        public void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        
        // out
        public void Tinh(int n, out int tong, out int tong_chan)
        {
            tong = 0;
            tong_chan = 0;
            for (int i = 0; i < n; i++)
            {
                tong += i;
                if (i % 2 == 0)
                    tong_chan += i;
            }
        }
    }
}
