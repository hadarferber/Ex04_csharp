using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    public class IMenuBuilder
    {
        public MenuItem BuildMainMenu()
        {
            MenuItem root = new MenuItem("Delegates Main Menu");

            MenuItem lettersMenu = new MenuItem("Version and Letters");
            lettersMenu.AddSubItem(new MenuItem("Show Version", new ShowVersion()));
            lettersMenu.AddSubItem(new MenuItem("Count Lowercase Letters", new CountLowercaseLetters()));

            MenuItem timeDateMenu = new MenuItem("Show Current Date/Time");
            timeDateMenu.AddSubItem(new MenuItem("Show Current Date", new IShowDateAction()));
            timeDateMenu.AddSubItem(new MenuItem("Show Current Time", new ShowTimeAction()));

            root.AddSubItem(lettersMenu);
            root.AddSubItem(timeDateMenu);

            return root;
        }
    }
}
