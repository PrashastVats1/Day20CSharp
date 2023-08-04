using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public class DataValidator
    {
        public static bool IsPositiveNumber(int num)
        {
            return num > 0;
        }
    }
}
