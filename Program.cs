using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Xeinstein
{
    class Program
    {
        static void Main()
        {
            // Variable for the loop
            GlobalVariables.isInLoop = true;

            // Greet the user with a text screen
            Console.WriteLine("Xeinstein Chat 1.0 Terminal Edition");
            Console.WriteLine("===========================================================");

            // Play a beep sound upon initialization
            Console.Beep();

            //Enter into loop
            while (GlobalVariables.isInLoop) {
              //Empty space
              Console.WriteLine();

              // Prompt user to enter a message
              Console.WriteLine("Say anything would you like to say.");
              Console.Write("-> ");

              // Recieve the inputs from the user.
              GlobalVariables.userInput = Console.ReadLine();

              // Set the processed array based on the input recieved from the user.
              GlobalVariables.processedUserInput = XensteinChat.ParseWords(GlobalVariables.userInput);

              // Trigger the processChat method and initialize with the message.
              GlobalVariables.isProcessed = XensteinChat.processChat(GlobalVariables.processedUserInput);

              // If result is false then send a message
              if (GlobalVariables.isProcessed == false)
               {
                 Console.WriteLine("Operation Failed (Error 001): Unfortunately, Xeinstein failed to understand your message");
               }

             if (GlobalVariables.isInLoop == false)
              {
                 break;
              }
            else if (GlobalVariables.isInLoop == true)
              {
                 continue;
              }
            }
        }
    }
}
