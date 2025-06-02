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
        private readonly UsableMethods r_UsableMethods;

        public MenuBuilder()
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

            lettersMenu.AddSubItem(showVersionMenuItem);
            lettersMenu.AddSubItem(countLettersMenuItem);

            dateTimeMenu.AddSubItem(showDateMenuItem);
            dateTimeMenu.AddSubItem(showTimeMenuItem);

            rootMenuItem.AddSubItem(lettersMenu);
            rootMenuItem.AddSubItem(dateTimeMenu);

            return rootMenuItem;
        }


    }

}
