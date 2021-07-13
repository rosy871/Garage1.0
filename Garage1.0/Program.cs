using System;

namespace Garage1._0
{

    class Program
    {

        static void Main(string[] args)
        {
            IGarageHandlar gh = new GarageHandlar();
            IUI ui = new ConsoleUI();
            GarageUI gi = new GarageUI(gh, ui);
           

            gi.StartProj();
           


        }
    }
}
