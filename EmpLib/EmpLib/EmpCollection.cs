using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class EmpCollection
    {
        static List<Emp> empList = new List<Emp>()
        {
            new Emp {Id = 1, Name ="Samantha", Salary=600000.50},
            new Emp {Id = 2, Name ="Rajantha", Salary=98000.75},
            new Emp {Id = 3, Name ="Amantha", Salary=60000.50},
            new Emp {Id = 4, Name ="Bamantha", Salary=50000.25},
            new Emp {Id = 5, Name ="Camantha", Salary=2000000.15},
            new Emp {Id = 6, Name ="Damantha", Salary=41375.15},
        };
        public static void AddEmp()
        {
            Emp emp = new Emp();
            Console.WriteLine("Enter Employee Id");
            emp.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            emp.Salary = double.Parse(Console.ReadLine());
            empList.Add(emp);
            Console.WriteLine("Added in Employee List");
        }
        public static void RemoveEmp()
        {
            Console.WriteLine("Enter Employee Id");
            int id = int.Parse(Console.ReadLine());
            Emp emp = empList.SingleOrDefault(e => e.Id == id);
            if (emp != null)
            {
                empList.Remove(emp);
                Console.WriteLine("Selected Employee details have been deleted!!");
            }
            else
            {
                Console.WriteLine("No such employee exists");
            }
        }
        public static void Display()
        {
            foreach(Emp e  in empList)
            {
                Console.WriteLine("ID: \t" + e.Id);
                Console.WriteLine("Name: \t" + e.Name);
                Console.WriteLine("Salary: \t" + e.Salary);
            }
        }
    }
}
