using Ex04.Menus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    public class Program
    {

        public static void Main()
        {
            /*MenuBuilder builder = new MenuBuilder();
            MenuItem rootMenuItem = builder.BuildMainMenu();
            MainMenu menuManager = new MainMenu(rootMenuItem);
            menuManager.Show();*/

            // Interfaces menu (static call)
            IMenuBuilder interfacesBuilder = new IMenuBuilder();
            Ex04.Menus.Interfaces.MenuItem interfaceRoot = interfacesBuilder.BuildMainMenu();
            Ex04.Menus.Interfaces.MainMenu interfaceMenu = new Ex04.Menus.Interfaces.MainMenu(interfaceRoot);
            interfaceMenu.Show();

            // Events menu (instance call)
            MenuBuilder eventsBuilder = new MenuBuilder(); // non-static class
            Ex04.Menus.Events.MenuItem eventsRoot = eventsBuilder.BuildMainMenu();
            Ex04.Menus.Events.MainMenu eventsMenu = new Ex04.Menus.Events.MainMenu(eventsRoot);
            eventsMenu.Show();
        }

    }
}
