using System;

namespace Session06_01_Abstraction
{
    /// <summary>
    /// Lớp trừu tượng, phương thức trừu tượng
    /// => Là những lớp mà có chứa các phương thức không có nội dung
    /// => Thường sử dụng để làm lớp cơ cở, cho phép kế thừa ở các lớp con
    /// => Các lớp kế thừa, phải cài đặt nội dung cho phương thức trừu tượng
    /// 
    /// Ghi chú:
    /// => Lớp trừu tượng: có thể có phương thức đã có nội dung và các phương thức không có nội dung
    /// => Lớp trừu tượng không thể khởi tạo đối tượng
    /// </summary>
    /// 
    // Tạo lớp trừu tượng Person
    abstract class Person
    {
        // Phương thức không trừu tượng (Có thể có hoặc không)
        public void Speak()
        {
            Console.WriteLine("Moi nguoi deu noi duoc tieng viet");
        }

        // Phương thức trừu tượng
        public abstract void DoWork();
        public abstract void EnviromentWork();

    }

    // Tạo lớp kế thừa, triển khai các nghiệp vụ cho phương thức trừu tượng từ lớp trừu tượng
    class Employee : Person
    {
        public override void DoWork()
        {
            Console.WriteLine("Lam viec tai van phong");
        }

        public override void EnviromentWork()
        {
            Console.WriteLine("Su dung cong nghe");
        }
    }
    class Faculty : Person
    {
        public override void DoWork()
        {
            Console.WriteLine("Tai giang duong");
        }

        public override void EnviromentWork()
        {
            Console.WriteLine("Online");
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
            // Person p = new Person(); => error: không thể tạo đối tượng trên lớp trừu tượng
            Employee emp = new Employee();
            emp.Speak();
            emp.DoWork();
            emp.EnviromentWork();
        }
    }
}
