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

        public MainMenu(MenuItem i_Root)     //ctor
        {
            r_RootMenuItem = i_Root;
        }

        public void Show()
        {
            showMenu(r_RootMenuItem);
        }

        private void showMenu(MenuItem currentMenu)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"** {currentMenu.Title} **");
                Console.WriteLine(new string('-', currentMenu.Title.Length + 6));
                for (int i = 0; i < currentMenu.SubItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {currentMenu.SubItems[i].Title}");
                }

                Console.WriteLine("0. " + (currentMenu == r_RootMenuItem ? "Exit" : "Back"));
                Console.WriteLine("Please enter your choice (1-2 or 0 to exit):");
                Console.Write(">> ");

                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice) || choice < 0 || choice > currentMenu.SubItems.Count)
                {
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadLine();

                    continue;
                }

                if (choice == 0)
                {
                    break;
                }

                MenuItem selectedMenuItem = currentMenu.SubItems[choice - 1];

                if (selectedMenuItem.IsLeaf)
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
