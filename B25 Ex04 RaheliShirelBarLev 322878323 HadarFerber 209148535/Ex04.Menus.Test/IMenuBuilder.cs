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
        private readonly UsableMethods r_UsableMethods;

        public IMenuBuilder(UsableMethods i_UsableMethods)
        {
            r_UsableMethods = i_UsableMethods;    
        }

        public MenuItem BuildMainMenu()
        {
            MenuItem root = new MenuItem("Delegates Main Menu");

            MenuItem lettersMenu = new MenuItem("Version and Letters");
            lettersMenu.AddSubItem(new MenuItem("Show Version", new ShowVersion(r_UsableMethods)));
            lettersMenu.AddSubItem(new MenuItem("Count Lowercase Letters", new CountLowercaseLetters(r_UsableMethods)));
                                                                  
            MenuItem timeDateMenu = new MenuItem("Show Current Date/Time");
            timeDateMenu.AddSubItem(new MenuItem("Show Current Date", new IShowDateAction(r_UsableMethods)));
            timeDateMenu.AddSubItem(new MenuItem("Show Current Time", new ShowTimeAction(r_UsableMethods)));

            root.AddSubItem(lettersMenu);
            root.AddSubItem(timeDateMenu);

            return root;
        }
    }
}
