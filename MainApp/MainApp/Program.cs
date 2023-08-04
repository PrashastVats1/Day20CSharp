using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userMgmt = new UserMgmt();
            while (true)
            {
                Console.WriteLine("Enter User Name (type 'exit' to stop program)");
                string userName = Console.ReadLine();
                if (userName.ToLower() == "exit")
                {
                    break;
                }
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                userMgmt.CreateUser(userName, password);
            }
            Console.WriteLine("Exiting the application");
            Console.ReadKey();
        }
    }
}
