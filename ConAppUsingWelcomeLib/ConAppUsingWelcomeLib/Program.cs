﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeLib;

namespace ConAppUsingWelcomeLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Welcome welcome = new Welcome();
            welcome.Display("Rajiv", "Ranjan");
            Console.ReadKey();
        }
    }
}
