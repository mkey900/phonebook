using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class HelpCommands
    {

        List<string> HelpCommandsList { get; set; }

        public HelpCommands()
        {
            HelpCommandsList = new List<string> { };
            HelpCommandsList.Add("          Available commands:");
            HelpCommandsList.Add("          Type 'HELP' to get a list of available commands");
            HelpCommandsList.Add("          Type 'FIND' to search for a person");
            HelpCommandsList.Add("          Type 'ADD' to add a person");
            HelpCommandsList.Add("          Type 'DELETE' to delete a person");
            HelpCommandsList.Add("          Type 'CLS' to clear scren");
            HelpCommandsList.Add("          To exit at any time type 'EXIT' command");
        }

        public void writeHelpCommands() {
            for (int i = 0; i < HelpCommandsList.Count(); i++) {
                Console.WriteLine(HelpCommandsList[i]);
            }
        }

    }
}
