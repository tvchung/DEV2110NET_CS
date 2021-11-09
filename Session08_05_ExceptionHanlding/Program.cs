using System;

namespace Session08_05_ExceptionHanlding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception!");
            string[] names = { "Devmastter", "Academy", "Chung", "Trinh" };
            int num = 0;
            int result;
            try
            {
                Console.WriteLine("Day la noi dung khoi try catch ngoai");
                try
                {
                    result = 123 /num;
                }
                catch (Exception ex1)
                {
                    Console.WriteLine(ex1.Message);
                }

                names[10] = "Hahaha";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }

            Console.WriteLine(names[0]); // van lam viec binh thuong
        }
    }
}
