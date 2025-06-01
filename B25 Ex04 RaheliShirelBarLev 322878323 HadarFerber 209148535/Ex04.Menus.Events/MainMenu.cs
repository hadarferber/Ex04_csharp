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
        private readonly MenuItem r_RootMenu;

        public MainMenu(MenuItem root)     //ctor
        {
            r_RootMenu = root;
        }

        public void Show()
        {
            showMenu(r_RootMenu);
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

                Console.WriteLine("0. " + (currentMenu == r_RootMenu ? "Exit" : "Back"));
                Console.WriteLine("Please enter your choice (1-2 or 0 to exit):");
                Console.Write(">> ");

                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    throw new FormatException("Invalid choice, should be 1-2 or 0 to exit.");
                }
                
                if (choice < 0 || choice > currentMenu.SubItems.Count)
                {
                    throw new Exception("Invalid choice, should be 1-2 or 0 to exit.");
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
