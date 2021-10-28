using System;

namespace Session06_00_Review
{
    /// <summary>
    /// Inheristance
    /// Polymorphism (Overloading, overriding)
    /// Enscapsolation
    /// 
    /// </summary>
    /// 

    /// Basa class
    class BaseClass
    {
        // field|properties
        public int ID { get; set; }
        public string Name { get; set; }

        public float  Salary { get; set; }

        // Constructor
        public BaseClass() { }
        public BaseClass(int ID, string Name, float Salary)
        {
            this.ID = ID;
            this.Name = Name;
            this.Salary = Salary;
        }

        // Method ([virtual])

        public virtual void Display()
        {
            Console.WriteLine("ID:" + ID);
            Console.WriteLine("Name: " + Name);
        }

        public virtual float Total()
        {
            return Salary;
        }
    }

    /// <summary>
    /// Drived Class
    /// </summary>
    /// 
    class DrivedClass : BaseClass
    {
        // properties
        public float Bonus { get; set; }

        // Constructor (Kế thừa constructor)
        public DrivedClass() : base() { }

        public DrivedClass(int ID, string Name, float Salary, float Bonus) 
            : base(ID, Name, Salary)
        {
            this.Bonus = Bonus;
        }

        // Method
        public override float Total()
        {
            return base.Total()+Bonus;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Total:" + Total());
        }

    }

    /// <summary>
    /// test
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test!");
            DrivedClass dc = new DrivedClass(100, "Chung", 1000, 100);
            dc.Display();

            Console.WriteLine("Total:" + dc.Total());
        }
    }
}
