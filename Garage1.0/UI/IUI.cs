using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    public interface IUI
    {
        string GetInput();
        public void Print(string str);
        public void PrintSL(string str);
    }
}
