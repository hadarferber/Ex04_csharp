using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MainMenu
    {
        private readonly MenuItem r_RootMenuItem;

        public MainMenu(MenuItem i_MenuItem)//ctor
        {
            r_RootMenuItem = i_MenuItem;
        }

        public void Show()
        {
            showMenu(r_RootMenuItem);
        }

        private void showMenu(MenuItem currentMenuItem)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"** {currentMenuItem.Title} **");
                Console.WriteLine(new string('-', currentMenuItem.Title.Length + 6));
                for (int i = 0; i < currentMenuItem.SubMenuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {currentMenuItem.SubMenuItems[i].Title}");
                }

                Console.WriteLine("0. " + (currentMenuItem == r_RootMenuItem ? "Exit" : "Back"));
                Console.WriteLine("Please enter your choice (1-2 or 0 to exit):");
                Console.Write(">> ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int userChoice) || userChoice < 0 || userChoice > currentMenuItem.SubMenuItems.Count)
                {
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadLine();
                    continue;
                }

                if (userChoice == 0)
                {
                    break;
                }

                MenuItem selectedMenuItem = currentMenuItem.SubMenuItems[userChoice - 1];

                if (selectedMenuItem.IsLeaf())
                {
                    selectedMenuItem.AMenuItemWasChosen();
                }
                else
                {
                    showMenu(selectedMenuItem);
                }
            }
        }
    }
}