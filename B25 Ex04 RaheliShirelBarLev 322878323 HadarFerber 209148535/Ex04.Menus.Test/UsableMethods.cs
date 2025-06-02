using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class UsableMethods
    {
        public void CountLowercaseLetters()
        {
            Console.Clear();
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

        public void ShowVersion()
        {
            Console.Clear();
            Console.WriteLine("App Version: 25.2.4.4480");
            pressAKeyToContinue();
        }

        public void ShowDate()
        {
            Console.Clear();
            Console.WriteLine($"> Current Date: {DateTime.Now:dd-MM-yyyy}");
            pressAKeyToContinue();
        }

        public void ShowTime()
        {
            Console.Clear();
            Console.WriteLine($"> Current Time is {DateTime.Now:HH:mm}");
            pressAKeyToContinue();
        }

        private void pressAKeyToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

    }
}
