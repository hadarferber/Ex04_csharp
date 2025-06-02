using Ex04.Menus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {

        public static void Main()
        {
            MenuBuilder builder = new MenuBuilder();
            MenuItem rootMenuItem = builder.BuildMainMenu();
            MainMenu menuManager = new MainMenu(rootMenuItem);
            menuManager.Show();
        }





    }
}
