using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTimeAction : IMenuAction
    {
        public void Execute() {
            UsableMethods utils = new UsableMethods();
            utils.ShowTime(); ;
        }
    }
}
