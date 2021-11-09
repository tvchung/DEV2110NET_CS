using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session08_04_NamespaceDemo
{
    class Store
    {
    }
}


// Create namespace
namespace HumanResource
{
    // class, struct, inteface,...
    class Employee
    {
        public void Display()
        {
            Console.WriteLine("Day la lop nhan vien");
        }
    }
}

namespace StudentManagement { 
    // student
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student() { }
        public Student(int ID, string Name, int Age)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }
    }
}