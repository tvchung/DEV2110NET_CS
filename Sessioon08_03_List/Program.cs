using System;
using System.Collections.Generic;

namespace Sessioon08_03_List
{
    /// <summary>
    /// List Generic Collection
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List generic collection demo");
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(30);
            list.Add(20);
            list.Add(50);
            Console.WriteLine("List");
            foreach (int item in list)
            {
                Console.Write("{0, 5}", item);
            }
            Console.WriteLine("\nList");

            list = new List<int>() { 10, 20, 30, 50, 79, 35, 49, 53, 123 };

            foreach (int item in list)
            {
                Console.Write("{0, 5}", item);
            }

            Console.WriteLine("\nList Object:");

            List<Student> lstStudent = new List<Student>()
            {
                new Student(){ID=100,Name="Hung",Age=100},
                new Student(){ID=102,Name="Dung",Age=70},
                new Student(){ID=103,Name="Sang",Age=90},
                new Student(){ID=104,Name="Trong",Age=60}
            };

            foreach (Student item in lstStudent)
            {
                Console.WriteLine("{0,10} | {1,-20} | {2,10}",
                    item.ID, item.Name, item.Age);
            }
            
            Console.WriteLine("\nList Object - Sort:");
            lstStudent.Sort((x,y)=> { return x.Age - y.Age; });

            foreach (Student item in lstStudent)
            {
                Console.WriteLine("{0,10} | {1,-20} | {2,10}",
                    item.ID, item.Name, item.Age);
            }

            Console.WriteLine("\nList Object - Sort:");
            lstStudent.Sort((x, y) => { return y.Age - x.Age; });

            foreach (Student item in lstStudent)
            {
                Console.WriteLine("{0,10} | {1,-20} | {2,10}",
                    item.ID, item.Name, item.Age);
            }

            Console.WriteLine("\nList Object - Sort (name):");
            lstStudent.Sort((x, y) => { return x.Name.CompareTo(y.Name); });

            foreach (Student item in lstStudent)
            {
                Console.WriteLine("{0,10} | {1,-20} | {2,10}",
                    item.ID, item.Name, item.Age);
            }

            Console.WriteLine("\nList Object - Sort (name):");
            lstStudent.Sort((x, y) => { return y.Name.CompareTo(x.Name); });

            foreach (Student item in lstStudent)
            {
                Console.WriteLine("{0,10} | {1,-20} | {2,10}",
                    item.ID, item.Name, item.Age);
            }
        }
    }


    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
