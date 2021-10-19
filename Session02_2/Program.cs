using System;

namespace Session02_2
{
    /// <summary>
    /// Cấu trúc điều khiển: (3 loại trúc điều)
    /// - Loại 1: Cấu trúc lựa chọn rẽ nhánh (if, switch)
    /// * Cấu trúc if: (4 dạng)
    /// 1. Cấu trúc if đơn:
    /// syntax:
    /// if(expression_condition){
    ///     statement; (expression_condition = true)
    /// }
    /// 
    /// 2. Cấu trúc if đầy đủ
    /// syntax:
    /// if(expression_condition){
    ///     statement-block; (expression_condition=true)
    /// }
    /// else
    /// {
    ///     statement-block; (expression_condition=false)
    /// }
    /// 
    /// 3. cấu trúc if bậc thang
    /// syntax:
    /// if(expr1){
    ///     statement-block; (expr1=true)
    /// }else if(expr2){
    ///     statment2; (expr2 = true)
    /// }else ....
    /// 
    /// }[else{
    ///     statement n-1; 
    /// }]
    /// 
    /// 4. cấu trúc if lồng nhau
    /// syntax:
    /// if(expr1){
    ///     if(expr1){....}else{....}
    /// }else{
    ///     if(expr2){....}
    ///     if(expr3){...}else{....}
    /// )
    /// * Cấu trúc switch:
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x, y;
            // nhập giá trị:
            Console.Write("Nhap x=");
            x = int.Parse(Console.ReadLine());

            //1. Cấu trúc if đơn:
            //// kiểm giá trị của x có phải la số dương không?
            if (x > 0)
            {
                Console.WriteLine("{0} la so duong.", x);
            }

            //2. Cấu trúc if đầy đủ 
            //ex: kiểm tra x là số chẵn hay số lẻ
            if (x % 2 == 0)
            {
                Console.WriteLine("{0} la so chẵn.", x);
            }
            else
            {
                Console.WriteLine("{0} la so lẻ.", x);
            }

            // 3.cấu trúc if bậc thang
            //ex: kiểm tra số x là số dương, hay số âm, hay là số 0
            if (x > 0)
            {
                Console.WriteLine("{0} la so dương.", x);
            }
            else if (x == 0)
            {
                Console.WriteLine("{0} la so 0.", x);
            }
            else // x<0
            {
                Console.WriteLine("{0} la so âm.", x);
            }

            // example: nhập điểm toán, điểm văn, tính trung bình => xếp loại (tự làm)
            */
            // 4. cấu trúc if lồng nhau
            //example: giải phương trình bậc nhất: ax+b=0; (10')
            float a, b, x1;
            // Nhập
            Console.Write("Hệ số a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Hệ số b = ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Giải phương trình:");

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phương trinh {0}x+{1}=0; Vo so nghiem", a, b);
                }
                else
                {
                    Console.WriteLine("Phương trinh {0}x+{1}=0;  vo nghiem", a, b);
                }
            }
            else
            {
                x1 = -b / a;
                Console.WriteLine("Phương trinh {0}x+{1}=0", a, b);
                Console.WriteLine("Có nghiệm x=" + x1);
            }


            // Bài tập: giải phương trình bậc 2
            // Tìm nghiệm đa thức bậc 3

            // Tìm nghiệm đa thức bậc n (n<10)



        }
    }
}
