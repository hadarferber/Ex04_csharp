using Ex04.Menus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class MenuBuilder
    {
        public static MenuItem BuildMainMenu()
        {
            MenuItem root = new MenuItem("Main Menu");

            MenuItem lettersMenu = new MenuItem("Letters and Version");

            MenuItem countLetters = new MenuItem("Count Lowercase Letters", CountLowercaseLetters);

            MenuItem showVersion = new MenuItem("Show Version", ShowVersion);

            lettersMenu.AddSubItem(showVersion);
            lettersMenu.AddSubItem(countLetters);

            root.AddSubItem(lettersMenu);

            return root;
        }

        private static void CountLowercaseLetters()
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();
            int count = 0;
            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }
            Console.WriteLine($"> There are {count} lowercase letters.");
        }

        private static void ShowVersion()
        {
            Console.WriteLine("App Version: 25.2.4.4480");
        }

       
    }

}
