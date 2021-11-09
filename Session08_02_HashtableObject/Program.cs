using System;
using System.Collections;

namespace Session08_02_HashtableObject
{
    /// <summary>
    /// Collection: Hashtable
    /// - Lưu trữ Student => hashtable
    /// - Key: ID của student
    /// - value: Student
    /// 
    /// --- method:
    /// add
    /// remove
    /// clear
    /// 
    /// -- properties: keys, values, count, item,...
    /// 
    /// -- 10-15'
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            Student st = new Student() { ID = 100, Name = "Hung", Age = 25 };
            if (!ht.ContainsKey(st.ID))
                ht.Add(st.ID, st);
            else
                Console.WriteLine("{0} da ton tai", st.ID);

            st = new Student() { ID = 101, Name = "Dung", Age = 35 };
            if (!ht.ContainsKey(st.ID))
                ht.Add(st.ID, st);
            else
                Console.WriteLine("{0} da ton tai", st.ID);

            st = new Student() { ID = 102, Name = "Sang", Age = 55 };
            if (!ht.ContainsKey(st.ID))
                ht.Add(st.ID, st);
            else
                Console.WriteLine("{0} da ton tai", st.ID);

            st = new Student() { ID = 103, Name = "Trong", Age = 15 };
            if (!ht.ContainsKey(st.ID))
                ht.Add(st.ID, st);
            else
                Console.WriteLine("{0} da ton tai", st.ID);

            // in key 
            foreach (int key in ht.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine(" key => value"); 
            foreach (int key in ht.Keys)
            {
                Console.WriteLine("Key={0}; value={1,10} | {2,-15} | {3,10}", key,
                    (ht[key] as Student).ID,
                    (ht[key] as Student).Name,
                    (ht[key] as Student).Age);
            }

            //value
            Console.WriteLine("Values");
            foreach (Student item in ht.Values)
            {
                Console.WriteLine("{0,10} | {1,-20} | {2,10}", item.ID, item.Name, item.Age);
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
