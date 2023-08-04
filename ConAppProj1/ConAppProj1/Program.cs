using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpLib;

namespace ConAppProj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpCollection.AddEmp();
            EmpCollection.Display();
            Console.ReadKey();
        }
    }
}
