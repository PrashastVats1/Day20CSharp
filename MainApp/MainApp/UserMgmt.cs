using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace MainApp
{
    public class UserMgmt
    {
        public void CreateUser(string username, string password)
        {
            if (DataValidator.IsPositiveNumber(username.Length))
            {
                Logger.LogInfo($"Creating User: { username}");
                Console.WriteLine($"Password is: {password}");
            }
            else
            {
                Logger.LogError("Invalid Username");
            }
        }
    }
}
