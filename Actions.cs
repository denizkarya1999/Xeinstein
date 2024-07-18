using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xeinstein
{
    public class Actions
    {
        //This method determines whether the terminal program should be closed or not.
        public static void DetermineTerminalLoop()
        {
            //Ask user whether they want to continue or not.
            Console.WriteLine("\nWould you like to continue chatting with Xeinstein? YES or NO");
            Console.Write("-> ");
            GlobalVariables.loopDecision = Console.ReadLine();

            //Make the decision here.
            if (GlobalVariables.loopDecision.ToUpper() == "NO")
            {
                GlobalVariables.isInLoop = false;
            }
            else if (GlobalVariables.loopDecision.ToUpper() == "YES")
            {
                GlobalVariables.isInLoop = true;
            }
            else
            {
                GlobalVariables.isInLoop = true;
                Console.WriteLine("Invalid Answer (Error 002): Please either say YES or NO next time.");
            }
        }

        // This method determines whether the screen can be cleared or not
        public static void ClearScreen()
        {
            Console.Clear();
        }
    }
}
