using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xeinstein
{
    public class GlobalVariables
    {
        public static string? userInput; //Sets the sentence recieved by the user.
        public static string[] processedUserInput; //Sets the sentence recieved by the user.
        public static bool isProcessed; //Make sure whether the command is processed or not.

        //Global variables for the loop
        public static string? loopDecision;
        public static bool isInLoop;
    }
}
