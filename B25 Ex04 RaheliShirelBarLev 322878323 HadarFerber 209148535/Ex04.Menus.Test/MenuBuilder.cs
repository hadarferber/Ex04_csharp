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
            MenuItem root = new MenuItem("Delegates Main Menu");

            MenuItem lettersMenu = new MenuItem("Letters and Version");
            MenuItem dateTimeMenu = new MenuItem("Show Current Date/Time");

            MenuItem showVersion = new MenuItem("Show Version", ShowVersion);
            MenuItem countLetters = new MenuItem("Count Lowercase Letters", CountLowercaseLetters);
            MenuItem showDate = new MenuItem("Show Current Date", ShowDate);
            MenuItem showTime = new MenuItem("Show Current Time", ShowTime);

            lettersMenu.AddSubItem(showVersion);
            lettersMenu.AddSubItem(countLetters);

            dateTimeMenu.AddSubItem(showDate);
            dateTimeMenu.AddSubItem(showTime);

            root.AddSubItem(lettersMenu);
            root.AddSubItem(dateTimeMenu);

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
            pressAKeyToContinue();

        }

        private static void ShowVersion()
        {
            Console.WriteLine("App Version: 25.2.4.4480");
            pressAKeyToContinue();
        }

        private static void ShowDate()
        {
            Console.WriteLine($"> Current Date: {DateTime.Now}");
            pressAKeyToContinue();
        }

        private static void ShowTime()
        {
            Console.WriteLine($"> Current Time is {DateTime.Now:HH:mm}");
            pressAKeyToContinue();
        }

        private static void pressAKeyToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }


    }

}
