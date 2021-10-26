using System;

namespace Session05_02_Inheristance
{
    /// <summary>
    /// Tạo lớp cơ sở Animal
    /// Tạo các lớp kế thừa: Cat; Dog
    /// Test -> 
    /// 15'
    /// </summary>

    // Lớp Animal
    class Animal
    {
        // field / properties
        private int ID;
        protected string Food;
        protected string Activity;

        // Constructor
        public Animal()
        {
            ID = 100;
            Food = "Food";
            Activity = "Activity";
        }

        public Animal(int ID, string Food,string Activity)
        {
            this.ID = ID;
            this.Food = Food;
            this.Activity = Activity;
        }
        // Method
        public void Eat()
        {
            Console.WriteLine("Eating....");
        }

        public void DoSomething()
        {
            Console.WriteLine("Do something....");
        }

    }
    // Lớp dẫn xuất; kế thừa
    class Cat : Animal
    {
        public string Name { get; set; }

        // Kế thừa constructor
        public Cat() : base() { }

        public Cat(string Name):base(1000,"Cá","Cat activity")
        {
            this.Name = Name;
        }


        // method 
        public void Action()
        {
            Eat();
            DoSomething();
        }
        public new void Eat() // phương thức trùng tên với lớp cơ sở
        {
            Console.WriteLine("Eat trong lop Dog");
        }

        // display();
        public void Display()
        {
           // Console.WriteLine("ID\t:" + ID);
            Console.WriteLine("Food\t:" + Food);
            Console.WriteLine("Activity\t:" + Activity);
            Console.WriteLine("Name\t:" + Name);
        }
    }
    //Lớp dẫn xuất Dog
    class Dog : Animal
    {
        public void Eat() // phương thức trùng tên với lớp cơ sở
        {
            Console.WriteLine("Eat trong lop Dog");
        }
        public Dog()
        {
            //ID = 100; không truy cập được biến private từ lớp con
            Food = "Xuong";
            Activity = "ACB";
        }
        
        public void Show()
        {
            Eat(); //lay tai lop con
            Console.WriteLine("Food:" + Food);
            Console.WriteLine("Activity:" + Activity);
            base.Eat(); // truy cap đến lớp cha
        }
    }
    
    /// <summary>
    /// tes
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.Eat();
            a.DoSomething();

            Cat c = new Cat();
            c.Eat();
            c.DoSomething();

            c.Display();

            Console.WriteLine("Gọi action in Cat");
            c.Action();


            Dog d = new Dog();
            d.Show();
            //d.Food = "Xuong"; lỗi


            Console.WriteLine("Cat constructor có tham so");
            c = new Cat("Me nhat");
            c.Display();
        }
    }
}
