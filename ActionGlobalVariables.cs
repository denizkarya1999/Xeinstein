using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xeinstein
{
    public class ActionGlobalVariables
    {
        //Declare the necessary global variables
        public static Dictionary<string, string>? jokes;
        public static List<string>? stories;
        public static void initializeJokes()
        {
            jokes = new Dictionary<string, string>();
            jokes.Add("What happens if you inject math from vein?", "YOU BECOME SMART!!!");
            jokes.Add("What is the type of English that Asians speak?", "Engrish");
            jokes.Add("How to offend a guy with pink hair and feminine cloths?", "By using the wrong pronouns!");
            jokes.Add("What is the best place you can meet with African American ladies?", "KFC");
        }
        public static void initializeStories()
        {
            stories = new List<string>();
            stories.Add("There was a guy and he died.");
            stories.Add("A trans woman was entered to the store. Store owner accidentaly called her sir. He left the store crying. Stores sales were increased.");
            stories.Add("There was a Japanese in Chinese restaurant. Japanese didn`t understand the Chinese waiter. Japanese went to Sushi restaurant.");
        }
    }
}
