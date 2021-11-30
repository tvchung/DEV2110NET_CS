using System;
using System.Linq;

namespace Session10_00_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dữ liệu mẫu

            var customers = new Customer[]
            {
                new Customer{ID=1,Name="Sam",Email="sam@gmail.com"},
                new Customer{ID=2,Name="Dave",Email="Dave@gmail.com"},
                new Customer{ID=3,Name="John",Email="John@gmail.com"},
                new Customer{ID=4,Name="Julia",Email="Julia@gmail.com"},
                new Customer{ID=5,Name="Thomas",Email="Thomas@gmail.com"}
            };


            var orders = new Orders[]
            {
                new Orders{ID=1,cID=1,OrderDate=DateTime.Parse("2021-11-15"),ProductName = "Cshapre", Quantity=100,Price=1000},
                new Orders{ID=2,cID=1,OrderDate=DateTime.Parse("2021-11-16"),ProductName = "Ga quay", Quantity=140,Price=1500},
                new Orders{ID=3,cID=2,OrderDate=DateTime.Parse("2021-11-12"),ProductName = "Trau gac bep", Quantity=100,Price=2000},
                new Orders{ID=4,cID=4,OrderDate=DateTime.Parse("2021-11-10"),ProductName = "Aspnet mvc 5", Quantity=140,Price=1200},
                new Orders{ID=5,cID=4,OrderDate=DateTime.Parse("2021-11-14"),ProductName = "La la la", Quantity=230,Price=1500}
            };

            // thực hiện truy vấn linq cơ bản trên tập dữ liệu

            // Hiển thị tất cả các khách hàng
            Console.WriteLine("Thông tin khach hang");
            var query = from x in customers select x;
            foreach (var item in query)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-30}", item.ID, item.Name, item.Email);
            }

            // Truy vấn có điều kiện
            query = from x in customers 
                    where x.Name.Contains("a") 
                    select x;
            Console.WriteLine("Thông tin khach hang co dieu kien:");
            foreach (var item in query)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-30}", item.ID, item.Name, item.Email);
            }


            // truy vấn có sắp xếp => sắp theo tên tăng dần
            query = from x in customers
                    orderby x.Name ascending
                    select x;
            Console.WriteLine("Truy van co săp xép:");
            foreach (var item in query)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-30}", item.ID, item.Name, item.Email);
            }

            // entity
            // Hiển thị tất cả các khách hàng
            Console.WriteLine("Thông tin khach hang");
            query = customers.ToList();
            foreach (var item in query)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-30}", item.ID, item.Name, item.Email);
            }

            // Truy vấn có điều kiện
            query = customers.Where(x => x.Name.Contains("a")).ToList();

            Console.WriteLine("Thông tin khach hang co dieu kien:");
            foreach (var item in query)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-30}", item.ID, item.Name, item.Email);
            }

            // truy vấn có sắp xếp => sắp theo tên tăng dần
            query = customers.OrderBy(x => x.Name).ToList();

            Console.WriteLine("Truy van co săp xép:");
            foreach (var item in query)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-30}", item.ID, item.Name, item.Email);
            }

            // Truy vấn có điều kiện
            query = customers.Where(x => x.Name.Contains("a")).Where(x => x.Email.StartsWith("J")).ToList();

            Console.WriteLine("Thông tin khach hang co dieu kien:");
            foreach (var item in query)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-30}", item.ID, item.Name, item.Email);
            }

            query = customers.Where(x => x.Name.Contains("a") && x.Email.StartsWith("J")).ToList();

            Console.WriteLine("Thông tin khach hang co dieu kien:");
            foreach (var item in query)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-30}", item.ID, item.Name, item.Email);
            }


            // Truy vấn linq trên 2 hay nhiều tập dữ liệu (object / Entity,...)
            // join
            var query1 = from x in customers
                    join y in orders on x.ID equals y.cID
                    select new
                    {
                        ID= x.ID, 
                        cID=y.cID,
                        Name=x.Name, 
                        PName=y.ProductName, 
                        Qty=y.Quantity, 
                        Price=y.Price,
                        ThanhTien=y.Quantity*y.Price
                    };

            Console.WriteLine("Thong tin khach hang - hoa don:");
            foreach (var item in query1)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-10} | {3,-15} | {4,-15} | {5,10} | {6,20}",
                    item.ID,item.cID, item.Name, item.PName,item.Qty,item.Price, item.ThanhTien);
            }

            // join and sort , where
            query1 = from x in customers
                     join y in orders on x.ID equals y.cID
                     where y.Quantity>100
                     orderby y.Price*y.Quantity ascending
                     select new
                     {
                         ID = x.ID,
                         cID = y.cID,
                         Name = x.Name,
                         PName = y.ProductName,
                         Qty = y.Quantity,
                         Price = y.Price,
                         ThanhTien = y.Quantity * y.Price
                     };

            Console.WriteLine("Thong tin khach hang - hoa don:");
            foreach (var item in query1)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-10} | {3,-15} | {4,-15} | {5,10} | {6,20}",
                    item.ID, item.cID, item.Name, item.PName, item.Qty, item.Price, item.ThanhTien);
            }

            // linq to entity  
            // lọc ra những hóa đơn có độ dài tên sản phẩm >10
            var query2 = orders.Where(x => x.ProductName.Length > 10);
            Console.WriteLine("lọc ra những hóa đơn có độ dài tên sản phẩm >10:");
            foreach (var item in query2)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-10} | {3,-15} | {4,-15} | {5,10}",
                    item.ID, item.cID, item.ProductName, item.Quantity, item.Price, item.Quantity*item.Price);
            }


            //Đếm xem có bao nhiêu hóa đơn
            Console.WriteLine("Tong so hoa don:" + orders.Count());


            // lấy ra 2 hoa don dau tien
            query2 = orders.Take(2);
            Console.WriteLine("lấy ra 2 hoa don dau tien:");
            foreach (var item in query2)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-10} | {3,-15} | {4,-15} | {5,10}",
                    item.ID, item.cID, item.ProductName, item.Quantity, item.Price, item.Quantity * item.Price);
            }

            // lấy ra 2 hoa don dau tien có số lượng lớn nhất
            query2 = orders.OrderByDescending(x=>x.Quantity).Take(2);
            Console.WriteLine("lấy ra 2 hoa don dau tien:");
            foreach (var item in query2)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-10} | {3,-15} | {4,-15} | {5,10}",
                    item.ID, item.cID, item.ProductName, item.Quantity, item.Price, item.Quantity * item.Price);
            }

            // skip:
            // lấy ra 2 hoa don từ hóa đơn thứ 2
            query2 = orders.Skip(1).Take(2);
            Console.WriteLine("lấy ra 2 hoa don từ vị trí thứ 2:");
            foreach (var item in query2)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-10} | {3,-15} | {4,-15} | {5,10}",
                    item.ID, item.cID, item.ProductName, item.Quantity, item.Price, item.Quantity * item.Price);
            }

            //TakeWhile
            // lấy ra những hóa đơn có tên sản phẩm chứa từ ga
            query2 = orders.TakeWhile(x => x.ProductName.Contains("Ga"));
            Console.WriteLine("lấy ra những hóa đơn có tên sản phẩm chứa từ ga:");
            foreach (var item in query2)
            {
                Console.WriteLine("{0,3} | {1,-10} | {2,-10} | {3,-15} | {4,-15} | {5,10}",
                    item.ID, item.cID, item.ProductName, item.Quantity, item.Price, item.Quantity * item.Price);
            }
        }
    }
}
