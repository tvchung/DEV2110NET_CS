using System;

namespace Session07_01_Lab04_02
{
    /// <summary>
    /// Tạo ứng dụng C# minh họa lớp abstract và kế thừa như hình sau. 
    /// </summary>
    /// 
    
    abstract class NhanVien
    {
        //Ten DiaChi
        public string Ten { get; set; }
        public string DiaChi { get; set; }

        // abstract method
        public abstract double TinhLuong();
        public abstract void HienThi();
    }


    /// <summary>
    /// NhanVienBanHang
    /// </summary>
    /// 
    class NhanVienBanHang : NhanVien
    {
        public int Soluongbanduoc { get; set; }
        public override void HienThi()
        {
            Console.WriteLine("Ten:" + Ten);
            Console.WriteLine("Dia chi:" + DiaChi);
            Console.WriteLine("Luong:" + TinhLuong());
        }

        public override double TinhLuong()
        {
            return Soluongbanduoc * 1000;
        }
    }

    /// <summary>
    /// CongNhan
    /// </summary>
    /// 
    class CongNhan : NhanVien
    {
        public int SoLuongSanPham { get; set; }
        public override void HienThi()
        {
            Console.WriteLine("Ten:" + Ten);
            Console.WriteLine("Dia chi:" + DiaChi);
            Console.WriteLine("Luong:" + TinhLuong());
        }

        public override double TinhLuong()
        {
            return SoLuongSanPham * 2000;
        }
    }


    /// <summary>
    /// test
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NhanVien nv = new NhanVienBanHang();
            nv.Ten = "Chung Trinh";
            nv.DiaChi = "25 Vu ngoc phan";
            (nv as NhanVienBanHang).Soluongbanduoc = 200;
            //nv.TinhLuong();
            nv.HienThi();

            CongNhan cn = new CongNhan();
            cn.Ten = "Devmaster";
            cn.DiaChi = "25 Vũ Ngoch Phan";
            cn.SoLuongSanPham = 500;

            cn.HienThi();

        }
    }
}
