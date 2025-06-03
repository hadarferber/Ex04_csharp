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

        private void showMenu(MenuItem i_CurrentMenuItem)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"** {i_CurrentMenuItem.Title} **");
                Console.WriteLine(new string('-', i_CurrentMenuItem.Title.Length + 6));
                for (int i = 0; i < i_CurrentMenuItem.SubMenuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {i_CurrentMenuItem.SubMenuItems[i].Title}");
                }

                Console.WriteLine("0. " + (i_CurrentMenuItem == r_RootMenuItem ? "Exit" : "Back"));
                Console.WriteLine("Please enter your choice (1-2 or 0 to exit):");
                Console.Write(">> ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int userChoice) || userChoice < 0 || userChoice > i_CurrentMenuItem.SubMenuItems.Count)
                {
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadLine();
                    continue;
                }

                if (userChoice == 0)
                {
                    break;
                }

                MenuItem selectedMenuItem = i_CurrentMenuItem.SubMenuItems[userChoice - 1];

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