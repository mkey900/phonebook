using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to my very special phone book!");
            Console.ResetColor();
            Console.WriteLine();

            Dictionary<int, string> phonebook = new Dictionary<int, string> ();
            HelpCommands helpCommands = new HelpCommands();
            helpCommands.writeHelpCommands();

            string command = Console.ReadLine().ToUpper();

            while (!command.Equals("EXIT"))
            {
                switch (command)
                {
                    case "HELP":
                        helpCommands.writeHelpCommands();
                        break;
                    case "FIND":

                        Console.WriteLine("Type the name of a contact you want to look up");
                        string nameToFind = Console.ReadLine();
                        DictionaryOperations.FindInDictionary(phonebook, nameToFind.ToLower());
                        break;

                    case "ADD":
                        Console.WriteLine("Type the name");
                        string nameToAdd = Console.ReadLine();
                        Console.WriteLine("Type phone number");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            DictionaryOperations.AddNewEntryToPhoneBook(phonebook, number, nameToAdd);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("New contact has been added");
                            Console.ResetColor();
                        }
                        catch (Exception e) {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Incorrect phone number");
                            Console.ResetColor();
                        }                                             
                        break;

                    case "DELETE":
                        Console.WriteLine("Type the name of a contact you want to delete");
                        string nameToDelete = Console.ReadLine();
                        DictionaryOperations.DeleteFromDictionary(phonebook, nameToDelete.ToLower());
                        break;

                    case "CLS":
                        Console.Clear();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect command. For a list of acailable commands type 'HELP'");
                        Console.ResetColor();
                        break;
                }
                command = Console.ReadLine().ToUpper();
            }
        }
    }
}
