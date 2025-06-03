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
        private Events.MainMenu m_EventsMainMenu;
        private Interfaces.MainMenu m_InterfacesMainMenu;

        public static void Main()
        {
            Program program = new Program();

            program.setUpProgram(out Interfaces.MenuItem interfaceRoot, out Events.MenuItem eventsRoot);
            program.m_InterfacesMainMenu = new Interfaces.MainMenu(interfaceRoot);  // Interfaces menu
            program.m_InterfacesMainMenu.Show();
            program.m_EventsMainMenu = new Events.MainMenu(eventsRoot); // Events menu
            program.m_EventsMainMenu.Show();

        }

        private void setUpProgram(out Interfaces.MenuItem o_InterfaceRoot, out Events.MenuItem o_EventsRoot)
        {
            UsableMethods usableMethods = new UsableMethods();
            IMenuBuilder interfacesBuilder = new IMenuBuilder(usableMethods);
            Interfaces.MenuItem interfaceRoot = interfacesBuilder.BuildMainMenu();

            o_InterfaceRoot = interfaceRoot;
            MenuBuilder eventsBuilder = new MenuBuilder(); // non-static class
            Events.MenuItem eventsRoot = eventsBuilder.BuildMainMenu();

            o_EventsRoot = eventsRoot;
        }

    }
}
