using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.Log
{
    sealed public class LogAdapter
    {
        public static void Log(string LogText)
        {
            Console.WriteLine(LogText);
        } 
    }
}
