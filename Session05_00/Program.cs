using System;

namespace Session05_00
{
    /// <summary>
    /// Class, Object
    /// - Tạo class:
    ///     + Member:(Field, properties)
    ///     + Method:
    ///         +> Constructor (Không có tham số, có tham số) => trùng với tên lớp
    ///         +> Mormal Method
    ///         +...
    ///         +> Deconstructor (~)=> trùng với tên lớp
    /// - Object: 
    ///     + tạo thể hiện của lớp đối tượng (sử dùng toán tử new)
    ///     ClassName objName = new ClassName();
    ///     + truy vập đến các thành phần của đối tượng (Phụ thuộc vào phạm vi)
    ///         +> field / Properties
    ///             objName.FieldName =? | objName.Properties=?
    ///         +> Method:
    ///             objName.MethodName(<< argumentlist >>);
    /// - Example:
    /// </summary>
    // Tạo lớp đối tượng Person
    class Person
    {
        // field / properties
        public int ID { get; set; } // => field: _ID 
        public string Name { get; set; } //=> field : _Name

        // constructor
        public Person() { }
        public Person(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        //Method Display()
        public void Display()
        {
            Console.WriteLine("ID\t:" + ID);
            Console.WriteLine("Name\t:{0}",Name);
        }

    }

    /// <summary>
    /// Test lớp đối tượng
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sử dụng lớp đối tượng!");
            Person p = new Person();
            // truuy cập đến thuộc tính
            p.ID = 111;
            p.Name = "Devmaster";

            // Gọi thực hiện phương thức
            p.Display();

            p = new Person(222, "Chung Trinh");
            p.Display();
        }
    }

    
}
