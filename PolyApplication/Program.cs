using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrideApplication
{

    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";
        public  virtual void PrintFullName() //Method Overloading
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()//Method Overloading
        {
            Console.WriteLine(FirstName + "" + LastName + "-FullTime");
        }
    }
    public class  PartTimeEmployee : Employee
    {
        public override void PrintFullName() //Method Overloading
        {
            Console.WriteLine(FirstName + "" + LastName + "-PartTime");
        }
    }
    public class TemporaryEmployee : Employee
    {
        public new void PrintFullName() //Method Hiding
        {
            Console.WriteLine(FirstName + "" + LastName + "-Temp");
        }
    }
    public class Program
    {
    public static void Main()
        {
            Employee[] Employees = new Employee[4];
            Employees[0] = new Employee();
            Employees[1] = new FullTimeEmployee();
            Employees[2] = new PartTimeEmployee();
            Employees[3] = new TemporaryEmployee();
            foreach (Employee e in Employees)
            {
                e.PrintFullName();
                
            }
            Console.ReadLine();
        }
    }
}
