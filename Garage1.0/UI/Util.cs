using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    public static class Util
    {
       
        public static string AskForString( IUI ui)
        {
            bool success = false;
            string answer;

            do
            {
                //ui.Print(prompt);
                answer = ui.GetInput();

                if (string.IsNullOrWhiteSpace(answer))
                {
                    ui.Print("You must enter something");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        public static int AskForInt(IUI ui)
        {
            bool success = false;
            int answer;

            do
            {
                string input = AskForString(ui);
                success = int.TryParse(input, out answer) && answer >=  0;

                if (!success)
                    ui.Print("error:S input value must be numbers");

            } while (!success);

            return answer;

        }
        public static double AskForDouble(IUI ui)
        {
            bool success = false;
            double answer;

            do
            {
                string input = AskForString(ui);
                success = double.TryParse(input, out answer) && answer >0;

                if (!success)
                    ui.Print("Error: ");

            } while (!success);

            return answer;

        }
    }
}
