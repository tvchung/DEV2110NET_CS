using System;

namespace Session07_02_Lab04_4
{
    /// <summary>
    /// : Implement a class named Person();
    /// A Person has a name, phone number and email address
    /// </summary>
    /// 
    class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    /// <summary>
    /// A student has a program to which he/she enrolled ( Business, Computer Science...)
    /// </summary>
    /// 
    class Student : Person
    {
        public string Enrolled { get; set; }

        public override string ToString()
        {
            return string.Format("\n Name: {0} \n Phone:{1} \n Email:{2} \n Enrolled:{3}",
                Name, Phone, Email, Enrolled);
        }
    }
    /// <summary>
    /// An Employee has a department, salary and the date hired. 
    /// Define a CalculateBonus and CalculateVacation as abstract methods in Employee class 
    /// </summary>
    /// 
    abstract class Employee : Person
    {
        public string Department { get; set; }
        public float  Salary { get; set; }

        public DateTime DateHired { get; set; }

        public abstract double CalculateBonus();
        public abstract string CalculateVacation();

        public override string ToString()
        {
            string str= base.ToString();
            str += string.Format("\n Department:{0} \n Salary:{1} \n DateHired:{2} "
                , Department, Salary, DateHired);
            return str;

        }

    }

    /// <summary>
    /// A faculty member has office hours and a rank 
    /// </summary>

    class Faculty : Employee
    {
        public float hours { get; set; }
        public float rank { get; set; }

        public override double CalculateBonus()
        {
            return 1000 + 0.05 * Salary;
        }

        public override string CalculateVacation()
        {
            string weeks = "4 weeks";
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            if (dt.Year - DateHired.Year >= 3)
            {
                weeks = "5 weeks";
            }

            return weeks;
        }

        public override string ToString()
        {
            string str = base.ToString();
            str += string.Format("\n hours:{0} \n rank:{1} ", hours, rank);
            str += string.Format("\n sum salary:{0}", hours*rank + Salary);

            str += string.Format("\n CalculateBonus:" + CalculateBonus());
            str += string.Format("\n CalculateVacation:" + CalculateVacation());
            return str;
        }
    }

    /// <summary>
    /// A staff member has a title
    /// </summary>
    /// 
    class Staff : Employee
    {
        public string Title { get; set; }

        public override double CalculateBonus()
        {
            return 0.06 * Salary;
        }

        public override string CalculateVacation()
        {
            string weeks = "3 weeks";
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            if (dt.Year - DateHired.Year >= 5)
            {
                weeks = "4 weeks";
            }

            return weeks;
        }

        public override string ToString()
        {
            string str = base.ToString();
            str += string.Format("\n Title:{0}", Title);
            str += string.Format("\n CalculateBonus:" + CalculateBonus());
            str += string.Format("\n CalculateVacation:" + CalculateVacation());

            return str;
        }
    }

    /// <summary>
    /// test
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Faculty fac = new Faculty();
            fac.Name = "Chung";
            fac.Phone = "0978611889";
            fac.Email = "chungtrinhj@gmail.com";
            fac.Department = "Faculty";
            fac.DateHired = new DateTime(2010,11,04);
            fac.Salary = 89898989;
            fac.hours = 100;
            fac.rank = 5;

            Console.WriteLine(fac.ToString());
        }
    }
}
