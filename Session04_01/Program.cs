using System;

namespace Session04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Product obj = new Product(); // Sử dụng hàm khởi tạo không tham số
            // truy / xuất
            obj.ID = 111;
            obj.Name = "Iphone";
            obj.Quantity = 39;
           // obj.Price = 123.3f; => lỗi, thuộc tính chỉ đọc

            //Console.WriteLine("{0,5} {1,10} {2,15} {3,20}", obj.ID, obj.Name, obj.Quantity, obj.Price);

            
            obj = new Product(222, "Samsung", 100, 2000.5f);

            //Console.WriteLine("{0,5} {1,10} {2,15} {3,20}", obj.ID, obj.Name, obj.Quantity, obj.Price);

            obj.Display();
        }
    }
}
