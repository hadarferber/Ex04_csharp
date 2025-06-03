using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountLowercaseLetters : IMenuAction
    {
        private readonly UsableMethods r_UsableMethods;

        public CountLowercaseLetters(UsableMethods i_UsableMethods)
        {
            r_UsableMethods = i_UsableMethods;
        }

        public void ExecuteAction()
        {
            r_UsableMethods.CountLowercaseLetters();
        }
    }
}
