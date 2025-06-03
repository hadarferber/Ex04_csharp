using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        private readonly string r_Title;
        public event Action MenuItemWasChosen;
        private List<MenuItem> m_SubMenuItems;
        
        public List<MenuItem> SubMenuItems
        {
            get { return m_SubMenuItems; }
        }

        public MenuItem(string i_Title, Action i_Function = null) //ctor
        {
            r_Title = i_Title;
            MenuItemWasChosen = i_Function;
            m_SubMenuItems = new List<MenuItem>();
        }
      
        public bool IsLeaf()
        {
            return (MenuItemWasChosen != null);
        }

        public string Title
        {
            get { return r_Title; }
        }

        public void AddSubMenuItem(MenuItem item)
        {
            m_SubMenuItems.Add(item);
        }

        private void OnMenuItemWasChosen()
        {
            if (MenuItemWasChosen != null)
            {
                MenuItemWasChosen.Invoke();
            }
        }

        public void AMenuItemWasChosen()
        {
            OnMenuItemWasChosen();
        }
    }
}