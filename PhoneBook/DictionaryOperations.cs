using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public static class DictionaryOperations
    {

        public static void AddNewEntryToPhoneBook(Dictionary<int, string> phonebook, int number, string name)
        {      
            phonebook.Add(number,name);
        }

        public static void FindInDictionary(Dictionary<int, string> phonebook, string name) {
            int count = 0;
            foreach (KeyValuePair<int, string> entry in phonebook) {
                if (entry.Value.ToLower().Equals(name))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Contact name: " + entry.Value);
                    Console.WriteLine("Contact phone: " + entry.Key);
                    Console.ResetColor();
                    count++;
                }
            }
            if (count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No such records exists in the phone book");
                Console.ResetColor();
            }
        }

        public static void DeleteFromDictionary(Dictionary<int, string> phonebook, string name) {
            int count = 0;
            for (int i = 0; i<phonebook.Count(); i++)
            {
                var element = phonebook.ElementAt(i);
                if (element.Value.ToLower().Equals(name))
                {
                    phonebook.Remove(element.Key);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Entry: "+element.Value+" "+element.Key+" has been deleted");
                    Console.ResetColor();
                    count++;
                }
            }
            if (count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No such records exists in the phone book");
                Console.ResetColor();
            }
        }

    }
}
