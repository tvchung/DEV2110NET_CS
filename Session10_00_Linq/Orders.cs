using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session10_00_Linq
{
    /// <summary>
    /// Orders: lưu thông tin hóa đơn của khách hàng
    /// </summary>
    class Orders
    {
        // properties
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public int cID { get; set; }

        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        // Bổ sung thêm các thuộc tính
    }
}
