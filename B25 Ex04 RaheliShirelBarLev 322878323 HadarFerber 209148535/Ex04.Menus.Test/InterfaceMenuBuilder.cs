using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    public class InterfaceMenuBuilder
    {
        private readonly UsableMethods r_UsableMethods;

        public InterfaceMenuBuilder(UsableMethods i_UsableMethods)
        {
            r_UsableMethods = i_UsableMethods;    
        }

        public MenuItem BuildMainMenu()
        {
            MenuItem root = new MenuItem("Delegates Main Menu");

            MenuItem lettersMenu = new MenuItem("Letters and Version");
            lettersMenu.AddSubMenuItem(new MenuItem("Show Version", new ShowVersion(r_UsableMethods)));
            lettersMenu.AddSubMenuItem(new MenuItem("Count Lowercase Letters", new CountLowercaseLetters(r_UsableMethods)));
                                                                  
            MenuItem timeDateMenu = new MenuItem("Show Current Date/Time");
            timeDateMenu.AddSubMenuItem(new MenuItem("Show Current Date", new IShowDateAction(r_UsableMethods)));
            timeDateMenu.AddSubMenuItem(new MenuItem("Show Current Time", new ShowTimeAction(r_UsableMethods)));

            root.AddSubMenuItem(lettersMenu);
            root.AddSubMenuItem(timeDateMenu);

            return root;
        }
    }
}
