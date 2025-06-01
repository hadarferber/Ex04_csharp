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

        static void Main()
        {
            MenuItem root = MenuBuilder.BuildMainMenu();
            MainMenu manager = new MainMenu(root);
            manager.Show();
        }





    }
}
