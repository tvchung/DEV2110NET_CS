using System;

namespace Session04_00
{

    /// <summary>
    /// OOP: 4 tính chất cơ bản của lập trình hướng đối tượng
    ///  - Inheritance: tính kế thừa
    ///  - Polymorphism: Tính đa hình hóa 
    ///  - Encapsulation: Tính đóng gói (Phạm vi sử dụng)
    ///  - Abstraction: Tính trừ tượng hóa 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Truy/Xuat den lop doi tuong");
            Student obj = new Student(); // khởi tạo đối tượng sinh viên
            obj.Display();// Gọi thực hiện phương thức của đối tượng
            //Truy xuất đến các thuộc tính / field
            obj.ID = 1001;
            obj.Name = "Chung";
            obj.Age = 45;
            obj.Display();

            obj.ID = 200;
            obj.Name = "Trinh";
            obj._Age = 50;
            obj.Display();
        }
    }


    // Lớp đối tượng
    // Cú pháp:
    /*
    [Phạm vi] class <<Class_Name>>{

        // member: field / properties

        // Method: constructor / desconstructor / method normal

    }
    ---
    [Phạm vi] class <<Class_Name>>{
        
        // Fields

        // Properties
        

        // Method: constructor / desconstructor / method normal

    }
    Ex: tạo lớp đối tượng sinh viên (Student)
        Thông tin: id, name, age
        Phương thức: Display()
     */

    // Tạo lớp đối tượng Student
    class Student
    {
        // field
        private int _Id; // 0-1000;
        private string _Name;
        public int _Age;

        // properties; obj.ID=100;
        public int ID
        {
            get {
                if (_Id <= 0 || _Id > 1000)
                {
                   return 0;
                }
                else
                {
                    return _Id;
                }
            }
            set { 
                if(value <=0 || value > 1000)
                {
                    _Id = 0;
                }
                else
                {
                    _Id = value;
                }
            }
        }
        public string Name
        {
            get { return _Name; }
            set { this._Name = value; }
        }

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        //Method
        public void Display()
        {
            Console.WriteLine("ID\t:" + ID);
            Console.WriteLine("Name\t:" + _Name);
            Console.WriteLine("Age\t:" + Age);
        }
    }
}
/*
    - Tạo lớp đối tượng Product => mô tả thông tin sản phẩn của bạn 


 */