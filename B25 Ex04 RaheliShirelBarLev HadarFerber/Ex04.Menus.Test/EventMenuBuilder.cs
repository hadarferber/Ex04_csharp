using Ex04.Menus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class EventMenuBuilder
    {
        private readonly UsableMethods r_UsableMethods;

        public EventMenuBuilder()
        {
            r_UsableMethods = new UsableMethods();
        }

        public MenuItem BuildMainMenu()
        {
            MenuItem rootMenuItem = new MenuItem("Delegates Main Menu");
            MenuItem lettersMenu = new MenuItem("Letters and Version");
            MenuItem dateTimeMenu = new MenuItem("Show Current Date/Time");
            MenuItem showVersionMenuItem = new MenuItem("Show Version", r_UsableMethods.ShowVersion);
            MenuItem countLettersMenuItem = new MenuItem("Count Lowercase Letters", r_UsableMethods.CountLowercaseLetters);
            MenuItem showDateMenuItem = new MenuItem("Show Current Date", r_UsableMethods.ShowDate);
            MenuItem showTimeMenuItem = new MenuItem("Show Current Time", r_UsableMethods.ShowTime);

            lettersMenu.AddSubMenuItem(showVersionMenuItem);
            lettersMenu.AddSubMenuItem(countLettersMenuItem);
            dateTimeMenu.AddSubMenuItem(showDateMenuItem);
            dateTimeMenu.AddSubMenuItem(showTimeMenuItem);
            rootMenuItem.AddSubMenuItem(lettersMenu);
            rootMenuItem.AddSubMenuItem(dateTimeMenu);

            return rootMenuItem;
        }
    }
}
