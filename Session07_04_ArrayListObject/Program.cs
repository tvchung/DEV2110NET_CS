using System;
using System.Collections;
using System.Collections.Generic;
namespace Session07_04_ArrayListObject
{

    /// <summary>
    /// Student(ID,Name,Age)
    /// </summary>
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

        public override string ToString()
        {
            return string.Format("{0,5} {1,-20} {2,10}",ID,Name,Age);
        }
    }
    public class SortAge : IComparer
    {
        int IComparer.Compare(object a, object b)
        {
            Student c1 = (Student)a;
            Student c2 = (Student)b;
            if (c1.Age > c2.Age)
                return -1;
            if (c1.Age < c2.Age)
                return 1;
            else
                return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            // add
            arr.Add(new Student(100, "Chung", 45));
            arr.Add(new Student(101, "Chung 1", 55));
            arr.Add(new Student(102, "Chung 2", 75));
            arr.Add(new Student(103, "Chung 3", 25));
            arr.Add(new Student(104, "Chung 4", 65));

            // display
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }

            //arr.Sort();
            Console.WriteLine("===============");
            arr.Sort(new SortAge());

            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }

            // lambda expression in c# sort

            List<Student> list = new List<Student>
            {
                new Student(100, "Chung", 45),
                new Student(102, "Chung", 145),
                new Student(103, "Chung", 75)
            };

            Console.WriteLine("===============");
            list.Sort((x, y) => y.Age - x.Age);

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
