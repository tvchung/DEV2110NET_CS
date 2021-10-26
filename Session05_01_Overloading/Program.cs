using System;

namespace Session05_01_Overloading
{

    /// <summary>
    /// Nạp chồng phương thức
    /// Tạo các phương thức trùng tên....
    /// </summary>
    
    class NapChong
    {
        // field / properties
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        // Trùng tên, khác nhau về số lượng tham số
        public int Sum(int n)
        {
            int tong = 0;
            for (int i = 0; i <= n; i++)
            {
                tong += i;
            }
            return tong;
        }
        public int Sum(int n, int m)
        {
            int tong = 0;
            for (int i = n; i <= m; i++)
            {
                tong += i;
            }
            return tong;
        }
        // trung tên, cùng số lượng tham số, khác nhau về kiểu dữ liệu của tham số
        public void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        public void Add(float a, float b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        public void Add(double a, double b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        // nạp chồng constructor
        public NapChong() { }
        public NapChong(int Num1, int Num2)
        {
            this.Num1 = Num1;
            this.Num2 = Num2;
        }
    }
    
    /// <summary>
    /// test
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overloading...!");
            NapChong nc = new NapChong();
            int kq = nc.Sum(10);
            Console.WriteLine("Tong = " + kq);

            kq = nc.Sum(10, 20);
            Console.WriteLine("Tong = " + kq);

            nc.Add(10, 20);
            nc.Add(10.1f, 20.2f);
            nc.Add(100.1D, 200.1D);
        }
    }
}
