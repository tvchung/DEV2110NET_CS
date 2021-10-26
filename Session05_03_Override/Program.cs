using System;

namespace Session05_03_Override
{
    /// <summary>
    /// Tạo lớp cơ sở=> Employee
    /// Tạo phương thức vơi từ khóa virtual => cho phép ghi đè ở lớp kế thừa (Mô tả tính chất đa hình trong lập trình hương đối tượng)
    /// </summary>
    class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }

        public Employee(string name, decimal BaseSalary)
        {
            this.Name = name;
            this.BaseSalary = BaseSalary;
        }

        // Khai báo phương thức virtual có thể cho phép ghi đề trên lớp con
        public virtual decimal CalculatorSalary()
        {
            return BaseSalary;
        }
    }

    /// <summary>
    /// Lớp dẫn xuất: SaleEmployee
    /// Phương thức với từ khóa override => ghi đề phương thức từ lớp cha
    /// </summary>
    
    class SaleEmployee : Employee
    {
        public decimal Bonus { get; set; }

        public SaleEmployee(string Name, decimal BaseSalary, decimal Bonus) 
            : base(Name, BaseSalary)
        {
            this.Bonus = Bonus;
        }

        // Phương thức ghi đê
        public override decimal CalculatorSalary()
        {
            decimal total = base.CalculatorSalary();
            total += Bonus;
            return total;
        }

        public override string ToString()
        {
            return string.Format("\n Name: {0} \n BaseSalary:{1}\n Bonus: {2} \n Total:{3}",
                Name,BaseSalary,Bonus, CalculatorSalary());
        }
    }
    
    /// <summary>
    /// test
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SaleEmployee sEmp = new SaleEmployee("Chung", 1000, 5000);
            Console.WriteLine(sEmp.ToString());

            decimal t = sEmp.CalculatorSalary();
            Console.WriteLine(t);
        }
    }
}
