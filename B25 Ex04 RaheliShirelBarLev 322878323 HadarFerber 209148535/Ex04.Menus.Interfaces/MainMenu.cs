using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly MenuItem r_Root;

        public MainMenu(MenuItem root)
        {
            r_Root = root;
        }

        public void Show()
        {
            showMenu(r_Root);
        }

        private void showMenu(MenuItem current)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"** {current.Title} **");
                Console.WriteLine(new string('-', current.Title.Length + 6));

                for (int i = 0; i < current.SubItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {current.SubItems[i].Title}");
                }

                Console.WriteLine("0. " + (current == r_Root ? "Exit" : "Back"));
                Console.Write("Please enter your choice: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice) || choice < 0 || choice > current.SubItems.Count)
                {
                    Console.WriteLine("Invalid choice. Press Enter to try again...");
                    Console.ReadLine();
                    continue;
                }

                if (choice == 0)
                    break;

                MenuItem selected = current.SubItems[choice - 1];

                if (selected.IsLeaf)
                {
                    Console.Clear();
                    selected.Activate();
                  
                }
                else
                {
                    showMenu(selected);
                }
            }
        }
    }
}
