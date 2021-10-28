using System;

namespace Session06_02_Interface
{
    /// <summary>
    /// Lớp giao diện: Interface
    /// => Dùng để khai báo chức năng, không triển khai nội dung
    /// 
    /// </summary>
    
    // Lớp giao diện IStudent

    interface IStudent
    {
        void Display();
        bool Insert();
        bool Update();
        bool Delete();
    }

    interface IStudentHP
    {
        float HocPhi();
    }

    class Student : IStudent
    {
        public bool Delete()
        {
            Console.WriteLine("Chuc nang xoa");
            return true;
        }

        public void Display()
        {
            Console.WriteLine("Chuc nang hien thi noi dung");
        }

        public bool Insert()
        {
            Console.WriteLine("Chuc nang them moi");
            return true;
        }

        public bool Update()
        {
            Console.WriteLine("Chuc nang sua doi");
            return true;
        }
    }

    class Student_CQ : IStudent, IStudentHP
    {
        public bool Delete()
        {
            Console.WriteLine("Chuc nang xoa");
            return true;
        }

        public void Display()
        {
            Console.WriteLine("Chuc nang hien thi noi dung");
            Console.WriteLine("Hoc phi:" + HocPhi());
        }

        public bool Insert()
        {
            Console.WriteLine("Chuc nang them moi");
            return true;
        }

        public bool Update()
        {
            Console.WriteLine("Chuc nang sua doi");
            return true;
        }
        public float HocPhi()
        {
            return 1000000;
        }
    }

    class Student_LT : IStudent, IStudentHP
    {
        public bool Delete()
        {
            Console.WriteLine("Chuc nang xoa");
            return true;
        }

        public void Display()
        {
            Console.WriteLine("Chuc nang hien thi noi dung");
            Console.WriteLine("Hoc phi:" + HocPhi());
        }

        public bool Insert()
        {
            Console.WriteLine("Chuc nang them moi");
            return true;
        }

        public bool Update()
        {
            Console.WriteLine("Chuc nang sua doi");
            return true;
        }
        public float HocPhi()
        {
            return 2000000;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IStudent st = new Student();
            st.Display();

            Student_CQ cq = new Student_CQ();
            cq.Display();

            Student_LT lt = new Student_LT();
            lt.Display();
        }
    }
}
