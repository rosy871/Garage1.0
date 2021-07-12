using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    public class ConsoleUI : IUI
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }


        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void PrintSL(string str)
        {
            Console.Write(str);
        }
    }
}
