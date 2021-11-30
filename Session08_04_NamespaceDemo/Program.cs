using System;
using hr=HumanResource; // it dungf
using HumanResource;
namespace Session08_04_NamespaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Namespace!");

            hr.Employee emp = new hr.Employee();
            emp.Display();

            StudentManagement.Student obj = new StudentManagement.Student(100, "Chung", 42);

            Employee emp1 = new Employee();
            emp1.Display();

        }
    }
}

