using System;

namespace session02_3
{
    /// <summary>
    /// Cấu trúc switch:
    /// tùy theo điểu kiện trong biểu thức của switch, so với giá trị trong các case
    /// ==> giá trị nào thỏa mãn: thực hiện khối lệnh tương ứng
    /// syntax:
    /// switch(expression){
    ///     case value1:
    ///         statement1;
    ///         break;
    ///      case value2:
    ///         statement2;
    ///         break;
    ///     
    /// 
    ///     [default:
    ///         statement n+1;
    ///         [break;]
    ///     ]
    /// }
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tính số ngày trong tháng, năm nhập vào");
            //ex: nhập vào giá trị tháng trong năm, nhập vào năm
            // => in ra số ngày trong tháng năm đó
            // thang=10, nam=2021 => tháng 10 năm 2021 có 31 ngày
            // 5'
            int Thang, Nam;
            int SoNgay = 0;
            // input
            Console.Write("Thang = ");
            Thang = int.Parse(Console.ReadLine());
            Console.Write("Nam = ");
            Nam = int.Parse(Console.ReadLine());

            // processs
            switch (Thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    SoNgay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    SoNgay = 30;
                    break;
                case 2:
                    if ((Nam % 4 == 0 && Nam % 100 != 0) || Nam % 400 == 0)
                    {
                        SoNgay = 29;
                    }
                    else
                    {
                        SoNgay = 28;
                    }
                    break;

                default:
                    Console.WriteLine("ban nhap sai");
                    break;
            }

            // output
            if (SoNgay > 0)
            {
                Console.WriteLine("Thang {0}, nam {1} co {2} ngay!", Thang, Nam, SoNgay);
            }
            
            // Bài tập:
            //1. Nhập vào giá trị biên thứ (1-7) => in ra thứ trong tuần
            //2. Nhập vào một số có 3 chữ số => đọc thành lời việt
            // 103 => Một trăm linh ba ; Một trăm lẻ ba
            //3. Xây dựng menu thực đơn ăn uống => hiển thị mỗi khi người dùng chọn chức năng trên menu

        }
    }
}
