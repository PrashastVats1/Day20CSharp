using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toshiba;
using LG;

namespace ConAppCustomNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV obj = new TV();
            obj.Display();
            //Error CS0104  'WashingMachine' is an ambiguous reference between 'LG.WashingMachine' and 'Toshiba.WashingMachine'
            //WashingMachine machine = new WashingMachine();
            LG.WashingMachine machine = new LG.WashingMachine();
            machine.Display();
            Toshiba.WashingMachine machine1 = new Toshiba.WashingMachine();
            machine1.Display();
            Console.ReadKey();
        }
    }
}
