using Microsoft.VisualBasic;
using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;

namespace Xeinstein
{
    public class XensteinChat
    {

        // Detect every single word and put them in a string.
        public static string[] ParseWords(string input)
        {
            // Use a regular expression to find words.
            MatchCollection matches = Regex.Matches(input, @"\b\w+\b");

            // A variable to store the words.
            List<string> words = new List<string>();

            // In each Regex match, add the value to the list.
            foreach (Match match in matches)
            {
                words.Add(match.Value);
            }

            // Return the list as an array.
            return words.ToArray();
        }

        // Determine the actions based on command and the word recieved.
        public static bool processChat(string[] words)
        {
            // Go line by line and determine the action
            foreach (string word in words)
            {
                if (word.ToUpper() == "EXIT")
                {
                    Actions.DetermineTerminalLoop();
                    return true;
                }
                else if (word.ToUpper() == "CLEAR")
                {
                    Actions.ClearScreen();

                    // Greet the user with a text screen
                    Console.WriteLine("Xeinstein Chat 1.0 Terminal Edition");
                    Console.WriteLine("===========================================================");
                    return true;
                }
                else if (word.ToUpper() == "ANNOY")
                {
                    //This will beep 27 times
                    for(int i = 0; i <= 27; i++)
                    {
                        Console.Beep();
                    }
                    return true;
                }
            }
            return false;
        }
    }
}