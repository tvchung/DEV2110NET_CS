using System;
using System.Collections;

namespace Session08_00_Review_ArrayListCollection
{

    /// <summary>
    /// Collection: ArrayList => lưu trữ đối tượng student
    /// properties: 
    ///     - count
    ///     - capacity
    /// Method:
    ///     Add
    ///     AddRange
    ///     
    ///     Remove
    ///     RemoveAt
    ///     
    ///     Insert,...
    ///     
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo

            ArrayList arr = new ArrayList();

            // Add
            arr.Add(new Student() { ID = 100, Name = "Hung", Age = 30 });
            arr.Add(new Student() { ID = 102, Name = "Dung", Age = 70 });
            arr.Add(new Student() { ID = 103, Name = "Sang", Age = 50 });
            arr.Add(new Student() { ID = 104, Name = "Trong", Age = 40 });

            ArrayList a = new ArrayList();
            a.Add(new Student() { ID = 200, Name = "A", Age = 10 });
            a.Add(new Student() { ID = 202, Name = "B", Age = 50 });
            a.Add(new Student() { ID = 203, Name = "C", Age = 30 });

            arr.AddRange(a);

            // out
            Display(arr);

            // xóa
            foreach (Student item in arr)
            {
                if(item.Age == 30)
                {
                    arr.Remove(item);
                    break;
                }
            }

            Display(arr);

            arr.RemoveAt(5);
            Display(arr);

            // sort
            arr.Sort(new SortAgeASC());

            Display(arr);
        }

        // print
        static void Display(ArrayList arr)
        {
            Console.WriteLine("{0,10} | {1,-20} | {2,10}\n============================================="
                , "ID", "Name", "Age");
            foreach (Student item in arr)
            {
                Console.WriteLine("{0,10} | {1,-20} | {2,10}", item.ID, item.Name, item.Age);
            }
        }
    }
    class SortAgeASC : IComparer
    {
        public int Compare(object x, object y)
        {
            Student a = x as Student;
            Student b = y as Student;

            if (a.Age > b.Age)
                return 1;
            else if (a.Age < b.Age)
                return -1;
            else
                return 0;

        }
    }
}
