using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04_01
{
    /// <summary>
    /// - Tạo lớp đối tượng Product => mô tả thông tin sản phẩn của bạn 
    /// </summary>
    class Product
    {
        // Properties Dynamic
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { private get; set; }
        public float Price { get; private set; }


        //public int Quantity { get; set; }
        //public float Price { get; set; }

        // Constructor - Có tham số
        public Product(int ID, string Name, int Quantity, float price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Quantity = Quantity;
            Price = price;
        }
        // Constructor - không tham số
        public Product() { }

        // display
        public void Display()
        {
            Console.WriteLine("{0,5} {1,10} {2,15} {3,20}",ID, Name, Quantity, Price);
        }
    }
}
